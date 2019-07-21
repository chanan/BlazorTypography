using System.Text.RegularExpressions;

namespace BlazorTypography.Internal
{
    internal class Util
    {
        public static float UnitLess(string value)
        {
            return float.Parse(Regex.Replace(value, "[^0-9.]", ""));
        }

        public static string Unit(string value)
        {
            MatchCollection matches = new Regex(@"([ 0-9]*[0-9]+(?:\.|,)?[0-9]*)[ ]*(.*)").Matches(value);
            return matches.Count > 0 ? matches[0].Groups[2].Value.ToLower() : string.Empty;
        }
    }
}
