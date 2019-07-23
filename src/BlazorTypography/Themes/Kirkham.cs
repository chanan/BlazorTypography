using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class Kirkham : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Kirkham";
        public override string BaseFontSize { get; set; } = "18px";
        public override string BaseLineHeight { get; set; } = "1.44";
        public override double? ScaleRatio { get; set; } = 2.15;
        public override string BlockMarginBottom { get; set; } = "0.75";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Playfair Display", Styles = new List<string>{ "700" } } },
            { new GoogleFont{ Name = "Fira Sans", Styles = new List<string>{ "400", "400i", "700", "700i" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Fira Sans", "sans-serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,1)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Playfair Display", "serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.AddStyle("a", $@"
                    color: #9f392b;
                ");
                styles.AddStyle("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(3 / 16f)} solid {vr.Gray(80)};
                    color: {vr.Gray(41)};
                    font-style: italic;
                    padding-left: {vr.Rhythm(13 / 16f)};
                    margin-left: 0;
                ");
                styles.AddStyle("blockquote > :last-child", "margin-bottom: 0;");
                styles.AddStyle("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-weight: {options.BodyWeight};
                ");
                styles.AddStyle("blockquote cite:before", @"content: ""-"";");
                styles.AddStyle(vr.MOBILE_MEDIA_QUERY, $@"
                    blockquote {{
                        padding-left: {vr.Rhythm(9 / 16)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                ");
            });
    }
}
