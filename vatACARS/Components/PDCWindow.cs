﻿using System;
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
    public partial class PDCWindow : BaseForm
    {
        private static Logger logger = new Logger("PDCWindow");
        private ErrorHandler errorHandler = ErrorHandler.GetInstance();
        private FDR networkPilotFDR;
        private Dictionary<string, string> PDCElements = new Dictionary<string, string>();
        private IMessageData selectedMsg;

        public PDCWindow()
        {
            InitializeComponent();
            selectedMsg = DispatchWindow.SelectedMessage;

            StyleComponent();
            InitPlaceholders();
            LoadDepFreq();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            List<string> values = PDCElements.Values.ToList();
            values[6] = $"DEP FREQ: {dd_freq.Text}";
            values[8] = $"ONLY READBACK SID, SQUAWK CODE, AND BAY NO. ON: {dd_freq2.Text}";

            string encodedMessage = $"{string.Join("\n", values)}";
            FormUrlEncodedContent req = HoppiesInterface.ConstructMessage(selectedMsg.Station, "CPDLC", $"/data2/{SentMessages}//WU/{encodedMessage}");
            _ = HoppiesInterface.SendMessage(req);

            addSentCPDLCMessage(new SentCPDLCMessage()
            {
                Station = selectedMsg.Station,
                MessageId = (SentMessages - 1),
                ReplyMessageId = SentMessages
            });

            addCPDLCMessage(new CPDLCMessage()
            {
                State = MessageState.Uplink,
                Station = selectedMsg.Station,
                Content = encodedMessage.Replace("@", "").Replace("\n", ", "),
                TimeReceived = DateTime.UtcNow,
                MessageId = SentMessages,
                ReplyMessageId = -1
            });
            networkPilotFDR.PDCSent = true;
            selectedMsg.setMessageState(MessageState.Finished);
            Close();
        }

        private string CutStringAndAppendT(string input, int maxLength = 36)
        {
            if (input.Length <= maxLength) return input;

            string[] segments = input.Split(' ');
            string result = string.Empty;
            foreach (string segment in segments)
            {
                if ((result + " " + segment).Trim().Length > maxLength) break;
                if (result.Length > 0) result += " ";
                result += segment;
            }
            result = result.Trim();
            if (result.Length <= maxLength) result += " T";

            result = result.Replace("\\", " ");

            return result;
        }

        private void dd_freq_SelectedIndexChanged(object sender, EventArgs e)
        {
            dd_freq.Text = Regex.Replace(dd_freq.Text, @"[^\d\.]", string.Empty);
        }

        private void dd_freq2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dd_freq2.Text = Regex.Replace(dd_freq2.Text, @"[^\d\.]", string.Empty);
        }

        private void InitPlaceholders()
        {
            networkPilotFDR = GetFDRs.FirstOrDefault(f => f.Callsign == selectedMsg.Station);
            if (networkPilotFDR == null || !GetFDRs.Contains(networkPilotFDR))
            {
                errorHandler.AddError("Network pilot FDR not found or not in GetFDRs collection.");
                Close();
                return;
            }

            if (networkPilotFDR.PDCCapable == false)
            {
                errorHandler.AddError($"PDC for '{selectedMsg.Station}' failed to initialise. The pilot is not PDC capable.");
                FormUrlEncodedContent req = HoppiesInterface.ConstructMessage(selectedMsg.Station, "telex", $"UNABLE");
                _ = HoppiesInterface.SendMessage(req);
                selectedMsg.setMessageState(MessageState.Finished);
                Close();
                return;
            }

            var requiredProperties = new Dictionary<string, Func<object, bool>>
            {
                { "Callsign", value => !string.IsNullOrEmpty(value.ToString()) },
                { "AircraftType", value => !string.IsNullOrEmpty(value.ToString()) },
                { "DesAirport", value => !string.IsNullOrEmpty(value.ToString()) },
                { "DepAirport", value => !string.IsNullOrEmpty(value.ToString()) },
                { "Route", value => !string.IsNullOrEmpty(value.ToString()) },
                { "CFLString", value => !string.IsNullOrEmpty(value.ToString()) },
                { "SID", value => value != null && !string.IsNullOrEmpty(((dynamic)value).Name) },
                { "DepartureRunway", value => value != null && !string.IsNullOrEmpty(((dynamic)value).Name) },
                { "AssignedSSRCode", value => (int)value != -1 },
                { "ETD", value => (DateTime)value != DateTime.MinValue },
            };

            var invalidProperties = new List<string>();

            foreach (var property in requiredProperties)
            {
                var propInfo = networkPilotFDR.GetType().GetProperty(property.Key);
                if (propInfo == null)
                {
                    invalidProperties.Add(property.Key);
                }
                else
                {
                    var value = propInfo.GetValue(networkPilotFDR);
                    if (value == null || !property.Value(value))
                    {
                        invalidProperties.Add(property.Key);
                    }
                }
            }

            if (invalidProperties.Count > 0)
            {
                var errorMessage = $"PDC for '{selectedMsg.Station}' failed to initialise. The following properties are invalid or not set: {string.Join(", ", invalidProperties)}";
                errorHandler.AddError(errorMessage);
                Close();
                return;
            }

            Text = $"PDC {networkPilotFDR.Callsign}";

            string route = networkPilotFDR.Route;
            string[] routeSegments = route.Split(' ');
            if (routeSegments[0].Contains(networkPilotFDR.DepAirport) || routeSegments[0].Contains(networkPilotFDR.SID.Name)) route = route.Substring(route.IndexOf(' ') + 1);

            PDCElements = new Dictionary<string, string>()
            {
                { "PDC", $"PDC {DateTime.UtcNow.ToString("ddHHmm")}" },
                { "MetaInfo", $"{networkPilotFDR.Callsign} {networkPilotFDR.AircraftType} {networkPilotFDR.DepAirport} {networkPilotFDR.ETD.ToString("HHmm")}" },
                { "DestRoute", $"CLRD TO {networkPilotFDR.DesAirport} VIA" },
                { "SIDRwy", $"{networkPilotFDR.SID.Name} DEP RWY {networkPilotFDR.DepartureRunway.Name}" },
                { "Route", $"ROUTE: {CutStringAndAppendT(route)}" },
                { "InitAlt", $"CLIMB VIA SID TO: {(networkPilotFDR.CFLString != null && int.Parse(networkPilotFDR.CFLString) < 110 ? "A" : "FL")}{networkPilotFDR.CFLString.PadLeft(3, '0')}" },
                { "DepFREQ", $"DEP FREQ: {dd_freq.Text}" },
                { "SqwkDeps", $"SQUAWK {Convert.ToString(networkPilotFDR.AssignedSSRCode, 8).PadLeft(4, '0')}" },
                { "ReadBack", $"ONLY READBACK SID, SQUAWK CODE, AND BAY NO. ON: {dd_freq2.Text}" }
            };

            lbl_pdcHeader.Text = PDCElements["PDC"];
            lbl_metaInfo.Text = PDCElements["MetaInfo"];
            lbl_destRoute.Text = PDCElements["DestRoute"];
            lbl_sidRwy.Text = PDCElements["SIDRwy"];
            lbl_route.Text = PDCElements["Route"];
            lbl_initAlt.Text = PDCElements["InitAlt"];
            lbl_sqwkDeps.Text = PDCElements["SqwkDeps"];
        }

        private void LoadDepFreq()
        {
            dd_freq.Items.Add("UNICOM 122.800");
            dd_freq2.Items.Add("UNICOM 122.800");
            List<string> freqs = new List<string>();

            foreach (VSCSFrequency vscsFrequency in (IEnumerable<VSCSFrequency>)Audio.VSCSFrequencies)
            {
                if (vscsFrequency.Transmit)
                {
                    try
                    {
                        freqs.Add(vscsFrequency.Name + " " + Conversions.FrequencyToString(vscsFrequency.Frequency));
                    }
                    catch
                    {
                    }
                }
            }

            foreach (NetworkATC networkAtc in Network.GetOnlineATCs.Where<NetworkATC>((Func<NetworkATC, bool>)(a => a.IsRealATC && a.Frequencies != null)))
            {
                foreach (int frequency in networkAtc.Frequencies)
                {
                    if (frequency != 99998)
                    {
                        freqs.Add(networkAtc.Callsign + " " + Conversions.FSDFrequencyToString(frequency));
                    }
                    else
                        break;
                }
            }

            foreach (string freq in freqs)
            {
                dd_freq.Items.Add(freq);
                dd_freq2.Items.Add(freq);
            }
        }

        private void StyleComponent()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl is TextLabel)
                    {
                        ctl.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
                        ctl.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
                    }
                }
                lbl_pdcHeader.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
                lbl_pdcHeader.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
                lbl_metaInfo.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
                lbl_metaInfo.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);

                dd_freq.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
                dd_freq.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
                dd_freq.FocusColor = Color.Cyan;

                dd_freq2.ForeColor = Colours.GetColour(Colours.Identities.InteractiveText);
                dd_freq2.BackColor = Colours.GetColour(Colours.Identities.WindowBackground);
                dd_freq2.FocusColor = Color.Cyan;

                btn_send.BackColor = Colours.GetColour(Colours.Identities.CPDLCSendButton);
                btn_send.ForeColor = Colours.GetColour(Colours.Identities.NonJurisdictionIQL);
            }
            catch (Exception ex)
            {
                errorHandler.AddError(ex.ToString());
            }
        }
    }
}