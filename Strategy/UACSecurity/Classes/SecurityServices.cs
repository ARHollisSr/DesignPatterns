using System;

namespace UACSecurity.Classes
{
    public class SecurityServices
    {
        private IAlertMessenger _alertMessenger;

        public void SetAlertMessenger(IAlertMessenger iam)
        {
            _alertMessenger = iam ?? throw new ArgumentNullException(nameof(iam));
        }

        public void SendAlert()
        {
            if (_alertMessenger == null)
                throw new InvalidOperationException("Must set alert messenger type first");
            _alertMessenger.SendAlert();
        }

        public void FirmwareUpdate()
        {
            Console.WriteLine("Updating UAC Firmware...");
        }

        public void Reset()
        {
            Console.WriteLine("Resetting security system...");
        }
    }
}