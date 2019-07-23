using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class WordpressTheme2010 : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Wordpress Theme 2010";
        public override string BaseFontSize { get; set; } = "16px";
        public override string BaseLineHeight { get; set; } = "1.5";
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "georgia", "serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,1)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "normal";
        public override List<string> HeaderFontFamily { get; set; } = new List<string>
        {
            "Helvetica Neue",
            "Helvetica",
            "Segoe UI",
            "Arial",
            "freesans",
            "sans-serif",
            "Apple Color Emoji",
            "Segoe UI Emoji",
            "Segoe UI Symbol"
        };
        public override string HeaderWeight { get; set; } = "bold";
        public override string BoldWeight { get; set; } = "bold";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.Add("h2,h3,h4,h5,h6", @"
                    font-family: ""Georgia"", ""Bitstream Charter"", serif;
                    font-weight: normal;
                ");
                styles.Add("a", $@"
                    color: #0066cc;
                ");
                styles.Add("a:visited", "#743399;");
                styles.Add("a:hover,a:active", $@"
                    color: #ff4b33;
                ");
                styles.Add("li", "margin-bottom: 0;");
                styles.Add("li > ul", "margin-top: 0;");
                styles.Add("blockquote", $@"
                    font-style: italic;
                    margin-bottom: 0;
                    margin-top: 0;
                    margin-left: 3em;
                    margin-right: 3em;
                ");
                styles.Add("blockquote cite", $@"
                    font-style: normal;
                ");
            });
    }
}
