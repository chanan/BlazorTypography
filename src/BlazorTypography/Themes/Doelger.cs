using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class Doelger : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Doelger";
        public override string BaseFontSize { get; set; } = "17px";
        public override string BaseLineHeight { get; set; } = "1.45";
        public override string BlockMarginBottom { get; set; } = "0.8";
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
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((vr, options) =>
            {
                string linkColor = "#ff483b";
                List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("a", $@"
                    color: {linkColor};
                    text-decoration: none;
                    text-shadow: .03em 0 #fff,-.03em 0 #fff,0 .03em #fff,0 -.03em #fff,.06em 0 #fff,-.06em 0 #fff,.09em 0 #fff,-.09em 0 #fff,.12em 0 #fff,-.12em 0 #fff,.15em 0 #fff,-.15em 0 #fff;
                    background-image: linear-gradient(to top, rgba(0, 0, 0, 0), rgba(0, 0, 0, 0) 1px, {linkColor} 1px, {linkColor} 2px, rgba(0, 0, 0, 0) 2px);
                "),
                    new KeyValuePair<string, string>("a:hover,a:active", @"
                    text-shadow: none;
                    background-image: none;
                "),
                    new KeyValuePair<string, string>("h1,h2,h3,h4,h5,h6", $@"
                    line-height: 1.2;
                    margin-top: {vr.Rhythm(1.5f)};
                    margin-bottom: {vr.Rhythm(0.5f)};
                "),
                    new KeyValuePair<string, string>("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(6 / 16f)} solid {linkColor};
                    color: {vr.Gray(35)};
                    font-style: italic;
                    padding-left: {vr.Rhythm(10 / 16f)};
                    margin-left: 0;
                    margin-right: 0;
                "),
                    new KeyValuePair<string, string>("blockquote > :last-child", "margin-bottom: 0;"),
                    new KeyValuePair<string, string>("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-style: normal;
                    font-weight: {options.BodyWeight};
                "),
                    new KeyValuePair<string, string>("blockquote cite:before", @"content: ""-"";"),
                    new KeyValuePair<string, string>(vr.MOBILE_MEDIA_QUERY, $@"
                    blockquote {{
                        border-left: {vr.Rhythm(3 / 16f)} solid {linkColor};
                        padding-left: {vr.Rhythm(9 / 16f)};
                        font-style: italic;
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                ")
                };
                return ret;
            });
    }
}
