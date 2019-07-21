using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class Funston : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Funston";
        public override string BaseFontSize { get; set; } = "20px";
        public override string BaseLineHeight { get; set; } = "1.4";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Patua One", Styles = new List<string>{ "400" } } },
            { new GoogleFont{ Name = "Cabin Condensed", Styles = new List<string>{ "400", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Cabin Condensed", "georgia", "sans-serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.87)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Patua One", "sans-serif" };
        public override string HeaderWeight { get; set; } = "400";
        public override string BoldWeight { get; set; } = "700";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((vr, options) =>
            {
                List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("html", "-webkit-font-smoothing: antialiased;"),
                    new KeyValuePair<string, string>("body", "letter-spacing: .03em;"),
                    new KeyValuePair<string, string>("a", "color: inherit;"),
                    new KeyValuePair<string, string>("a:hover", "color: #3498DB;"),
                    new KeyValuePair<string, string>("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    color: {vr.Gray(40)};
                    padding-left: {vr.Rhythm(13 / 16f)};
                    margin-left: {vr.Rhythm(-1f)};
                    border-left: {vr.Rhythm(3 / 16f)} solid {vr.Gray(13)};
                "),
                    new KeyValuePair<string, string>(vr.MOBILE_MEDIA_QUERY, $@"
                    blockquote {{
                        padding-left: {vr.Rhythm(9 / 16f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                ")
                };
                return ret;
            });
    }
}
