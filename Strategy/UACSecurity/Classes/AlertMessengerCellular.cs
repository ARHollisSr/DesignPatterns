using System;

namespace UACSecurity.Classes
{
    public class AlertMessengerCellular : IAlertMessenger
    {
        public void SendAlert()
        {
            Console.WriteLine("Sending a Cellular Alert message ...");
        }
    }
}