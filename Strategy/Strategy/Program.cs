using System;
using UACSecurity.Classes;

namespace Strategy
{
    class Program
    {
        private static void Main(string[] args)
        {
            var securityServices = new UACSecurity.Classes.SecurityServices();
            securityServices.SetAlertMessenger(new AlertMessengerSms());
            Console.WriteLine(securityServices.SendAlert());
            securityServices.SetAlertMessenger(new AlertMessengerCellular());
            Console.WriteLine(securityServices.SendAlert());
        }
    }
}
