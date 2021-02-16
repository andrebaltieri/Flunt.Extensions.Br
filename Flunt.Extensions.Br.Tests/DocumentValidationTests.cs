using Flunt.Extensions.Br.Validations;
using Flunt.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flunt.Extensions.Br.Tests
{
    [TestClass]
    public class DocumentValidationTests
    {
        [TestCategory("Document Validation")]
        [TestMethod("Requires a string is a CPF")]
        public void IsCpf()
        {
            var contract = new Contract<string>()
                .Requires()

                // INVALID
                .IsCpf(null, "CPF 01")
                .IsCpf(null, "CPF 02", "Custom error message")

                // INVALID
                .IsCpf(string.Empty, "CPF 03")
                .IsCpf(string.Empty, "CPF 04", "Custom error message")

                // INVALID
                .IsCpf(" ", "CPF 05")
                .IsCpf(" ", "CPF 06", "Custom error message")

                // INVALID
                .IsCpf("ABCDE", "CPF 07")
                .IsCpf("ABCDE", "CPF 08", "Custom error message")

                // INVALID
                .IsCpf("1340", "CPF 09")
                .IsCpf("1340", "CPF 10", "Custom error message")

                // INVALID
                .IsCpf("587.461.400-18", "CPF 11")
                .IsCpf("587.461.400-18", "CPF 12", "Custom error message")

                // INVALID
                .IsCpf("774 451 480 78", "CPF 13")
                .IsCpf("774 451 480 78", "CPF 14", "Custom error message")

                // VALID
                .IsCpf("48042595034", "CPF 15")
                .IsCpf("48042595034", "CPF 16", "Custom error message")

                // INVALID
                .IsCpf("48042595035", "CPF 15")
                .IsCpf("48042595035", "CPF 16", "Custom error message")

                // INVALID
                .IsCpf("35245678901", "CPF 15")
                .IsCpf("35245678901", "CPF 16", "Custom error message");


            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 18);
        }

        [TestCategory("Document Validation")]
        [TestMethod("Requires a string is a CNPJ")]
        public void IsCnpj()
        {
            var contract = new Contract<string>()
                .Requires()

                // INVALID
                .IsCnpj(null, "CNPJ 01")
                .IsCnpj(null, "CNPJ 02", "Custom error message")

                // INVALID
                .IsCnpj(string.Empty, "CNPJ 03")
                .IsCnpj(string.Empty, "CNPJ 04", "Custom error message")

                // INVALID
                .IsCnpj(" ", "CNPJ 05")
                .IsCnpj(" ", "CNPJ 06", "Custom error message")

                // INVALID
                .IsCnpj("ABCDE", "CNPJ 07")
                .IsCnpj("ABCDE", "CNPJ 08", "Custom error message")

                // INVALID
                .IsCnpj("1340", "CNPJ 09")
                .IsCnpj("1340", "CNPJ 10", "Custom error message")

                // INVALID
                .IsCnpj("07.494.278/0001-01", "CNPJ 11")
                .IsCnpj("07.494.278/0001-01", "CNPJ 12", "Custom error message")

                // INVALID
                .IsCnpj("26 482 518 0001 00", "CNPJ 13")
                .IsCnpj("26 482 518 0001 00", "CNPJ 14", "Custom error message")

                // VALID
                .IsCnpj("84752242000121", "CNPJ 15")
                .IsCnpj("84752242000121", "CNPJ 16", "Custom error message")

                // INVALID
                .IsCnpj("57914838000102", "CNPJ 15")
                .IsCnpj("57914838000102", "CNPJ 16", "Custom error message")

                // INVALID
                .IsCnpj("57914838880102", "CNPJ 15")
                .IsCnpj("57914838880102", "CNPJ 16", "Custom error message");


            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 18);
        }

        [TestCategory("Document Validation")]
        [TestMethod("Requires a string is a CPF or CNPJ")]
        public void IsCpfOrCnpj()
        {
            var contract = new Contract<string>()
                .Requires()

                // INVALID
                .IsCpfOrCnpj(null, "TEST 01")
                .IsCpfOrCnpj(null, "TEST 02", "Custom error message")

                // INVALID
                .IsCpfOrCnpj(string.Empty, "TEST 03")
                .IsCpfOrCnpj(string.Empty, "TEST 04", "Custom error message")

                // INVALID
                .IsCpfOrCnpj(" ", "TEST 05")
                .IsCpfOrCnpj(" ", "TEST 06", "Custom error message")

                // INVALID
                .IsCpfOrCnpj("ABCDE", "TEST 07")
                .IsCpfOrCnpj("ABCDE", "TEST 08", "Custom error message")

                // INVALID
                .IsCpfOrCnpj("1340", "TEST 09")
                .IsCpfOrCnpj("1340", "TEST 10", "Custom error message")

                // INVALID
                .IsCpfOrCnpj("07.494.278/0001-01", "TEST 11")
                .IsCpfOrCnpj("07.494.278/0001-01", "TEST 12", "Custom error message")

                // INVALID
                .IsCpfOrCnpj("26 482 518 0001 00", "TEST 13")
                .IsCpfOrCnpj("26 482 518 0001 00", "TEST 14", "Custom error message")

                // VALID
                .IsCpfOrCnpj("84752242000121", "TEST 15")
                .IsCpfOrCnpj("84752242000121", "TEST 16", "Custom error message")

                // INVALID
                .IsCpfOrCnpj("57914838000102", "TEST 17")
                .IsCpfOrCnpj("57914838000102", "TEST 18", "Custom error message")

                // INVALID
                .IsCpfOrCnpj("57914838880102", "TEST 19")
                .IsCpfOrCnpj("57914838880102", "TEST 20", "Custom error message")

                // INVALID
                .IsCpfOrCnpj("587.461.400-18", "TEST 21")
                .IsCpfOrCnpj("587.461.400-18", "TEST 22", "Custom error message")

                // INVALID
                .IsCpfOrCnpj("774 451 480 78", "TEST 23")
                .IsCpfOrCnpj("774 451 480 78", "TEST 24", "Custom error message")

                // VALID
                .IsCpfOrCnpj("48042595034", "TEST 25")
                .IsCpfOrCnpj("48042595034", "TEST 26", "Custom error message")

                // INVALID
                .IsCpfOrCnpj("48042595035", "TEST 27")
                .IsCpfOrCnpj("48042595035", "TEST 28", "Custom error message")

                // INVALID
                .IsCpfOrCnpj("35245678901", "TEST 29")
                .IsCpfOrCnpj("35245678901", "TEST 30", "Custom error message");


            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 26);
        }

        [TestCategory("Document Validation")]
        [TestMethod("Requires a string is a Electoral Card")]
        public void IsElectoralCard()
        {
            var contract = new Contract<string>()
                .Requires()

                // INVALID
                .IsElectoralCard(null, "TEST 01")
                .IsElectoralCard(null, "TEST 02", "Custom error message")

                // INVALID
                .IsElectoralCard(string.Empty, "TEST 03")
                .IsElectoralCard(string.Empty, "TEST 04", "Custom error message")

                // INVALID
                .IsElectoralCard(" ", "TEST 05")
                .IsElectoralCard(" ", "TEST 06", "Custom error message")

                // INVALID
                .IsElectoralCard("ABCDE", "TEST 07")
                .IsElectoralCard("ABCDE", "CTESTPF 08", "Custom error message")

                // INVALID
                .IsElectoralCard("1340", "TEST 09")
                .IsElectoralCard("1340", "TEST 10", "Custom error message")

                // INVALID
                .IsElectoralCard("3583-201001-08", "TEST 11")
                .IsElectoralCard("3583-201001-08", "TEST 12", "Custom error message")

                // INVALID
                .IsElectoralCard("71 5561 4522 67", "TEST 13")
                .IsElectoralCard("71 5561 4522 67", "TEST 14", "Custom error message")

                // VALID
                .IsElectoralCard("312467822267", "TEST 15")
                .IsElectoralCard("312467822267", "TEST 16", "Custom error message")

                // INVALID
                .IsElectoralCard("885760042208", "TEST 15")
                .IsElectoralCard("885760042208", "TEST 16", "Custom error message")

                // INVALID
                .IsElectoralCard("144638422291", "TEST 15")
                .IsElectoralCard("144638422291", "TEST 16", "Custom error message");


            Assert.AreEqual(false, contract.IsValid);
            Assert.AreEqual(contract.Notifications.Count, 18);
        }
    }
}
