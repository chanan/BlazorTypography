using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class Legible : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Legible";
        public override string BaseFontSize { get; set; } = "16px";
        public override string BaseLineHeight { get; set; } = "1.4";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Fira Sans", Styles = new List<string>{ "400", "500" } } },
            { new GoogleFont{ Name = "Merriweather", Styles = new List<string>{ "900" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Fira Sans", "sans-serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.86)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.93)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Merriweather", "serif" };
        public override string HeaderWeight { get; set; } = "900";
        public override string BoldWeight { get; set; } = "500";
        public override double? ScaleRatio { get; set; } = 2.45;
    }
}
