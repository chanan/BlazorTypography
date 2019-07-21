using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class Lincoln : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Lincoln";
        public override string BaseFontSize { get; set; } = "19px";
        public override string BaseLineHeight { get; set; } = "1.58";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Varela Round", Styles = new List<string>{ "400" } } },
            { new GoogleFont{ Name = "Lora", Styles = new List<string>{ "400", "400i", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Lora", "serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.73)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Varela Round", "sans-serif" };
        public override string HeaderWeight { get; set; } = "400";
        public override string BoldWeight { get; set; } = "700";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((baseVR, options) =>
            {
                string linkColor = "#134896";
                VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions {
                    BaseFontSize = "17px",
                    BaseLineHeight = "28px"
                });
                List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("a", $@"
                    color: #e51937;
                    text-decoration: none;
                    text-shadow: .03em 0 #fff,-.03em 0 #fff,0 .03em #fff,0 -.03em #fff,.06em 0 #fff,-.06em 0 #fff,.09em 0 #fff,-.09em 0 #fff,.12em 0 #fff,-.12em 0 #fff,.15em 0 #fff,-.15em 0 #fff;
                    background-image: linear - gradient(to top, rgba(0, 0, 0, 0), rgba(0, 0, 0, 0) 1px, {linkColor} 1px, {linkColor} 2px, rgba(0, 0, 0, 0) 2px);
                "),
                    new KeyValuePair<string, string>("a:hover,a:active", $@"
                    color: {options.BodyColor};
                    text-decoration: none;
                "),
                    new KeyValuePair<string, string>("h1,h2,h3,h4,h5,h6", $@"
                    margin-top: {baseVR.Rhythm(1.5f)};
                    margin-bottom: {baseVR.Rhythm(0.5f)};
                "),
                    new KeyValuePair<string, string>("li>ol,li>ul", @"
                    margin-left: 20px;
                    margin-bottom: 0;
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
                    font-weight: {options.BodyWeight};
                    font-style: normal;
                "),
                    new KeyValuePair<string, string>("blockquote cite:before", @"content: ""-"";"),
                    new KeyValuePair<string, string>(vr.MOBILE_MEDIA_QUERY, $@"
                    html {{
                        {vr.EstablishBaseline()}
                    }}
                    blockquote {{
                        padding-left: {vr.Rhythm(9 / 16)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                ")
                };
                return ret;
            });
    }
}
