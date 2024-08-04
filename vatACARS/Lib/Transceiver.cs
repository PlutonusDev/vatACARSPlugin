﻿/*
 * Transceiver.cs
 * Handles communication between vatACARS and ACARS servers.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vatACARS.Components;
using vatACARS.Util;
using static vatsys.FDP2;

namespace vatACARS.Helpers
{
    public static class Transceiver
    {
        public static bool connected = false;
        public static int SentMessages = 1;
        private static List<string> ClosingMessages = new List<string>() { "WILCO", "UNABLE", "ROGER", "STANDBY", "AFFIRM", "NEGATIVE" };
        private static List<CPDLCMessage> CPDLCMessages = new List<CPDLCMessage>();
        private static Logger logger = new Logger("Transceiver");
        private static List<SentCPDLCMessage> SentCPDLCMessages = new List<SentCPDLCMessage>();
        private static List<Station> Stations = new List<Station>();
        private static List<TelexMessage> TelexMessages = new List<TelexMessage>();

        public static event EventHandler<CPDLCMessage> CPDLCMessageReceived;

        public static event EventHandler<IMessageData> MessageUpdated;

        public static event EventHandler<Station> StationAdded;

        public static event EventHandler<Station> StationRemoved;

        public static event EventHandler<TelexMessage> TelexMessageReceived;

        public interface IMessageData
        {
            string Content { get; set; }
            MessageState State { get; set; }
            string Station { get; set; }
            DateTime TimeReceived { get; set; }
        }

        public static void addCPDLCMessage(CPDLCMessage message)
        {
            try
            {
                AudioInterface.playSound("incomingMessage");

                if (message.Content == "LOGOFF") getAllStations().FirstOrDefault(station => station.Callsign == message.Station).removeStation();

                if (message.ReplyMessageId != -1 && ClosingMessages.Contains(message.Content))
                {
                    SentCPDLCMessage sentCPDLCMessage = SentCPDLCMessages.FirstOrDefault(msg => msg.MessageId == message.ReplyMessageId);
                    CPDLCMessage originalMessage = null;
                    if (sentCPDLCMessage != null) originalMessage = CPDLCMessages.FirstOrDefault(msg => msg.MessageId == sentCPDLCMessage.ReplyMessageId);

                    if (originalMessage == null) CPDLCMessages.Add(message);
                    else
                    {
                        FDR fdr = GetFDRs.FirstOrDefault(f => f.Callsign == message.Station);
                        if (fdr != null && originalMessage.Content.Contains("PDC")) fdr.PDCAcknowledged = true;
                        SentCPDLCMessages.Remove(sentCPDLCMessage);
                        originalMessage.Response = message.Content;
                        if (message.Content != "STANDBY") originalMessage.setMessageState(MessageState.Finished);
                    }
                }
                else
                {
                    CPDLCMessages.Add(message);
                    Station station = Stations.FirstOrDefault(s => s.Callsign == message.Station);
                    if (station != null) // cpdlc may not have come from connected station (PDC's)
                    {
                        station.History.Add(message);
                    }
                    else
                    {
                        logger.Log($"Station {message.Station} is not connected.");
                    }
                    if (message.ResponseType == "N") message.setMessageState(MessageState.DownlinkResponseNotRequired);
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Oops: {ex.ToString()}");
            }

            CPDLCMessageReceived?.Invoke(null, message);
        }

        public static void addSentCPDLCMessage(SentCPDLCMessage message)
        {
            SentCPDLCMessages.Add(message);
        }

        public static void addStation(Station station)
        {
            if (!Stations.Any(s => s.Callsign == station.Callsign))
            {
                Stations.Add(station);
                StationAdded?.Invoke(null, station);
            }
            else
            {
                ErrorHandler.GetInstance().AddError($"Station Already Exists: {station.Callsign}");
            }
        }

        public static void addTelexMessage(TelexMessage message)
        {
            AudioInterface.playSound("incomingMessage");
            TelexMessages.Add(message);
            Station station = Stations.FirstOrDefault(s => s.Callsign == message.Station);
            if (station != null) // telex may not have come from connected station.
            {
                station.History.Add(message);
            }
            else
            {
                logger.Log($"Station {message.Station} is not connected.");
            }
            TelexMessageReceived?.Invoke(null, message);
        }

        public static CPDLCMessage[] getAllCPDLCMessages()
        {
            return CPDLCMessages.ToArray();
        }

        public static Station[] getAllStations()
        {
            return Stations.ToArray();
        }

        public static TelexMessage[] getAllTelexMessages()
        {
            return TelexMessages.ToArray();
        }

        public static void removeStation(this Station station)
        {
            Stations.Remove(station);
            StationRemoved?.Invoke(null, station);
        }

        public static async void setMessageState(this IMessageData message, MessageState state)
        {
            message.State = state;

            if (state == MessageState.Finished)
            {
                await Task.Delay(TimeSpan.FromSeconds(Properties.Settings.Default.finishedMessageTimeout));
                message.removeMessage();
            }

            MessageUpdated.Invoke(null, message);
        }

        private static void removeMessage(this IMessageData message)
        {
            if (message is CPDLCMessage) CPDLCMessages.Remove((CPDLCMessage)message);
            if (message is TelexMessage) TelexMessages.Remove((TelexMessage)message);
        }

        public static class ClientInformation
        {
            public static string Callsign = "";
            public static string LogonCode = ""; // Hoppies logon code
        }

        public class CPDLCMessage : IMessageData
        {
            /* State:
             * 0 = Downlink
             * 1 = Stby/Defer
             * 2 = Uplink
             * 3 = DownlinkRespNotReqd
             * 4 = Finished
             * 5 = ADS-C
             */
            public int MessageId;
            public int ReplyMessageId;
            public string ResponseType;
            public string Content { get; set; }
            public List<CPDLCMessage> History { get; set; } = new List<CPDLCMessage>();
            public string Response { get; set; } = "";
            public MessageState State { get; set; }
            public string Station { get; set; }
            public List<ResponseItem> SuspendedResponses { get; set; } = new List<ResponseItem>();
            public DateTime TimeReceived { get; set; }
        }

        public class SentCPDLCMessage
        {
            public int MessageId;
            public int ReplyMessageId;
            public string Station;
        }

        public class Station
        {
            /* Provider:
             * 0 = Hoppies
             * 1 = vatACARS
             */
            public string Callsign;
            public int Provider;
            public List<IMessageData> History { get; set; } = new List<IMessageData>();
        }

        public class TelexMessage : IMessageData
        {
            /* State:
             * 0 = Downlink
             * 1 = Stby/Defer
             * 2 = Uplink
             * 3 = DownlinkRespNotReqd
             * 4 = Finished
             * 5 = ADS-C
             */
            public string Content { get; set; }
            public MessageState State { get; set; }
            public string Station { get; set; }
            public List<ResponseItem> SuspendedResponses { get; set; } = new List<ResponseItem>();
            public DateTime TimeReceived { get; set; }
        }
    }
}