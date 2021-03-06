﻿using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class StAnnes : BaseTypographyOptions
    {
        public override string Title { get; set; } = "St. Annes";
        public override string BaseFontSize { get; set; } = "16px";
        public override string BaseLineHeight { get; set; } = 1.5625f.ToString();
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Source Serif Pro", Styles = new List<string>{ "600" } } },
            { new GoogleFont{ Name = "Source Serif Pro", Styles = new List<string>{ "400", "400i", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Source Serif Pro", "sans-serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,1)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Source Serif Pro", "sans-serif" };
        public override string HeaderWeight { get; set; } = "600";
        public override string BoldWeight { get; set; } = "700";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.Add("a", $@"
                    color: #fb251b;
                    text-decoration: none;
                ");
                styles.Add("a:hover,a:active", $@"
                    color: {options.BodyColor};
                ");
                styles.Add("h1,h2,h3,h4,h5,h6", $"margin-top: {vr.Rhythm(2)};");
                styles.Add("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(6 / 16f)} solid;
                    color: {vr.Gray(41)};
                    border-color: #fcea0e;
                    padding-left: {vr.Rhythm(18 / 16f)};
                    margin-left: 0;
                ");
                styles.Add("blockquote > :last-child", "margin-bottom: 0;");
                styles.Add("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-weight: {options.BodyWeight};
                ");
                styles.Add("blockquote cite:before", @"content: ""-"";");
                styles.Add(vr.MOBILE_MEDIA_QUERY, $@"
                    blockquote {{
                        padding-left: {vr.Rhythm(9 / 16f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                        border-left: {vr.Rhythm(3 / 16f)} solid;
                        border-color: #fcea0e;
                    }}
                ");
            });
    }
}
