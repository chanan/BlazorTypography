using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class SternGrove : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Stern Grove";
        public override string BaseFontSize { get; set; } = "18px";
        public override string BaseLineHeight { get; set; } = (5 / 3f).ToString("F3");
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Montserrat", Styles = new List<string>{ "400" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Georgia", "Cambria", "serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,1)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Montserrat", "sans-serif" };
        public override string HeaderWeight { get; set; } = "400";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.Add("a", $@"
                    color: #07e;
                    text-decoration: none;
                ");
                styles.Add("a:hover,a:active", $@"
                    color: #e32;
                ");
                styles.Add("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    background: {vr.Gray(97)};
                    border-left: {vr.Rhythm(2 / 16f)} solid {vr.Gray(80)};
                    color: {vr.Gray(31)};
                    padding-left: {vr.Rhythm(14 / 16f)};
                    padding-right: {vr.Rhythm(1 / 2f)};
                    padding-top: {vr.Rhythm(1 / 2f)};
                    padding-bottom: {vr.Rhythm(1 / 2f)}
                    margin-left: 0;
                    margin-right: 0;
                ");
                styles.Add("blockquote > :last-child", "margin-bottom: 0;");
                styles.Add("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-weight: {options.BodyWeight};
                ");
                styles.Add("blockquote cite:before", @"content: ""-"";");
                styles.Add("ul", "list-style: disc;");
                styles.Add(vr.MOBILE_MEDIA_QUERY, $@"
                    ul,ol {{
                        margin-left: {vr.Rhythm(1)};
                    }}
                    blockquote {{
                        padding-left: {vr.Rhythm(11 / 16f)};
                        padding-right: {vr.Rhythm(3 / 4f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: {vr.Rhythm(-3 / 4f)};
                    }}
                    h1,h2,h3,h4,h5,h6 {{
                        margin-top: {vr.Rhythm(2)};
                    }}
                    h6 {{
                        font-style: italic;
                    }}
                ");
            });
    }
}
