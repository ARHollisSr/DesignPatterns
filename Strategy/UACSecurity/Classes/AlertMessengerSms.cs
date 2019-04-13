using System;

namespace UACSecurity.Classes
{
    public class AlertMessengerSms : IAlertMessenger
    {
        public void SendAlert()
        {
            Console.WriteLine("Sending an SMS Alert ...");
        }
    }
}