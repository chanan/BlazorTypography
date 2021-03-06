﻿using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class Doelger : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Doelger";
        public override string BaseFontSize { get; set; } = "17px";
        public override string BaseLineHeight { get; set; } = 1.45f.ToString();
        public override string BlockMarginBottom { get; set; } = 0.8f.ToString();
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Arvo", Styles = new List<string>{ "700" } } },
            { new GoogleFont{ Name = "Cabin", Styles = new List<string>{ "400", "400i", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Cabin", "serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Arvo", "sans-serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                string linkColor = "#ff483b";
                styles.Add("a", $@"
                    color: {linkColor};
                    text-decoration: none;
                    text-shadow: .03em 0 #fff,-.03em 0 #fff,0 .03em #fff,0 -.03em #fff,.06em 0 #fff,-.06em 0 #fff,.09em 0 #fff,-.09em 0 #fff,.12em 0 #fff,-.12em 0 #fff,.15em 0 #fff,-.15em 0 #fff;
                    background-image: linear-gradient(to top, rgba(0, 0, 0, 0), rgba(0, 0, 0, 0) 1px, {linkColor} 1px, {linkColor} 2px, rgba(0, 0, 0, 0) 2px);
                ");
                styles.Add("a:hover,a:active", @"
                    text-shadow: none;
                    background-image: none;
                ");
                styles.Add("h1,h2,h3,h4,h5,h6", $@"
                    line-height: 1.2;
                    margin-top: {vr.Rhythm(1.5f)};
                    margin-bottom: {vr.Rhythm(0.5f)};
                ");
                styles.Add("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(6 / 16f)} solid {linkColor};
                    color: {vr.Gray(35)};
                    font-style: italic;
                    padding-left: {vr.Rhythm(10 / 16f)};
                    margin-left: 0;
                    margin-right: 0;
                ");
                styles.Add("blockquote > :last-child", "margin-bottom: 0;");
                styles.Add("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-style: normal;
                    font-weight: {options.BodyWeight};
                ");
                styles.Add("blockquote cite:before", @"content: ""-"";");
                styles.Add(vr.MOBILE_MEDIA_QUERY, $@"
                    blockquote {{
                        border-left: {vr.Rhythm(3 / 16f)} solid {linkColor};
                        padding-left: {vr.Rhythm(9 / 16f)};
                        font-style: italic;
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                ");
            });
    }
}
