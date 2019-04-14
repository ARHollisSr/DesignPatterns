using System;
using UACSecurity.Classes;
using Xunit;

namespace UACSecurityTests
{
    public class SecurityServicesTests
    {
        [Fact]
        public void SendAlert_NoMessengerSet_ThrowsInvalidArgException()
        {
            var securityService = new UACSecurity.Classes.SecurityServices();
            Assert.Throws<InvalidOperationException>(() => securityService.SendAlert());
        }

        [Fact]
        public void SetAlertMessenger_WhenParamIsNull_ThrowsArgNullException()
        {
            var securityService = new UACSecurity.Classes.SecurityServices();
            Assert.Throws<ArgumentNullException>(() => securityService.SetAlertMessenger(null));
        }

        [Fact]
        public void SendAlert_SetMessengerToCellular_ReturnsCellularObject()
        {
            var securityService = new UACSecurity.Classes.SecurityServices();
            securityService.SetAlertMessenger(new AlertMessengerCellular());
            Assert.Equal("Sending a Cellular Alert message ...", securityService.SendAlert());

        }

        [Fact]
        public void SendAlert_SetMessengerToSMS_ReturnsCellularObject()
        {
            var securityService = new UACSecurity.Classes.SecurityServices();
            securityService.SetAlertMessenger(new AlertMessengerSms());
            Assert.Equal("Sending an SMS Alert message ...", securityService.SendAlert());

        }

        [Fact]
        public void SendAlert_SetMessengerToWeb_ReturnsCellularObject()
        {
            var securityService = new UACSecurity.Classes.SecurityServices();
            securityService.SetAlertMessenger(new AlertMessengerWeb());
            Assert.Equal("Sending a Web Alert message ...", securityService.SendAlert());

        }
    }

}
