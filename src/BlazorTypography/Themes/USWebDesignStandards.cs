using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class USWebDesignStandards : BaseTypographyOptions
    {
        public override string Title { get; set; } = "US Web Design Standards";
        public override string BaseFontSize { get; set; } = "17px";
        public override string BaseLineHeight { get; set; } = "1.53";
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
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((vr, options) =>
            {
                List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("h1", $"{vr.Scale(5 / 5f)}"),
                    new KeyValuePair<string, string>("h2", $"{vr.Scale(3 / 5f)}"),
                    new KeyValuePair<string, string>("h3", $"{vr.Scale(1 / 5f)}"),
                    new KeyValuePair<string, string>("h4", $"{vr.Scale(0 / 5f)}"),
                    new KeyValuePair<string, string>("h5", $"{vr.Scale(-1 / 5f)}"),
                    new KeyValuePair<string, string>("h6", $@"
                    {vr.Scale(-2 / 9f)}
                    font-family: ""Source Sans Pro"", ""sans-serif""; 
                    font-weight: {options.BodyWeight};
                    text-transform: uppercase;
                "),
                    new KeyValuePair<string, string>("a", $@"
                    color: #0071bc;
                "),
                    new KeyValuePair<string, string>("a:visited", $@"
                    color: #4c2c92;
                "),
                    new KeyValuePair<string, string>("blockquote", $@"
                    {vr.Scale(1 / 4f)}
                    border-left: {vr.Rhythm(1 / 6f)} solid;
                    border-color: {vr.Gray(93)};
                    padding-top: {vr.Rhythm(1 / 3f)};
                    padding-bottom: {vr.Rhythm(1 / 3f)};
                    padding-left: {vr.Rhythm(2 / 3f)};
                    padding-right: {vr.Rhythm(2 / 3f)};
                "),
                    new KeyValuePair<string, string>("blockquote > :last-child", "margin-bottom: 0;"),
                    new KeyValuePair<string, string>("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {vr.Gray(54, "204")};
                    font-weight: {options.BodyWeight};
                    font-style: normal;
                ")
                };
                return ret;
            });
    }
}
