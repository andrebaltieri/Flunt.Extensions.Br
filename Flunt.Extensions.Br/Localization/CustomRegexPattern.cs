namespace Flunt.Extensions.Br.Localization
{
    public static class CustomRegexPattern
    {
        public static string ZipCodeRegexPattern = @"[0-9]{5}-[0-9]{3}";
        public static string CarPlateRegexPattern = @"[A-Z]{3}\-?[0-9][A-Z0-9][0-9]{2}";
        public static string MercosulCarPlateRegexPattern = @"[A-Z]{3}\-?[0-9][A-Z][0-9]{2}";
        public static string PhoneRegexPattern = @"^(\d{12}|\d{13})$";
    }
}
