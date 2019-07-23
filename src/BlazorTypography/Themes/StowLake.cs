using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class StowLake : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Stow Lake";
        public override string BaseFontSize { get; set; } = "18px";
        public override string BaseLineHeight { get; set; } = "1.722";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Neuton", Styles = new List<string>{ "700" } } },
            { new GoogleFont{ Name = "Lato", Styles = new List<string>{ "400", "400i", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Lato", "sans-serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Neuton", "sans-serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.AddStyle("a", $@"
                    color: #4665b7;
                    text-decoration: none;
                ");
                styles.AddStyle("a:hover,a:active", $@"
                    color: {options.BodyColor};
                ");
                styles.AddStyle("h1,h2,h3,h4,h5,h6", $"margin-top: {vr.Rhythm(2)};");
                styles.AddStyle("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(6 / 16f)} solid;
                    color: {vr.Gray(41)};
                    padding-left: {vr.Rhythm(18 / 16f)};
                    margin-left: 0;
                    border-color: #612423;
                ");
                styles.AddStyle("blockquote > :last-child", "margin-bottom: 0;");
                styles.AddStyle("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-weight: {options.BodyWeight};
                ");
                styles.AddStyle("blockquote cite:before", @"content: ""-"";");
                styles.AddStyle("ul", "list-style: disc;");
                styles.AddStyle(vr.MOBILE_MEDIA_QUERY, $@"
                    blockquote {{
                        padding-left: {vr.Rhythm(9 / 16f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                        border-left: {vr.Rhythm(3 / 16f)} solid;
                        border-color: #612423;
                    }}
                ");
            });
    }
}
