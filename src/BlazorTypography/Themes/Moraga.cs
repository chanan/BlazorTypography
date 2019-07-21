using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class Moraga : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Moraga";
        public override string BaseFontSize { get; set; } = "18px";
        public override string BaseLineHeight { get; set; } = "1.56";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Source Sans Pro", Styles = new List<string>{ "200", "400", "400i", "700" } } }
        };
        public override double? ScaleRatio { get; set; } = 2.5;
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Source Sans Pro", "sans-serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,85)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.7)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Source Sans Pro", "sans-serif" };
        public override string HeaderWeight { get; set; } = "200";
        public override string BoldWeight { get; set; } = "700";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((baseVR, options) =>
            {
                VerticalRhythm vr = new VerticalRhythm(new VerticalRhythmOptions
                {
                    BaseFontSize = "16px",
                    BaseLineHeight = "24.88px"
                });
                List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("h1 a,h2 a,h3 a,h4 a,h5 a,h6 a", $"font-weight: {options.HeaderWeight};"),
                    new KeyValuePair<string, string>("a", $@"
                    font-weight: 400;
                    color: #419eda;
                    text-decoration: none;
                "),
                    new KeyValuePair<string, string>("a:hover,a:active", $@"
                    color: #2a6496;
                    text-decoration: none;
                "),
                    new KeyValuePair<string, string>("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(1 / 4f)} solid {vr.Gray(87)};
                    color: {vr.Gray(40)};
                    padding-left: {vr.Rhythm(3 / 4f)};
                    margin-left: 0;
                "),
                    new KeyValuePair<string, string>(vr.MOBILE_MEDIA_QUERY, $@"
                    html {{
                        {vr.EstablishBaseline()}
                    }}
                    blockquote {{
                        padding-left: {vr.Rhythm(1 / 2f)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                    table {{
                        {vr.Scale(-1 / 5f)}
                    }}
                ")
                };
                return ret;
            });
    }
}
