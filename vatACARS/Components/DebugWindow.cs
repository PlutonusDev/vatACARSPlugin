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
            Timer timer = new Timer();
            timer.Interval = 15000;
            timer.Tick += new EventHandler((sender, e) =>
            {
                tbx_station.AutoCompleteCustomSource.Clear();
                tbx_stationc.AutoCompleteCustomSource.Clear();
                tbx_callsign.AutoCompleteCustomSource.Clear();
                foreach (Station station in getAllStations())
                {
                    tbx_station.AutoCompleteCustomSource.Add(station.Callsign);
                    tbx_stationc.AutoCompleteCustomSource.Add(station.Callsign);
                    tbx_callsign.AutoCompleteCustomSource.Add(station.Callsign);
                }
            });

            timer.Start(); 
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
                if (tbx_type.Text.Equals("CPDLCMESSAGE", StringComparison.OrdinalIgnoreCase))
                {
                    addCPDLCMessage(new CPDLCMessage()
                    {
                        State = (MessageState)int.Parse(tbx_state.Text),
                        Station = tbx_station.Text,
                        Content = tbx_content.Text,
                        TimeReceived = DateTime.UtcNow
                    });
                }
                else if (tbx_type.Text.Equals("TELEXMESSAGE", StringComparison.OrdinalIgnoreCase))
                {
                    addTelexMessage(new TelexMessage()
                    {
                        State = (MessageState)int.Parse(tbx_state.Text),
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
                    Provider = int.Parse(tbx_prov.Text)
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
            tbx_type.AutoCompleteCustomSource.Add("TelexMessage");
            tbx_type.AutoCompleteCustomSource.Add("CPDLCMessage");
            tbx_state.AutoCompleteCustomSource.Add("0");
            tbx_state.AutoCompleteCustomSource.Add("1");
            tbx_state.AutoCompleteCustomSource.Add("2");
            tbx_state.AutoCompleteCustomSource.Add("3");
            tbx_state.AutoCompleteCustomSource.Add("4");
            tbx_prov.AutoCompleteCustomSource.Add("0");
            tbx_prov.AutoCompleteCustomSource.Add("1");
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
            lbl_messagecreate.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_messagecreate.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_content.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_content.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_callsign.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_callsign.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_state.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_state.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_type.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_type.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_stationc.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_stationc.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_stationcreate.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_stationcreate.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_prov.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_prov.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_netchecks.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_netchecks.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_rdmstn.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_rdmstn.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_msgid.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_msgid.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_call.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_call.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_pilotres.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_pilotres.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_code.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_code.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_reply.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_reply.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_content2.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            lbl_content2.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            lbl_intrc.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
            lbl_intrc.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);

            tbx_state.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            tbx_state.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            tbx_type.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            tbx_type.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

            tbx_prov.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
            tbx_prov.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);

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

        private void tbx_station_TextChanged(object sender, EventArgs e)
        {
            tbx_station.Text = tbx_station.Text.ToUpper();
            tbx_station.SelectionStart = tbx_station.Text.Length;
        }

        private void tbx_stationc_TextChanged(object sender, EventArgs e)
        {
            tbx_stationc.Text = tbx_stationc.Text.ToUpper();
            tbx_stationc.SelectionStart = tbx_stationc.Text.Length;
        }

        private void tbx_callsign_TextChanged(object sender, EventArgs e)
        {
            tbx_callsign.Text = tbx_callsign.Text.ToUpper();
            tbx_callsign.SelectionStart = tbx_callsign.Text.Length;
        }
    }
}