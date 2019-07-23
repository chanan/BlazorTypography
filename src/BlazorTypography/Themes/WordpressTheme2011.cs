﻿using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class WordpressTheme2011 : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Wordpress Theme 2011";
        public override string BaseFontSize { get; set; } = "15px";
        public override string BaseLineHeight { get; set; } = "1.6";
        public override double? ScaleRatio { get; set; } = 1.7333;
        public override List<string> BodyFontFamily { get; set; } = new List<string>
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
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.87)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.78)";
        public override string BodyWeight { get; set; } = "300";
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
                styles.AddStyle("h2", $@"
                    {vr.AdjustFontSizeTo("15px")}
                    margin-bottom: 0;
                ");
                styles.AddStyle("h3", $@"
                    {vr.AdjustFontSizeTo("10px")}
                    margin-bottom: 0;
                    text-transform: uppercase;
                ");
                styles.AddStyle("h4", $@"
                    {vr.AdjustFontSizeTo("15px")}
                    font-weight: normal;
                    margin-bottom: 0;
                ");
                styles.AddStyle("h5", $@"
                    {vr.AdjustFontSizeTo("15px")}
                    font-weight: normal;
                    margin-bottom: 0;
                ");
                styles.AddStyle("h6", $@"
                    {vr.AdjustFontSizeTo("15px")}
                    font-weight: normal;
                    margin-bottom: 0;
                ");
                styles.AddStyle("a", $@"
                    color: #1bafe0;
                    text-decoration: none;
                ");
                styles.AddStyle("a:focus, a:active, a:hover", $@"
                    text-decoration: underline;
                ");
                styles.AddStyle("ul,ol", @"
                    margin-bottom: 1.625em;
                    margin-left: 2.5em;
                ");
                styles.AddStyle("li", "margin-bottom: 0;");
                styles.AddStyle("li > ul", "margin-top: 0;");
                styles.AddStyle("ins", "background: #fff9c0;");
                styles.AddStyle("li>ol,li>ul", @"
                    margin-left: 2.5em;
                    margin-bottom: 0;
                ");
                styles.AddStyle("blockquote", $@"
                    font-family: Georgia, ""Bitstream Charter"", serif;
                    font-style: italic;
                    margin-bottom: 0;
                    margin-top: 0;
                    margin-left: 3em;
                    margin-right: 3em;
                ");
            });
    }
}
