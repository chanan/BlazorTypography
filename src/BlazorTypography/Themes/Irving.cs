using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTypography.Themes
{
    class Irving : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Irving";
        public override string BaseFontSize { get; set; } = "21px";
        public override string BaseLineHeight { get; set; } = "1.38";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Exo", Styles = new List<string>{ "700" } } },
            { new GoogleFont{ Name = "Yrsa", Styles = new List<string>{ "400", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Yrsa", "georgia", "sans-serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Exo", "sans-serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((vr, options) =>
            {
                var ret = new List<KeyValuePair<string, string>>();
                ret.Add(new KeyValuePair<string, string>("a", $@"
                    color: {options.BodyColor};
                "));
                ret.Add(new KeyValuePair<string, string>("a:hover,a:active", $@"
                    color: #3498DB;
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(1 / 4f)} solid {vr.Gray(13)};
                    color: {vr.Gray(30)};
                    padding-left: {vr.Rhythm(3 / 4f)};
                    margin-left: 0;
                    margin-right: 0;
                "));
                ret.Add(new KeyValuePair<string, string>("h3, h4, h5, h6", $"{vr.Rhythm(1 / 2f)};"));
                ret.Add(new KeyValuePair<string, string>("table", $@"
                    {vr.Scale(-1 / 5f)}
                "));
                ret.Add(new KeyValuePair<string, string>(vr.TABLET_MEDIA_QUERY, $@"
                    blockquote {{
                        padding-left: {vr.Rhythm(1 / 2)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                "));
                return ret;
            });
    }
}
