using System;

namespace UACSecurity.Classes
{
    public class AlertMessengerWeb : IAlertMessenger
    {
        public void SendAlert()
        {
            Console.WriteLine("Sending a Web Alert Message");
        }
    }
}