using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTypography.Themes
{
    class WordpressTheme2012 : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Wordpress Theme 2012";
        public override string BaseFontSize { get; set; } = "14px";
        public override string BaseLineHeight { get; set; } = "1.714";
        public override double? ScaleRatio { get; set; } = 8 / 5d;
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            new GoogleFont{ Name = "Open Sans", Styles = new List<string> { "400", "400i", "700" }}
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Open Sans", "sans-serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.73)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Open Sans", "sans-serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((vr, options) =>
            {
                var ret = new List<KeyValuePair<string, string>>();
                ret.Add(new KeyValuePair<string, string>("blockquote", $@"
                    font-style: italic;
                    padding-top: {vr.Rhythm(1)};
                    padding-bottom: {vr.Rhythm(1)};
                    padding-left: {vr.Rhythm(1)};
                    padding-right: {vr.Rhythm(1)};
                "));
                ret.Add(new KeyValuePair<string, string>("dl", $@"
                    margin-left: {vr.Rhythm(1)};
                    margin-right: {vr.Rhythm(1)};
                "));
                ret.Add(new KeyValuePair<string, string>("a", $@"
                    color: #21759b;
                "));
                ret.Add(new KeyValuePair<string, string>("a:hover", $@"
                    color: #0f3647;
                "));
                ret.Add(new KeyValuePair<string, string>("a:visited", $@"
                    color: #9f9f9f;
                "));
                ret.Add(new KeyValuePair<string, string>("ul,ol", @"
                    margin-left: 0;
                "));
                ret.Add(new KeyValuePair<string, string>("ol", @"
                    list-style: decimal outside;
                "));
                ret.Add(new KeyValuePair<string, string>("ul", @"
                    list-style: disc outside;
                "));
                ret.Add(new KeyValuePair<string, string>("li", $@"
                    margin-left: {vr.Rhythm(1.5f)};
                "));
                ret.Add(new KeyValuePair<string, string>("table", $@"
                    {vr.Scale(-1 / 5f)}
                    color: {vr.Gray(46)};
                "));
                ret.Add(new KeyValuePair<string, string>("th", $@"
                    font-weight: {options.BoldWeight};
                    text-transform: uppercase;
                    color: {vr.Gray(39)};
                "));
                return ret;
            });
    }
}
