using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class USWebDesignStandards : BaseTypographyOptions
    {
        public override string Title { get; set; } = "US Web Design Standards";
        public override string BaseFontSize { get; set; } = "17px";
        public override string BaseLineHeight { get; set; } = 1.53f.ToString();
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Merriweather", Styles = new List<string>{ "700" } } },
            { new GoogleFont{ Name = "Source Sans Pro", Styles = new List<string>{ "400", "400i", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Source Sans Pro", "sans-serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Merriweather", "serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.Add("h1", $"{vr.Scale(5 / 5f)}");
                styles.Add("h2", $"{vr.Scale(3 / 5f)}");
                styles.Add("h3", $"{vr.Scale(1 / 5f)}");
                styles.Add("h4", $"{vr.Scale(0 / 5f)}");
                styles.Add("h5", $"{vr.Scale(-1 / 5f)}");
                styles.Add("h6", $@"
                    {vr.Scale(-2 / 9f)}
                    font-family: ""Source Sans Pro"", ""sans-serif""; 
                    font-weight: {options.BodyWeight};
                    text-transform: uppercase;
                ");
                styles.Add("a", $@"
                    color: #0071bc;
                ");
                styles.Add("a:visited", $@"
                    color: #4c2c92;
                ");
                styles.Add("blockquote", $@"
                    {vr.Scale(1 / 4f)}
                    border-left: {vr.Rhythm(1 / 6f)} solid;
                    border-color: {vr.Gray(93)};
                    padding-top: {vr.Rhythm(1 / 3f)};
                    padding-bottom: {vr.Rhythm(1 / 3f)};
                    padding-left: {vr.Rhythm(2 / 3f)};
                    padding-right: {vr.Rhythm(2 / 3f)};
                ");
                styles.Add("blockquote > :last-child", "margin-bottom: 0;");
                styles.Add("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {vr.Gray(54, "204")};
                    font-weight: {options.BodyWeight};
                    font-style: normal;
                ");
            });
    }
}
