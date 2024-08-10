using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using vatACARS.Util;
using vatsys;
using static vatACARS.Helpers.Transceiver;
using static vatsys.FDP2;

namespace vatACARS.Components
{
    public partial class PopupWindow : BaseForm
    {
        private ErrorHandler errorHandler = ErrorHandler.GetInstance();
        private bool Direct = false;
        private string Content;
        private FDR FDR;
        public PopupWindow(string content, bool direct, FDR fdr)
        {
            InitializeComponent();
            StyleComponent();
            Direct = direct;
            Content = content;
            FDR = fdr;

            if (direct)
            {
                ShowDirectPopup(content);
            }
            else
            {
                ShowPopup(content);
            }
        }

        private void ShowDirectPopup(string content)
        {
            try
            {
                lbl_content.Text = content;
                btn_1.Text = "YES";
                btn_2.Text = "NO";
            }
            catch (Exception ex)
            {
                errorHandler.AddError(ex.ToString());
            }
        }

        private void ShowPopup(string content)
        {
            try
            {
                lbl_content.Text = content;
                btn_1.Text = "YES";
                btn_2.Text = "NO";
            }
            catch (Exception ex)
            {
                errorHandler.AddError(ex.ToString());
            }
        }

        private void StyleComponent()
        {
            try
            {
                lbl_content.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
                lbl_content.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);

                btn_1.BackColor = Colours.GetColour(Colours.Identities.CPDLCSendButton);
                btn_1.ForeColor = Colours.GetColour(Colours.Identities.NonJurisdictionIQL);

                btn_2.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
                btn_2.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            }
            catch (Exception ex)
            {
                errorHandler.AddError(ex.ToString());
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (Direct)
            {
                MMI.OpenDirectToMenu(FDR, MousePosition);
                this.Close();
            }
            if (!Direct && Content.Contains("flight level"))
            {
                try
                {
                    string formattedCFLString = (FDR.CFLString != null && int.Parse(FDR.CFLString) < 110
                    ? "A"
                    : "FL")
                    + FDR.CFLString.PadLeft(3, '0');

                    CPDLCMessage msg = new CPDLCMessage()
                    {
                        State = 0,
                        Station = FDR.Callsign,
                        Content = $"({FDR.Callsign}'s Cleared Flight Level Changed: {formattedCFLString})",
                        TimeReceived = DateTime.UtcNow
                    };

                    DispatchWindow.SelectedMessage = msg;
                    DispatchWindow.ShowEditorWindow(msg);
                    this.Hide(); 

                    Timer timer = new Timer(); // This is not the best way to do this.
                    timer.Interval = 300000; 
                    timer.Tick += (timerSender, timerEventArgs) => this.Close();
                    timer.Start();
                }
                catch (Exception ex)
                {
                    errorHandler.AddError(ex.ToString());
                }
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}