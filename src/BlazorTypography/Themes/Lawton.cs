using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTypography.Themes
{
    class Lawton : BaseTypographyOptions
    {
        private static string _blockMarginBottom = (2 / 3f).ToString("F3");
        public override string Title { get; set; } = "Lawton";
        public override string BaseFontSize { get; set; } = "16px";
        public override string BaseLineHeight { get; set; } = "1.5";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            { new GoogleFont{ Name ="Raleway", Styles = new List<string>{ "800" } } },
            { new GoogleFont{ Name = "Libre Baskerville", Styles = new List<string>{ "400", "400i", "700" } } }
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Libre Baskerville", "Georgia", "serif" };
        public override string HeaderColor { get; set; } = "hsla(0,0%,0%,1)";
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Raleway", "sans-serif" };
        public override string HeaderWeight { get; set; } = "800";
        public override string BoldWeight { get; set; } = "700";
        public override string BlockMarginBottom { get; set; } = _blockMarginBottom;
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((baseVR, options) =>
            {
                var vr = new VerticalRhythm(new VerticalRhythmOptions {
                    BaseFontSize = "12.8px",
                    BaseLineHeight = "19.2px"
                });
                var ret = new List<KeyValuePair<string, string>>();
                ret.Add(new KeyValuePair<string, string>("blockquote", $@"
                    color: {vr.Gray(26.6f)};
                    border-left: 4px solid #999;
                    padding-left: {vr.Rhythm(float.Parse(_blockMarginBottom))};
                    margin-left: {vr.Rhythm(float.Parse(_blockMarginBottom))};
                    margin-right: {vr.Rhythm(float.Parse(_blockMarginBottom))};
                    margin-top: {vr.Rhythm(float.Parse(_blockMarginBottom))};
                    margin-bottom: {vr.Rhythm(float.Parse(_blockMarginBottom))};
                "));
                ret.Add(new KeyValuePair<string, string>("a", @"
                    font-weight: bold;
                    color: #00f;
                    text-decoration: none;
                "));
                ret.Add(new KeyValuePair<string, string>("a:hover", @"
                    text-decoration: underline;
                "));
                ret.Add(new KeyValuePair<string, string>(vr.MOBILE_MEDIA_QUERY, $@"
                    html {{
                        {vr.EstablishBaseline()}
                    }}
                "));
                return ret;
            });
    }
}
