using Flunt.Extensions.Br.Validations;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Extensions.Br.Tests
{
    [TestClass]
    public class CarValidationTests
    {
        [TestCategory("Car Validation")]
        [TestMethod("Requires a string is a car plate")]
        public void IsCarPlate()
        {
            var contract = new Contract<string>()
                .Requires()

                // INVALID
                .IsCarPlate(null, "CarPlate 01")
                .IsCarPlate(null, "CarPlate 02", "Custom error message")

                // INVALID
                .IsCarPlate(string.Empty, "CarPlate 03")
                .IsCarPlate(string.Empty, "CarPlate 04", "Custom error message")

                // INVALID
                .IsCarPlate(" ", "CarPlate 05")
                .IsCarPlate(" ", "CarPlate 06", "Custom error message")

                // INVALID
                .IsCarPlate("ABCDE", "CarPlate 07")
                .IsCarPlate("ABCDE", "CarPlate 08", "Custom error message")

                // INVALID
                .IsCarPlate("1340", "CarPlate 09")
                .IsCarPlate("1340", "CarPlate 10", "Custom error message")

                // VALID
                .IsCarPlate("FCZ-1234", "CarPlate 11")
                .IsCarPlate("FCZ-1234", "CarPlate 12", "Custom error message")

                // INVALID
                .IsCarPlate("FCZ 1234", "CarPlate 13")
                .IsCarPlate("FCZ 1234", "CarPlate 14", "Custom error message")

                // VALID
                .IsCarPlate("FCZ1234", "CarPlate 15")
                .IsCarPlate("FCZ1234", "CarPlate 16", "Custom error message");


            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 12);
        }

        [TestCategory("Car Validation")]
        [TestMethod("Requires a string is a Mercosul car plate")]
        public void IsMercosulCarPlate()
        {
            var contract = new Contract<string>()
                .Requires()

                // INVALID
                .IsMercosulCarPlate(null, "CarPlate 01")
                .IsMercosulCarPlate(null, "CarPlate 02", "Custom error message")

                // INVALID
                .IsMercosulCarPlate(string.Empty, "CarPlate 03")
                .IsMercosulCarPlate(string.Empty, "CarPlate 04", "Custom error message")

                // INVALID
                .IsMercosulCarPlate(" ", "CarPlate 05")
                .IsMercosulCarPlate(" ", "CarPlate 06", "Custom error message")

                // INVALID
                .IsMercosulCarPlate("ABCDE", "CarPlate 07")
                .IsMercosulCarPlate("ABCDE", "CarPlate 08", "Custom error message")

                // INVALID
                .IsMercosulCarPlate("1340", "CarPlate 09")
                .IsMercosulCarPlate("1340", "CarPlate 10", "Custom error message")

                // VALID
                .IsMercosulCarPlate("LMA-0I11", "CarPlate 11")
                .IsMercosulCarPlate("LMA-0I11", "CarPlate 12", "Custom error message")

                // INVALID
                .IsMercosulCarPlate("FCZ 1234", "CarPlate 13")
                .IsMercosulCarPlate("FCZ 1234", "CarPlate 14", "Custom error message")

                // VALID
                .IsMercosulCarPlate("GAG1A11", "CarPlate 15")
                .IsMercosulCarPlate("GAG1A11", "CarPlate 16", "Custom error message");

            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 12);
        }
    }
}
