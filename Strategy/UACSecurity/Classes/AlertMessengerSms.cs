using System;

namespace UACSecurity.Classes
{
    public class AlertMessengerSms : IAlertMessenger
    {
        public string AlertStatus { get; set; }

        public string SendAlert()
        {
            return AlertStatus = "Sending an SMS Alert message ...";
        }
    }
}