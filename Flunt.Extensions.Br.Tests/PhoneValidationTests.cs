using Flunt.Extensions.Br.Validations;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Extensions.Br.Tests
{
    [TestClass]
    public class PhoneValidationTests
    {
        [TestCategory("Phone Validation")]
        [TestMethod("Requires a string is a phone number")]
        public void IsPhoneNumber()
        {
            var contract = new Contract<string>()
                .Requires()

                // INVALID
                .IsPhoneNumber(null, "TEST 01")
                .IsPhoneNumber(null, "TEST 02", "Custom error message")

                // INVALID
                .IsPhoneNumber(string.Empty, "TEST 03")
                .IsPhoneNumber(string.Empty, "TEST 04", "Custom error message")

                // INVALID
                .IsPhoneNumber(" ", "TEST 05")
                .IsPhoneNumber(" ", "TEST 06", "Custom error message")

                // INVALID
                .IsPhoneNumber("ABCDE", "TEST 07")
                .IsPhoneNumber("ABCDE", "TEST 08", "Custom error message")

                // INVALID
                .IsPhoneNumber("1340", "TEST 09")
                .IsPhoneNumber("1340", "TEST 10", "Custom error message")

                // INVALID
                .IsPhoneNumber("(99) 9999-9999", "TEST 11")
                .IsPhoneNumber("(99) 9999-9999", "TEST 12", "Custom error message")

                // INVALID
                .IsPhoneNumber("+55 (99) 9999-9999", "TEST 13")
                .IsPhoneNumber("+55 (99) 9999-9999", "TEST 14", "Custom error message")

                // INVALID
                .IsPhoneNumber("(99) 99999-9999", "TEST 15")
                .IsPhoneNumber("(99) 99999-9999", "TEST 16", "Custom error message")

                // INVALID
                .IsPhoneNumber("+55 (99) 99999-9999", "TEST 17")
                .IsPhoneNumber("+55 (99) 99999-9999", "TEST 18", "Custom error message")

                // VALID
                .IsPhoneNumber("5599999999999", "TEST 19")
                .IsPhoneNumber("5599999999999", "TEST 20", "Custom error message")
                // VALID
                .IsPhoneNumber("559999999999", "TEST 21")
                .IsPhoneNumber("559999999999", "TEST 22", "Custom error message");


            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 18);
        }
    }
}
