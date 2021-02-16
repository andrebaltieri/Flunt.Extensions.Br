using Flunt.Extensions.Br.Localization;
using Flunt.Validations;

namespace Flunt.Extensions.Br.Validations
{
    public static class CarValidationContract
    {
        /// <summary>
        /// Requer que uma string seja uma placa de veículo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Contract<T> IsCarPlate<T>(this Contract<T> contract, string val, string key) =>
            IsCarPlate(contract, val, key, CustomLocalization.IsCarPlateErrorMessage(key));

        /// <summary>
        /// Requer que uma string seja uma placa de veículo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Contract<T> IsCarPlate<T>(this Contract<T> contract, string val, string key, string message) =>
            contract.Matches(val, CustomRegexPattern.CarPlateRegexPattern, key, message);

        /// <summary>
        /// Requer que uma string seja uma placa de veículo do Mercosul
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Contract<T> IsMercosulCarPlate<T>(this Contract<T> contract, string val, string key) =>
            IsMercosulCarPlate(contract, val, key, CustomLocalization.IsCarPlateErrorMessage(key));

        /// <summary>
        /// Requer que uma string seja uma placa de veículo do Mercosul
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contract"></param>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Contract<T> IsMercosulCarPlate<T>(this Contract<T> contract, string val, string key, string message) =>
            contract.Matches(val, CustomRegexPattern.MercosulCarPlateRegexPattern, key, message);
    }
}
