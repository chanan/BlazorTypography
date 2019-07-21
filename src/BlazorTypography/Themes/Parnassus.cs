using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTypography.Themes
{
    class Parnassus : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Parnassus";
        public override string BaseFontSize { get; set; } = "17px";
        public override string BaseLineHeight { get; set; } = "1.82";
        public override double? ScaleRatio { get; set; } = 2.25;
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Merriweather Sans", Styles = new List<string>{ "800" } } },
            { new GoogleFont{ Name = "Merriweather", Styles = new List<string>{ "400", "400i", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Merriweather", "sans-serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Merriweather Sans", "sans-serif" };
        public override string HeaderWeight { get; set; } = "800";
        public override string BoldWeight { get; set; } = "700";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((baseVR, options) =>
            {
                var vr = new VerticalRhythm(new VerticalRhythmOptions {
                    BaseFontSize = "15px",
                    BaseLineHeight = "27.35px"
                });
                var ret = new List<KeyValuePair<string, string>>();
                ret.Add(new KeyValuePair<string, string>("a", $@"
                    color: #375c85;
                    text-decoration: none;
                    box-shadow: 0 1px 0 0 currentColor;
                "));
                ret.Add(new KeyValuePair<string, string>("a:hover,a:active", $@"
                    box-shadow: none;
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-color: {vr.Gray(90)};
                    color: {vr.Gray(41)};
                    font-style: italic;
                    padding-left: {vr.Rhythm(18 / 16f)};
                    margin-left: 0;
                    border-left: {vr.Rhythm(6 / 16f)} solid;
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote > :last-child", "margin-bottom: 0;"));
                ret.Add(new KeyValuePair<string, string>("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-weight: {options.BodyWeight};
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote cite:before", @"content: ""-"";"));
                ret.Add(new KeyValuePair<string, string>("ul", "list-style: disc;"));
                ret.Add(new KeyValuePair<string, string>(vr.MOBILE_MEDIA_QUERY, $@"
                    blockquote {{
                        padding-left: {vr.Rhythm(9 / 16f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                        border-left: {vr.Rhythm(3 / 16f)} solid;
                        border-color: {vr.Gray(90)};
                    }}
                "));
                ret.Add(new KeyValuePair<string, string>(vr.TABLET_MEDIA_QUERY, $@"
                    html {{
                        {vr.EstablishBaseline()}
                    }}
                "));
                return ret;
            });
    }
}
