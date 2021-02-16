using Flunt.Extensions.Br.Localization;
using Flunt.Validations;

namespace Flunt.Extensions.Br.Validations
{
    public static class PhoneValidationContract
    {
        /// <summary>
        /// Requer que uma string seja um número telefônic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Contract<T> IsPhoneNumber<T>(this Contract<T> contract, string val, string key) =>
            IsPhoneNumber(contract, val, key, CustomLocalization.IsPhoneErrorMessage(key));

        /// <summary>
        /// Requer que uma string seja um número telefônic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Contract<T> IsPhoneNumber<T>(this Contract<T> contract, string val, string key, string message) =>
            contract.Matches(val, CustomRegexPattern.PhoneRegexPattern, key, message);
    }
}
