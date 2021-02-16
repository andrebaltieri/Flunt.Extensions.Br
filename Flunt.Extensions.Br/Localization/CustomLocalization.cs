using Flunt.Localization;

namespace Flunt.Extensions.Br.Localization
{
    public static class CustomLocalization
    {
        public static int StateStringLen = 2;
        public static int CountryStringLen = 2;

        public static string IsZipCodeErrorMessage(string key) => $"{key} deve ser um CEP";
        public static string IsStateErrorMessage(string key) => $"{key} deve ser um estado";
        public static string IsCountryErrorMessage(string key) => $"{key} deve ser um país";
        public static string IsCarPlateErrorMessage(string key) => $"{key} deve ser uma placa de veículo";
        public static string IsCpfErrorMessage(string key) => $"{key} deve ser um CPF";
        public static string IsCnpjErrorMessage(string key) => $"{key} deve ser um CNPJ";
        public static string IsCpfOrCnpjErrorMessage(string key) => $"{key} deve ser um CPF ou CNPJ";
        public static string IsElectoralCardErrorMessage(string key) => $"{key} deve ser um título de eleitor";
        public static string IsPhoneErrorMessage(string key) => $"{key} deve ser um número telefônico";

        public static void Apply()
        {
            FluntFormats.DateFormat = "dd/MM/yyyy";
            FluntFormats.DateTimeFormat = "dd/MM/yyyy HH:mm:ss";

            FluntErrorMessages.AndLocalizationErrorMessageLocalization = "e";
            FluntErrorMessages.OrLocalizationErrorMessageLocalization = "ou";
            FluntErrorMessages.IsFalseLocalizationErrorMessage = $"não deve ser verdadeiro";
            FluntErrorMessages.IsTrueLocalizationErrorMessage = $"não deve ser falso";
            FluntErrorMessages.IsEmptyLocalizationErrorMessage = $"deve ser vazio";
            FluntErrorMessages.IsNotEmptyLocalizationErrorMessage = $"não deve ser vazio";
            FluntErrorMessages.IsNotNullOrEmptyLocalizationErrorMessage = $"não deve ser nulo ou vazio";
            FluntErrorMessages.IsNotNullLocalizationErrorMessage = $"não deve ser nulo";
            FluntErrorMessages.IsNullLocalizationErrorMessage = $"deve ser nulo";
            FluntErrorMessages.IsNullOrEmptyLocalizationErrorMessage = $"deve ser nulo ou vazio";
            FluntErrorMessages.IsNullOrWhiteSpaceLocalizationErrorMessage = "deve ser nulo ou conter um espaço em branco";
            FluntErrorMessages.IsNotNullOrWhiteSpaceLocalizationErrorMessage = "não deve ser nulo ou ter um espaço em branco";
            FluntErrorMessages.IsGreaterThanLocalizationErrorMessage = $"deve ser maior que";
            FluntErrorMessages.IsGreaterOrEqualsThanLocalizationErrorMessage = $"deve ser maior ou igual a";
            FluntErrorMessages.IsLowerThanLocalizationErrorMessage = $"deve ser menor que";
            FluntErrorMessages.IsLowerOrEqualsThanLocalizationErrorMessage = $"deve ser menor ou igual a";
            FluntErrorMessages.IsBetweenLocalizationErrorMessage = $"deve estar entre";
            FluntErrorMessages.IsNotBetweenLocalizationErrorMessage = $"não deve estar entre";
            FluntErrorMessages.IsMinValueLocalizationErrorMessage = $"deve ter";
            FluntErrorMessages.IsNotMinValueLocalizationErrorMessage = $"não deve ter";
            FluntErrorMessages.IsMaxValueLocalizationErrorMessage = $"deve ter";
            FluntErrorMessages.IsNotMaxValueLocalizationErrorMessage = $"não deve ter";
            FluntErrorMessages.AreEqualsLocalizationErrorMessage = $"deve ser igual";
            FluntErrorMessages.AreNotEqualsLocalizationErrorMessage = $"não deve ser igual";
            FluntErrorMessages.ContainsLocalizationErrorMessage = $"deve conter o valor";
            FluntErrorMessages.NotContainsLocalizationErrorMessage = $"não deve conter o valor";
            FluntErrorMessages.IsCreditCardLocalizationErrorMessage = $"deve ser um número de cartão de crédito";
            FluntErrorMessages.MatchesLocalizationErrorMessage = $"não atende o padrão";
            FluntErrorMessages.NotMatchesLocalizationErrorMessage = $"não deve atender o padrão";
            FluntErrorMessages.IsEmailLocalizationErrorMessage = $"precisa ser um E-mail";
            FluntErrorMessages.IsEmailOrEmptyLocalizationErrorMessage = $"precisa ser um E-mail ou vazio";
            FluntErrorMessages.IsNotEmailLocalizationErrorMessage = $"não deve ser um E-mail";
            FluntErrorMessages.IsUrlLocalizationErrorMessage = "deve ser uma URL";
            FluntErrorMessages.IsNotUrlLocalizationErrorMessage = "não deve ser uma URL";


        }
    }
}
