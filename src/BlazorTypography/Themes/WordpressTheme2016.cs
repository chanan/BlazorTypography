using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class WordpressTheme2016 : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Wordpress Theme 2016";
        public override string BaseFontSize { get; set; } = "16px";
        public override string BaseLineHeight { get; set; } = "1.75";
        public override double? ScaleRatio { get; set; } = 5 / 2d;
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            new GoogleFont{ Name = "Montserrat", Styles = new List<string> { "700" }},
            new GoogleFont{ Name = "Merriweather", Styles = new List<string> { "400", "400i", "700", "700i", "900", "900i" }}
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Merriweather", "Georgia", "serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Merriweather", "Georgia", "serif" };
        public override string HeaderWeight { get; set; } = "900";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.AddStyle("h1", $@"
                    font-family: Montserrat, sans-serif;
                ");
                styles.AddStyle("h1,h2,h3,h4,h5,h6", $@"
                    margin-top: {vr.Rhythm(2f)};
                ");
                styles.AddStyle("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    font-style: italic;
                    color: {vr.Gray(41)};
                    margin-left: {vr.Rhythm(-1f)};
                    padding-left: {vr.Rhythm(13 / 16f)};
                    border-left: {vr.Rhythm(3 / 16f)} solid {vr.Gray(10)};
                ");
                styles.AddStyle("blockquote > :last-child", "margin-bottom: 0;");
                styles.AddStyle("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-weight: {options.BodyWeight};
                ");
                styles.AddStyle("blockquote cite:before", @"content: ""-"";");
                styles.AddStyle("ul", "list-style: disc;");
                styles.AddStyle("ul,ol", $@"
                    margin-left: 0;
                ");
                styles.AddStyle("h4", $@"
                    letter-spacing: 0.140625em;
                    text-transform: uppercase;
                ");
                styles.AddStyle("h6", "font-style: italic;");
                styles.AddStyle("a", @"
                    box-shadow: 0 1px 0 0 currentColor;
                    color: #007acc;
                    text-decoration: none;
                ");
                styles.AddStyle("a:hover,a:active", "box-shadow: none;");
                styles.AddStyle("mark,ins", $@"
                    background: #007acc;
                    color: white;
                    padding: {vr.Rhythm(1 / 16f)} {vr.Rhythm(1 / 8f)};
                    text-decoration: none;
                ");
                styles.AddStyle(vr.MOBILE_MEDIA_QUERY, $@"
                    ul,ol {{
                        margin-left: {vr.Rhythm(1)};
                    }}
                    blockquote {{
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                        padding-left: {vr.Rhythm(9 / 16f)};
                    }}
                ");
            });
    }
}
