using System;

namespace UACSecurity.Classes
{
    public class AlertMessengerWeb : IAlertMessenger
    {
        public string AlertStatus { get; set; }

        public string SendAlert()
        {
           return AlertStatus = "Sending a Web Alert message ...";
        }
    }
}