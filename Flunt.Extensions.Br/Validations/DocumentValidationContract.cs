using System.Linq;
using Flunt.Extensions.Br.Localization;
using Flunt.Validations;

namespace Flunt.Extensions.Br.Validations
{
    public static class DocumentValidationContract
    {
        /// <summary>
        /// Requer que uma string seja um CPF
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Contract<T> IsCpf<T>(this Contract<T> contract, string val, string key) =>
            IsCpf(contract, val, key, CustomLocalization.IsCpfErrorMessage(key));

        /// <summary>
        /// Requer que uma string seja um CPF
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Contract<T> IsCpf<T>(this Contract<T> contract, string val, string key, string message)
        {
            var invalidDocuments = new[]
            {
                "00000000000", "11111111111", "22222222222",
                "33333333333", "44444444444", "55555555555",
                "66666666666", "77777777777", "88888888888", "99999999999"
            };

            if (invalidDocuments.Contains(val))
            {
                contract.AddNotification(key, message);
                return contract;
            }

            if (val?.Length != 11)
            {
                contract.AddNotification(key, message);
                return contract;
            }

            var firstMultiplier = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var secondMultiplier = new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            if (!long.TryParse(val, out var parsed))
            {
                contract.AddNotification(key, message);
                return contract;
            }

            var temp = val.Substring(0, 9);
            var sum = 0;

            for (var i = 0; i < 9; i++)
                sum += int.Parse(temp[i].ToString()) * firstMultiplier[i];

            var rest = sum % 11;
            rest = rest < 2 ? 0 : 11 - rest;

            var digit = rest.ToString();
            temp += digit;
            sum = 0;

            for (var i = 0; i < 10; i++)
                sum += int.Parse(temp[i].ToString()) * secondMultiplier[i];

            rest = sum % 11;
            rest = rest < 2 ? 0 : 11 - rest;
            digit += rest;

            if (val.EndsWith(digit))
                return contract;

            contract.AddNotification(key, message);
            return contract;

        }

        /// <summary>
        /// Requer que uma string seja um CNPJ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Contract<T> IsCnpj<T>(this Contract<T> contract, string val, string key) =>
            IsCnpj(contract, val, key, CustomLocalization.IsCnpjErrorMessage(key));

        /// <summary>
        /// Requer que uma string seja um CNPJ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Contract<T> IsCnpj<T>(this Contract<T> contract, string val, string key, string message)
        {
            var invalidDocuments = new[]
            {
                "00000000000000", "11111111111111", "22222222222222", "33333333333333",
                "44444444444444", "55555555555555", "66666666666666", "77777777777777",
                "88888888888888", "99999999999999",
            };

            var firstMultiplier = new[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            var secondMultiplier = new[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            if (val?.Length != 14 || !long.TryParse(val, out var parsed))
            {
                contract.AddNotification(key, message);
                return contract;
            }

            if (invalidDocuments.Contains(val))
            {
                contract.AddNotification(key, message);
                return contract;
            }

            var temp = val.Substring(0, 12);
            var sum = 0;

            for (var i = 0; i < 12; i++)
                sum += int.Parse(temp[i].ToString()) * firstMultiplier[i];

            var rest = (sum % 11);
            rest = rest < 2 ? 0 : 11 - rest;

            var digit = rest.ToString();
            temp += digit;
            sum = 0;

            for (var i = 0; i < 13; i++)
                sum += int.Parse(temp[i].ToString()) * secondMultiplier[i];

            rest = (sum % 11);
            rest = rest < 2 ? 0 : 11 - rest;
            digit += rest;

            if (val.EndsWith(digit))
                return contract;

            contract.AddNotification(key, message);
            return contract;
        }

        /// <summary>
        /// Requer que uma string seja um CPF ou CNPJ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Contract<T> IsCpfOrCnpj<T>(this Contract<T> contract, string val, string key) =>
            IsCpfOrCnpj(contract, val, key, CustomLocalization.IsCpfOrCnpjErrorMessage(key));

        /// <summary>
        /// Requer que uma string seja um CPF ou CNPJ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Contract<T> IsCpfOrCnpj<T>(this Contract<T> contract, string val, string key, string message)
        {
            switch (val?.Length)
            {
                case 11:
                    return IsCpf(contract, val, key, message);
                case 14:
                    return IsCnpj(contract, val, key, message);
                default:
                    contract.AddNotification(key, message);
                    return contract;
            }
        }

        /// <summary>
        /// Requer que a string seja um título de eleitor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Contract<T> IsElectoralCard<T>(this Contract<T> contract, string val, string key) =>
            IsElectoralCard(contract, val, key, CustomLocalization.IsElectoralCardErrorMessage(key));

        /// <summary>
        /// Requer que a string seja um título de eleitor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Contract<T> IsElectoralCard<T>(this Contract<T> contract, string val, string key, string message)
        {
            var invalidDocuments = new[]
            {
                "000000000000",
                "111111111111",
                "222222222222",
                "333333333333",
                "444444444444",
                "555555555555",
                "666666666666",
                "777777777777",
                "888888888888",
                "999999999999",
            };

            if (invalidDocuments.Contains(val))
            {
                contract.AddNotification(key, message);
                return contract;
            }

            if (val?.Length != 12)
            {
                contract.AddNotification(key, message);
                return contract;
            }

            int d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, DV1, DV2, UltDig;

            UltDig = val.Length;

            d1 = int.Parse(val.Substring(UltDig - 12, 1));
            d2 = int.Parse(val.Substring(UltDig - 11, 1));
            d3 = int.Parse(val.Substring(UltDig - 10, 1));
            d4 = int.Parse(val.Substring(UltDig - 9, 1));
            d5 = int.Parse(val.Substring(UltDig - 8, 1));
            d6 = int.Parse(val.Substring(UltDig - 7, 1));
            d7 = int.Parse(val.Substring(UltDig - 6, 1));
            d8 = int.Parse(val.Substring(UltDig - 5, 1));
            d9 = int.Parse(val.Substring(UltDig - 4, 1));
            d10 = int.Parse(val.Substring(UltDig - 3, 1));
            d11 = int.Parse(val.Substring(UltDig - 2, 1));
            d12 = int.Parse(val.Substring(UltDig - 1, 1));

            DV1 = ((d1 * 2) + ((d2 * 3) + ((d3 * 4) + ((d4 * 5) + ((d5 * 6) + ((d6 * 7) + ((d7 * 8) + (d8 * 9))))))));
            DV1 = (DV1 % 11);

            if (DV1 == 10)
                DV1 = 0;

            DV2 = ((d9 * 7) + ((d10 * 8) + (DV1 * 9)));
            DV2 = (DV2 % 11);

            if (DV2 == 10)
                DV2 = 0;

            if ((d11 == DV1) && (d12 == DV2))
            {
                if ((d9 + d10) > 0 && (d9 + d10) < 29)
                {
                    return contract;
                }

                contract.AddNotification(key, message);
                return contract;
            }

            contract.AddNotification(key, message);
            return contract;
        }
    }
}
