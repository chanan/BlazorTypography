using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class Stardust : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Stardust";
        public override string BaseFontSize { get; set; } = "20px";
        public override string BaseLineHeight { get; set; } = 1.6f.ToString();
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Merriweather", Styles = new List<string>{ "300", "300i", "400" } } },
            { new GoogleFont{ Name ="Josefin Sans", Styles = new List<string>{ "400", "600" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Merriweather", "serif" };
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Josefin Sans", "sans-serif" };
        public override string HeaderColor { get; set; } = "hsla(0, 0%, 0%, 0.9)";
        public override string BodyColor { get; set; } = "hsla(0, 0%, 0%, 0.8)";
        public override string BodyWeight { get; set; } = "300";
        public override string HeaderWeight { get; set; } = "600";
        public override string BoldWeight { get; set; } = "400";
        public override double? ScaleRatio { get; set; } = 1.6;
    }
}
