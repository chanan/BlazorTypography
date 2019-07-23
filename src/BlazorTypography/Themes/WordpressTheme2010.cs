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
                styles.AddStyle("h2,h3,h4,h5,h6", @"
                    font-family: ""Georgia"", ""Bitstream Charter"", serif;
                    font-weight: normal;
                ");
                styles.AddStyle("a", $@"
                    color: #0066cc;
                ");
                styles.AddStyle("a:visited", "#743399;");
                styles.AddStyle("a:hover,a:active", $@"
                    color: #ff4b33;
                ");
                styles.AddStyle("li", "margin-bottom: 0;");
                styles.AddStyle("li > ul", "margin-top: 0;");
                styles.AddStyle("blockquote", $@"
                    font-style: italic;
                    margin-bottom: 0;
                    margin-top: 0;
                    margin-left: 3em;
                    margin-right: 3em;
                ");
                styles.AddStyle("blockquote cite", $@"
                    font-style: normal;
                ");
            });
    }
}
