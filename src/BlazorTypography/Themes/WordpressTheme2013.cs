using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class WordpressTheme2013 : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Wordpress Theme 2013";
        public override string BaseFontSize { get; set; } = "16px";
        public override string BaseLineHeight { get; set; } = "1.5";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            new GoogleFont{ Name = "Bitter", Styles = new List<string> { "700" }},
            new GoogleFont{ Name = "Source Sans Pro", Styles = new List<string> { "300i", "400", "400i", "700" }}
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Source Sans Pro", "sans-serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.93)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Bitter", "serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.AddStyle("h1", $@"
                    {vr.Scale(8 / 5f)}
                ");
                styles.AddStyle("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    font-weight: 300;
                    font-style: italic;
                    margin-left: {vr.Rhythm(1.5f)};
                    margin-right: {vr.Rhythm(1.5f)};
                ");
                styles.AddStyle("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    font-weight: {options.BodyWeight};
                    text-transform: uppercase;
                ");
                styles.AddStyle("a", $@"
                    color: #bc360a;
                    text-decoration: none;
                ");
                styles.AddStyle("a:hover", $@"
                    color: #ea9629;
                    text-decoration: underline;
                ");
                styles.AddStyle("ul,ol", $@"
                    margin-left: 0;
                    padding-left: {vr.Rhythm(1.5f)};
                ");
                styles.AddStyle("li>ul,li>ol", $@"
                    margin-left: 0;
                    padding-left: {vr.Rhythm(1.5f)};
                ");
                styles.AddStyle("h6", $@"
                    margin-top: {vr.Rhythm(1.25f)};
                    margin-bottom: {vr.Rhythm(1.25f)};
                ");
                styles.AddStyle("table", $@"
                    {vr.Scale(-1 / 5f)}
                ");
                styles.AddStyle("th", $@"
                    font-weight: {options.BoldWeight};
                    text-transform: uppercase;
                ");
                styles.AddStyle("dl", $"margin-left: {vr.Rhythm(3 / 4f)};");
                styles.AddStyle(vr.TABLET_MEDIA_QUERY, $@"
                    h1 {{
                        {vr.Scale(5 / 5f)}
                    }}
                ");
            });
    }
}
