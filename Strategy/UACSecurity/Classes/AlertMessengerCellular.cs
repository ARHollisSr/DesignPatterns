using System;

namespace UACSecurity.Classes
{
    public class AlertMessengerCellular : IAlertMessenger
    {
        public string AlertStatus { get; set; }

        public string SendAlert()
        {
            return AlertStatus = "Sending a Cellular Alert message ...";
        }
    }
}