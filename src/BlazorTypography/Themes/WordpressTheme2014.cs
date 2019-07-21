using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class WordpressTheme2014 : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Wordpress Theme 2014";
        public override string BaseFontSize { get; set; } = "16px";
        public override string BaseLineHeight { get; set; } = "1.5";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            new GoogleFont{ Name = "Lato", Styles = new List<string> { "300", "300i", "400", "400i", "600" }}
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Lato", "serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.83)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Lato", "serif" };
        public override string HeaderWeight { get; set; } = "600";
        public override string BoldWeight { get; set; } = "600";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((vr, options) =>
            {
                List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("h1,h2,h3,h4,h5,h6", $@"
                    margin-top: {vr.Rhythm(1.5f)};
                    margin-bottom: {vr.Rhythm(0.5f)};
                "),
                    new KeyValuePair<string, string>("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    font-weight: 300;
                    font-style: italic;
                    color: {vr.Gray(46)};
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
                    new KeyValuePair<string, string>("ul,ol", $@"
                    margin-left: {vr.Rhythm(5 / 6f)};
                "),
                    new KeyValuePair<string, string>("li>ul,li>ol", $@"
                    margin-left: vr.Rhythm(5 / 6f);
                    margin-bottom: 0;
                ")
                };
                return ret;
            });
    }
}
