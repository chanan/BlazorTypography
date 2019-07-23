using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class FairyGates : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Fairy Gates";
        public override string BaseFontSize { get; set; } = "20px";
        public override string BaseLineHeight { get; set; } = "1.45";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Work Sans", Styles = new List<string>{ "600" } } },
            { new GoogleFont{ Name = "Quattrocento Sans", Styles = new List<string>{ "400", "400i", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "PT Sans", "sans-serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Work Sans", "sans-serif" };
        public override string HeaderWeight { get; set; } = "600";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, baseVR, options) =>
            {
                string linkColor = "#1ca086";
                VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions(options)
                {
                    BaseFontSize = "17px",
                    BaseLineHeight = "24.65px"
                });
                styles.AddStyle("a", $@"
                    color: {linkColor};
                    text-decoration: none;
                    text-shadow: .03em 0 #fff,-.03em 0 #fff,0 .03em #fff,0 -.03em #fff,.06em 0 #fff,-.06em 0 #fff,.09em 0 #fff,-.09em 0 #fff,.12em 0 #fff,-.12em 0 #fff,.15em 0 #fff,-.15em 0 #fff;
                    background-image: linear-gradient(to top, rgba(0, 0, 0, 0); rgba(0, 0, 0, 0) 1px, {linkColor} 1px, {linkColor} 2px, rgba(0, 0, 0, 0) 2px);
                ");
                styles.AddStyle("a:hover,a:active", @"
                    text-shadow: none;
                    background-image: none;
                ");
                styles.AddStyle("h1,h2,h3,h4,h5,h6", $@"
                    margin-top: {baseVR.Rhythm(1.5f)};
                    margin-bottom: {baseVR.Rhythm(0.5f)};
                ");
                styles.AddStyle("blockquote", $@"
                    {baseVR.Scale(1 / 5f)}
                    border-left: {baseVR.Rhythm(6 / 16f)} solid {linkColor};
                    color: {baseVR.Gray(35)};
                    padding-left: {baseVR.Rhythm(10 / 16f)};
                    font-style: italic;
                    margin-left: 0;
                    margin-right: 0;
                ");
                styles.AddStyle("blockquote > :last-child", "margin-bottom: 0;");
                styles.AddStyle("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-style: normal;
                    font-weight: {options.BodyWeight};
                ");
                styles.AddStyle("blockquote cite:before", @"content: ""-"";");
                styles.AddStyle(vr.MOBILE_MEDIA_QUERY, $@"
                    html {{
                        {vr.EstablishBaseline()}
                    }}
                    blockquote {{
                        border-left: {baseVR.Rhythm(3 / 16f)} solid {linkColor};
                        color: {baseVR.Gray(41)};
                        padding-left: {vr.Rhythm(9 / 16f)};
                        font-style: italic;
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                ");
            });
    }
}
