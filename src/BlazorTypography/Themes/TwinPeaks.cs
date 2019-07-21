using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTypography.Themes
{
    class TwinPeaks : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Twin Peaks";
        public override string BaseFontSize { get; set; } = "21px";
        public override string BaseLineHeight { get; set; } = "1.5";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Rosario", Styles = new List<string>{ "700" } } },
            { new GoogleFont{ Name = "Crimson Text", Styles = new List<string>{ "400", "400i", "600" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Crimson Text", "serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.73)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Rosario", "sans-serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "600";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((baseVR, options) =>
            {
                var linkColor = "#ff5700";
                var vr = new VerticalRhythm(new VerticalRhythmOptions
                {
                    BaseFontSize = "19px",
                    BaseLineHeight = "29.85px"
                });
                var ret = new List<KeyValuePair<string, string>>();
                ret.Add(new KeyValuePair<string, string>("a", $@"
                    color: {linkColor};
                    text-decoration: none;
                    text-shadow: .03em 0 #fff,-.03em 0 #fff,0 .03em #fff,0 -.03em #fff,.06em 0 #fff,-.06em 0 #fff,.09em 0 #fff,-.09em 0 #fff,.12em 0 #fff,-.12em 0 #fff,.15em 0 #fff,-.15em 0 #fff;
                    background-image: linear-gradient(to top, rgba(0, 0, 0, 0), rgba(0, 0, 0, 0) 1px, {linkColor} 1px, {linkColor} 2px, rgba(0, 0, 0, 0) 2px);
                "));
                ret.Add(new KeyValuePair<string, string>("a:hover,a:active", $@"
                    text-shadow: none;
                    background-image: none;
                "));
                ret.Add(new KeyValuePair<string, string>("h1,h2,h3,h4,h5,h6", $@"
                    margin-top: {vr.Rhythm(1.5f)};
                    margin-bottom: {vr.Rhythm(0.5f)};
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(3 / 16f)} solid {linkColor};
                    color: {vr.Gray(41)};
                    font-style: italic;
                    padding-left: {vr.Rhythm(13 / 16f)};
                    margin-left: 0;
                    margin-right: 0;
                "));
                ret.Add(new KeyValuePair<string, string>("ul,ol", $"margin-left: {vr.Rhythm(2 / 3f)};"));
                ret.Add(new KeyValuePair<string, string>("li>ol,li>ul", $@"
                    margin-left: {vr.Rhythm(2 / 3f)};
                    margin-bottom: 0;
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote > :last-child", "margin-bottom: 0;"));
                ret.Add(new KeyValuePair<string, string>("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-weight: {options.BodyWeight};
                    font-style: normal;
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote cite:before", @"content: ""-"";"));
                ret.Add(new KeyValuePair<string, string>("ul", "list-style: disc;"));
                ret.Add(new KeyValuePair<string, string>(vr.MOBILE_MEDIA_QUERY, $@"
                    html {{
                        {vr.EstablishBaseline()}
                    }}
                    blockquote {{
                        border-left: {vr.Rhythm(3 / 16f)} solid {linkColor};
                        color: {vr.Gray(41)};
                        padding-left: {vr.Rhythm(9 / 16f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                        font-style: italic;
                    }}
                "));
                return ret;
            });
    }
}
