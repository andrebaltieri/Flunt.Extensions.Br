using Flunt.Extensions.Br.Localization;
using Flunt.Validations;

namespace Flunt.Extensions.Br.Validations
{
    public static class AddressValidationContract
    {
        /// <summary>
        /// Requer que a string seja um CEP
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Contract<T> IsZipCode<T>(this Contract<T> contract, string val, string key) =>
            IsZipCode(contract, val, key, CustomLocalization.IsZipCodeErrorMessage(key));

        /// <summary>
        /// Requer que a string seja um CEP
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Contract<T> IsZipCode<T>(this Contract<T> contract, string val, string key, string message) =>
            contract.Matches(val, CustomRegexPattern.ZipCodeRegexPattern, key, message);

        /// <summary>
        /// Requer que a string seja um estado
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Contract<T> IsState<T>(this Contract<T> contract, string val, string key) =>
            IsState(contract, val, key, CustomLocalization.IsStateErrorMessage(key));

        /// <summary>
        /// Requer que a string seja um estado
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Contract<T> IsState<T>(this Contract<T> contract, string val, string key, string message) =>
            contract.AreEquals(val, CustomLocalization.StateStringLen, key, message);

        /// <summary>
        /// Requer que a string seja um país
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Contract<T> IsCountry<T>(this Contract<T> contract, string val, string key) =>
            IsCountry(contract, val, key, CustomLocalization.IsCountryErrorMessage(key));

        /// <summary>
        /// Requer que a string seja um país
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Contract<T> IsCountry<T>(this Contract<T> contract, string val, string key, string message) =>
            contract.AreEquals(val, CustomLocalization.CountryStringLen, key, message);
    }
}
