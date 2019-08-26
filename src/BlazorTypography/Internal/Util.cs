using System.Text.RegularExpressions;

namespace BlazorTypography.Internal
{
    internal class Util
    {
        public static float UnitLess(string value)
        {
            string str = Regex.Replace(value, "[^0-9.,-]", "");
            return float.Parse(str);
        }

        public static string Unit(string value)
        {
            MatchCollection matches = new Regex(@"([ 0-9]*[0-9]+(?:\.|,)?[0-9]*)[ ]*(.*)").Matches(value);
            return matches.Count > 0 ? matches[0].Groups[2].Value.ToLower() : string.Empty;
        }
    }
}
