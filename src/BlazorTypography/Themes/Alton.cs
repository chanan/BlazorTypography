using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class Alton : BaseTypographyOptions
    {
        public override string BaseFontSize { get; set; } = "18px";
        public override string BaseLineHeight { get; set; } = "1.78";
        public override string BlockMarginBottom { get; set; } = "0.8";
        public override string BodyColor { get; set; } = "black";
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Open Sans", "sans-serif" };
        public override string BodyWeight { get; set; } = "400";
        public override string BoldWeight { get; set; } = "700";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Domine", "sans-serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string Title { get; set; } = "Alton";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            new GoogleFont {
                Name = "Domine",
                Styles = new List<string> { "700" }
            },
            new GoogleFont {
                Name = "Open Sans",
                Styles = new List<string> { "400", "400i", "700", "700i" }
            }
        };

        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, baseVR, options) =>
            {
                VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions(options)
                {
                    BaseFontSize = "16px",
                    BaseLineHeight = "28.44px"
                });
                styles.AddStyle("a", @"
                    color: #ff5700;
                    text-decoration: none;
                ");
                styles.AddStyle("a:hover,a:active", $@"
                    color: {options.BodyColor};
                ");
                styles.AddStyle("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    color: {vr.Gray(41)};
                    font-style: italic;
                    padding-left: {vr.Rhythm(13 / 16f)};
                    margin-left: 0;
                    border-left: {vr.Rhythm(3 / 16f)} solid {vr.Gray(10)};
                ");
                styles.AddStyle("blockquote > :last-child", @"
                    margin-bottom: 0;
                ");
                styles.AddStyle("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-weight: {options.BodyWeight};
                ");
                styles.AddStyle("blockquote cite:before", @"
                    content: ""— "";
                ");
                styles.AddStyle(vr.MOBILE_MEDIA_QUERY, $@"
                    html {{
                        {vr.EstablishBaseline()}
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
