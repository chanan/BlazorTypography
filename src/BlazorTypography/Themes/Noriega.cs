using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class Noriega : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Noriega";
        public override string BaseFontSize { get; set; } = "18px";
        public override string BaseLineHeight { get; set; } = 1.61f.ToString();
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Lato", Styles = new List<string>{ "400", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Lato", "sans-serif" };
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Lato", "sans-serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override double? ScaleRatio { get; set; } = 1.618;
    }
}
