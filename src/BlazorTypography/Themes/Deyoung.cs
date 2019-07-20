using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTypography.Themes
{
    class Deyoung : BaseTypographyOptions
    {
        public override string Title { get; set; } = "de Young";
        public override string BaseFontSize { get; set; } = "20px";
        public override string BaseLineHeight { get; set; } = "1.45";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Alegreya Sans", Styles = new List<string>{ "500" } } },
            { new GoogleFont{ Name = "Alegreya", Styles = new List<string>{ "400", "400i", "700", "700i" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string>
        {
            "Alegreya",
            "sans-serif"
        };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,0.9)";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Alegreya Sans", "sans-serif" };
        public override string HeaderWeight { get; set; } = "500";
        public override string BoldWeight { get; set; } = "700";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((vr, options) =>
            {
                var ret = new List<KeyValuePair<string, string>>();
                ret.Add(new KeyValuePair<string, string>("h1", "color: hsla(0,0%,0%,0.75);"));
                ret.Add(new KeyValuePair<string, string>("h2", "color: hsla(0,0%,0%,0.775);"));
                ret.Add(new KeyValuePair<string, string>("h3", "color: hsla(0,0%,0%,0.8);"));
                ret.Add(new KeyValuePair<string, string>("h1,h2,h3,h4,h5,h6", "line-height: 1;"));
                ret.Add(new KeyValuePair<string, string>("h1,h2,h3,h4", $@"
                    line-height: 1;
                    margin-top: {vr.Rhythm(1)};
                    margin-bottom: {vr.Rhythm(1 / 2f)};
                "));
                ret.Add(new KeyValuePair<string, string>("h4,h5,h6", "text-transformation: uppercase;"));
                ret.Add(new KeyValuePair<string, string>("ul", $"margin-top: {vr.Rhythm(1 / 2f)};"));
                ret.Add(new KeyValuePair<string, string>("a", $@"
                    color: hsl(230, 55 %, 58 %);
                    text-decoration: none;
                "));
                ret.Add(new KeyValuePair<string, string>("a:hover,a:active", "box-Shadow: 0 1px 0 0 currentColor;"));
                ret.Add(new KeyValuePair<string, string>("blockquote", $@"
                    color: {vr.Gray(35)};
                    font-style: italic;
                    padding-left: {vr.Rhythm(11 / 16f)};
                    margin-left: 0;
                    border-left: {vr.Rhythm(5 / 16f)} solid {vr.Gray(50)};
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote > :last-child", "margin-bottom: 0;"));
                ret.Add(new KeyValuePair<string, string>(vr.MOBILE_MEDIA_QUERY, $@"
                    html {{
                        font-size: {18 / 16f * 100}%;
                    }}
                    blockquote {{
                        border-left: {vr.Rhythm(3 / 16f)} solid {vr.Gray(50)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                        padding-left: {vr.Rhythm(9 / 16f)};
                    }}
                "));
                return ret;
            });
    }
}
