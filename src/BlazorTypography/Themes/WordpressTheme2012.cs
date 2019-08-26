using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class WordpressTheme2012 : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Wordpress Theme 2012";
        public override string BaseFontSize { get; set; } = "14px";
        public override string BaseLineHeight { get; set; } = 1.714f.ToString();
        public override double? ScaleRatio { get; set; } = 8 / 5d;
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            new GoogleFont{ Name = "Open Sans", Styles = new List<string> { "400", "400i", "700" }}
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Open Sans", "sans-serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.73)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Open Sans", "sans-serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.Add("blockquote", $@"
                    font-style: italic;
                    padding-top: {vr.Rhythm(1)};
                    padding-bottom: {vr.Rhythm(1)};
                    padding-left: {vr.Rhythm(1)};
                    padding-right: {vr.Rhythm(1)};
                ");
                styles.Add("dl", $@"
                    margin-left: {vr.Rhythm(1)};
                    margin-right: {vr.Rhythm(1)};
                ");
                styles.Add("a", $@"
                    color: #21759b;
                ");
                styles.Add("a:hover", $@"
                    color: #0f3647;
                ");
                styles.Add("a:visited", $@"
                    color: #9f9f9f;
                ");
                styles.Add("ul,ol", @"
                    margin-left: 0;
                ");
                styles.Add("ol", @"
                    list-style: decimal outside;
                ");
                styles.Add("ul", @"
                    list-style: disc outside;
                ");
                styles.Add("li", $@"
                    margin-left: {vr.Rhythm(1.5f)};
                ");
                styles.Add("table", $@"
                    {vr.Scale(-1 / 5f)}
                    color: {vr.Gray(46)};
                ");
                styles.Add("th", $@"
                    font-weight: {options.BoldWeight};
                    text-transform: uppercase;
                    color: {vr.Gray(39)};
                ");
            });
    }
}
