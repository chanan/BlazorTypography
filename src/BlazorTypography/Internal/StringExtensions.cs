namespace BlazorTypography.Internal
{
    internal static class StringExtensions
    {
        public static string FixDecimal(this string input)
        {
            return input.Replace(',', '.');
        }
    }
}