using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class Sutro : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Sutro";
        public override string BaseFontSize { get; set; } = "18px";
        public override string BaseLineHeight { get; set; } = 1.78f.ToString();
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name = "Open Sans", Styles = new List<string>{ "700" } } },
            { new GoogleFont{ Name = "Merriweather", Styles = new List<string>{ "300", "300i", "700", "700i" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Merriweather", "Georgia", "serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override string BodyWeight { get; set; } = "300";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Open Sans", "sans-serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.Add("a", $@"
                    color: #f92300;
                    text-decoration: none;
                ");
                styles.Add("a:hover,a:active", $@"
                    text-decoration: underline;
                ");
                styles.Add("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(3 / 16f)} solid {vr.Gray(80)};
                    color: {vr.Gray(41)};
                    font-style: italic;
                    padding-left: {vr.Rhythm(13 / 16f)};
                    margin-left: 0;
                ");
                styles.Add("blockquote > :last-child", "margin-bottom: 0;");
                styles.Add("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-weight: {options.BodyWeight};
                ");
                styles.Add("blockquote cite:before", @"content: ""-"";");
                styles.Add("ul", "list-style: disc;");
                styles.Add("ul,ol", "margin-left: 0;");
                styles.Add("h1,h2,h3,h4,h5,h6", $"margin-top: {vr.Rhythm(2)};");
                styles.Add("h1", $@"
                    {vr.Scale(6 / 5f)}
                    letter-spacing: -2px;
                ");
                styles.Add("h6", "font-style: italic;");
                styles.Add(vr.MOBILE_MEDIA_QUERY, $@"
                    ul,ol {{
                        margin-left: {vr.Rhythm(1)};
                    }}
                    blockquote {{
                        padding-left: {vr.Rhythm(9 / 16f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                    h5,h6 {{
                        text-transform: uppercase;
                        font-style: italic;
                    }}
                ");
                styles.Add(vr.TABLET_MEDIA_QUERY, $@"
                    h1 {{
                        {vr.Scale(5 / 5f)}
                    }}
                    blockquote {{
                        padding-left: {vr.Rhythm(9 / 16f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                    h5,h6 {{
                        text-transform: uppercase;
                        font-style: italic;
                    }}
                ");
            });
    }
}
