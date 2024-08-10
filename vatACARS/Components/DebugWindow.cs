using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using vatACARS.Helpers;
using vatACARS.Util;
using vatsys;
using vatACARS.Lib;
using static vatACARS.Helpers.Transceiver;
using static vatsys.Colours;
using System.Linq;
using static vatsys.CPDLC;
using System.Net.Http;

namespace vatACARS.Components
{
    public partial class DebugWindow : BaseForm
    {
        private static List<string> Airlines = new List<string>()
        {
            "QFA",
            "VCP",
            "SIA",
            "THY",
            "JST",
            "ANZ",
            "UAL",
            "QTR",
            "BAW",
            "CES",
            "PAL",
            "BTK",
            "FDX",
            "DAL",
            "VOZ",
            "AAL",
            "KLM",
            "RYR",
            "AFR",
            "ACA",
            "KAL",
            "UAE",
            "JBU",
            "SWA",
            "ETD"
        };

        private static bool netchecks = Properties.Settings.Default.netChecks;
        private string callsign;
        private ErrorHandler errorHandler = ErrorHandler.GetInstance();
        private int provider;
        public DebugWindow()
        {
            InitializeComponent();
            StyleComponent();
        }

        public static void SetChecks(bool value)
        {
            Logger logger = new Logger("vatACARS");
            if (netchecks != value)
            {
                netchecks = value;
                if (netchecks)
                {
                    Properties.Settings.Default.netChecks = true;
                    logger.Log("NetChecks ON.");
                }
                else
                {
                    Properties.Settings.Default.netChecks = false;
                    logger.Log("NetChecks OFF.");
                }
                Properties.Settings.Default.Save();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (dd_type.Text == "CPDLCMessage")
                {
                    addCPDLCMessage(new CPDLCMessage()
                    {
                        State = (MessageState)int.Parse(dd_state.Text),
                        Station = tbx_station.Text,
                        Content = tbx_content.Text,
                        TimeReceived = DateTime.UtcNow
                    });
                }
                else if (dd_type.Text == "TelexMessage")
                {
                    addTelexMessage(new TelexMessage()
                    {
                        State = (MessageState)int.Parse(dd_state.Text),
                        Station = tbx_station.Text,
                        Content = tbx_content.Text,
                        TimeReceived = DateTime.UtcNow
                    });
                }
                else
                {
                    errorHandler.AddError("Message Type not selected.");
                }
            }
            catch (Exception ex)
            {
                errorHandler.AddError(ex.ToString());
            }
        }

        private void btn_netchecks_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Properties.Settings.Default.netChecks = !Properties.Settings.Default.netChecks;
            btn_netchecks.Text = Properties.Settings.Default.netChecks ? "\u2713" : "";
            btn_netchecks.Invalidate();
            SetChecks(Properties.Settings.Default.netChecks);
            Properties.Settings.Default.Save();
        }


        private void btn_rdmstn_Click(object sender, EventArgs e)
        {
            RandomStn();
            try
            {
                addStation(new Transceiver.Station()
                {
                    Callsign = callsign,
                    Provider = provider
                });
            }
            catch (Exception ex)
            {
                errorHandler.AddError(ex.ToString());
            }
        }

        private void btn_screate_Click(object sender, EventArgs e)
        {
            try
            {
                addStation(new Transceiver.Station()
                {
                    Callsign = tbx_stationc.Text,
                    Provider = int.Parse(dd_prov.Text)
                });
            }
            catch (Exception ex)
            {
                errorHandler.AddError(ex.ToString());
            }
        }

        private void DebugWindow_Shown(object sender, EventArgs e)
        {
            btn_netchecks.Text = Properties.Settings.Default.netChecks ? "\u2713" : "";
            btn_netchecks.Invalidate();
            SetChecks(Properties.Settings.Default.netChecks);
            dd_type.Items.Add("TelexMessage");
            dd_type.Items.Add("CPDLCMessage");
            dd_state.Items.Add("0");
            dd_state.Items.Add("1");
            dd_state.Items.Add("2");
            dd_state.Items.Add("3");
            dd_state.Items.Add("4");
            dd_prov.Items.Add("0");
            dd_prov.Items.Add("1");
        }

        private void RandomStn()
        {
            var random = new Random();
            var airline = Airlines[random.Next(Airlines.Count)];
            var digitCount = random.Next(3, 5);
            var randomDigits = random.Next((int)Math.Pow(10, digitCount - 1), (int)Math.Pow(10, digitCount)).ToString();
            callsign = $"{airline}{randomDigits}";
            provider = random.Next(1, 3);
        }

        private void StyleComponent()
        {
            foreach (Control ctl in Controls)
            {
                if (ctl is TextLabel)
                {
                    ctl.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
                    ctl.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
                }
            }

            dd_state.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            dd_state.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
            dd_state.FocusColor = Color.Cyan;

            dd_type.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            dd_type.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
            dd_type.FocusColor = Color.Cyan;

            dd_prov.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            dd_prov.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
            dd_prov.FocusColor = Color.Cyan;

            btn_add.ForeColor = Colours.GetColour(Colours.Identities.NonJurisdictionIQL);
            btn_add.BackColor = Colours.GetColour(Colours.Identities.CPDLCSendButton);

            btn_screate.ForeColor = Colours.GetColour(Colours.Identities.NonJurisdictionIQL);
            btn_screate.BackColor = Colours.GetColour(Colours.Identities.CPDLCSendButton);

            btn_rdmstn.ForeColor = Colours.GetColour(Colours.Identities.NonJurisdictionIQL);
            btn_rdmstn.BackColor = Colours.GetColour(Colours.Identities.CPDLCSendButton);

            btn_send.ForeColor = Colours.GetColour(Colours.Identities.NonJurisdictionIQL);
            btn_send.BackColor = Colours.GetColour(Colours.Identities.CPDLCSendButton);
        }

        private void DebugWindow_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            FormUrlEncodedContent req = HoppiesInterface.ConstructMessage(tbx_callsign.Text, "CPDLC", $"/data2/{tbx_msgid.Text}/{tbx_replyid.Text}/{tbx_response.Text}/{tbx_content2.Text}", true);
            _ = HoppiesInterface.SendMessage(req);
        }

        private void btn_w_Click(object sender, EventArgs e)
        {
            tbx_response.Text = "N";
            tbx_content2.Text = "WILCO";
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            tbx_response.Text = "N";
            tbx_content2.Text = "UNABLE";
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            tbx_response.Text = "N";
            tbx_content2.Text = "STANDBY";
        }

        private void btn_r_Click(object sender, EventArgs e)
        {
            tbx_response.Text = "N";
            tbx_content2.Text = "ROGER";
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            tbx_response.Text = "N";
            tbx_content2.Text = "AFFIRM";
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            tbx_response.Text = "N";
            tbx_content2.Text = "NEGATIVE";
        }
    }
}