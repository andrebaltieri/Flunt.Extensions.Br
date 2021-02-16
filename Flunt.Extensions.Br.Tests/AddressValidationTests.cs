using Flunt.Extensions.Br.Validations;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Extensions.Br.Tests
{
    [TestClass]
    public class AddressValidationTests
    {
        [TestCategory("ZipCode Validation")]
        [TestMethod("Requires a string is a ZipCode")]
        public void IsZipCode()
        {
            var contract = new Contract<string>()
                .Requires()

                // INVALID
                .IsZipCode(null, "ZipCode")
                .IsZipCode(null, "ZipCode", "Custom error message")

                // INVALID
                .IsZipCode(string.Empty, "ZipCode")
                .IsZipCode(string.Empty, "ZipCode", "Custom error message")

                // INVALID
                .IsZipCode(" ", "ZipCode")
                .IsZipCode(" ", "ZipCode", "Custom error message")

                // INVALID
                .IsZipCode("ABCDE", "ZipCode")
                .IsZipCode("ABCDE", "ZipCode", "Custom error message")

                // INVALID
                .IsZipCode("1340", "ZipCode")
                .IsZipCode("1340", "ZipCode", "Custom error message")

                // VALID
                .IsZipCode("13400-000", "ZipCode")
                .IsZipCode("13400-000", "ZipCode", "Custom error message")

                // INVALID
                .IsZipCode("13400 000", "ZipCode")
                .IsZipCode("13400 000", "ZipCode", "Custom error message")

                // INVALID
                .IsZipCode("13400000", "ZipCode")
                .IsZipCode("13400000", "ZipCode", "Custom error message");


            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 14);
        }

        [TestCategory("ZipCode Validation")]
        [TestMethod("Requires a string is a state")]
        public void IsState()
        {
            var contract = new Contract<string>()
                .Requires()

                // VALID (Não valida nulo)
                .IsState(null, "State 01")
                .IsState(null, "State 02", "Custom error message")

                // INVALID
                .IsState(string.Empty, "State 03")
                .IsState(string.Empty, "State 04", "Custom error message")

                // INVALID
                .IsState(" ", "State 05")
                .IsState(" ", "State 06", "Custom error message")

                // INVALID
                .IsState("ABCDE", "State 07")
                .IsState("ABCDE", "State 08", "Custom error message")

                // INVALID
                .IsState("1340", "State 09")
                .IsState("1340", "State 10", "Custom error message")

                // VALID
                .IsState("SP", "State 11")
                .IsState("SP", "State 12", "Custom error message")

                // INVALID
                .IsState("São Paulo", "State 13")
                .IsState("São Paulo", "State 14", "Custom error message")

                // INVALID
                .IsState("BRA", "State 15")
                .IsState("BRA", "State 16", "Custom error message");


            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 12);
        }

        [TestCategory("ZipCode Validation")]
        [TestMethod("Requires a string is a country")]
        public void IsCountry()
        {
            var contract = new Contract<string>()
                .Requires()

                // VALID (Não valida nulo)
                .IsCountry(null, "Country 01")
                .IsCountry(null, "Country 02", "Custom error message")

                // INVALID
                .IsCountry(string.Empty, "Country 03")
                .IsCountry(string.Empty, "Country 04", "Custom error message")

                // INVALID
                .IsCountry(" ", "Country 05")
                .IsCountry(" ", "Country 06", "Custom error message")

                // INVALID
                .IsCountry("ABCDE", "Country 07")
                .IsCountry("ABCDE", "Country 08", "Custom error message")

                // INVALID
                .IsState("1340", "Country 09")
                .IsState("1340", "Country 10", "Custom error message")

                // INVALID
                .IsCountry("SP", "Country 11")
                .IsCountry("SP", "Country 12", "Custom error message")

                // INVALID
                .IsCountry("São Paulo", "Country 13")
                .IsCountry("São Paulo", "Country 14", "Custom error message")

                // VALID
                .IsCountry("BRA", "Country 15")
                .IsCountry("BRA", "Country 16", "Custom error message");


            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 12);
        }
    }
}
