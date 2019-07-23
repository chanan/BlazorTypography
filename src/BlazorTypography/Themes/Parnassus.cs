using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class Parnassus : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Parnassus";
        public override string BaseFontSize { get; set; } = "17px";
        public override string BaseLineHeight { get; set; } = "1.82";
        public override double? ScaleRatio { get; set; } = 2.25;
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Merriweather Sans", Styles = new List<string>{ "800" } } },
            { new GoogleFont{ Name = "Merriweather", Styles = new List<string>{ "400", "400i", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Merriweather", "sans-serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Merriweather Sans", "sans-serif" };
        public override string HeaderWeight { get; set; } = "800";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, baseVR, options) =>
            {
                VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions(options)
                {
                    BaseFontSize = "15px",
                    BaseLineHeight = "27.35px"
                });
                styles.Add("a", $@"
                    color: #375c85;
                    text-decoration: none;
                    box-shadow: 0 1px 0 0 currentColor;
                ");
                styles.Add("a:hover,a:active", $@"
                    box-shadow: none;
                ");
                styles.Add("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-color: {vr.Gray(90)};
                    color: {vr.Gray(41)};
                    font-style: italic;
                    padding-left: {vr.Rhythm(18 / 16f)};
                    margin-left: 0;
                    border-left: {vr.Rhythm(6 / 16f)} solid;
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
                    blockquote {{
                        padding-left: {vr.Rhythm(9 / 16f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                        border-left: {vr.Rhythm(3 / 16f)} solid;
                        border-color: {vr.Gray(90)};
                    }}
                ");
                styles.Add(vr.TABLET_MEDIA_QUERY, $@"
                    html {{
                        {vr.EstablishBaseline()}
                    }}
                ");
            });
    }
}
