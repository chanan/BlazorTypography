using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTypography.Themes
{
    class WordpressTheme2015 : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Wordpress Theme 2015";
        public override string BaseFontSize { get; set; } = "19px";
        public override string BaseLineHeight { get; set; } = "1.68";
        public override List<GoogleFont> GoogleFonts { get; set; } = new List<GoogleFont>
        {
            new GoogleFont{ Name = "Noto Serif", Styles = new List<string> { "400", "700" }}
        };
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Noto Serif", "serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "400";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Noto Serif", "serif" };
        public override string HeaderWeight { get; set; } = "700";
        public override string BoldWeight { get; set; } = "700";
        public override Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>> OverrideStyles { get; set; } =
            new Func<VerticalRhythm, ITypographyOptions, IList<KeyValuePair<string, string>>>((vr, options) =>
            {
                var ret = new List<KeyValuePair<string, string>>();
                ret.Add(new KeyValuePair<string, string>("h5,h6", $@"
                    letter-spacing: 0.1em;
                    text-transform: uppercase;
                "));
                ret.Add(new KeyValuePair<string, string>("h1,h2,h3,h4,h5,h6", $@"
                    margin-top: {vr.Rhythm(2f)};
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    font-style: italic;
                    color: {vr.Gray(41)};
                    margin-left: {vr.Rhythm(5 / 8f)};
                    padding-left: {vr.Rhythm(-6 / 8f)};
                    border-left: {vr.Rhythm(1 / 8f)} solid rgba(51, 51, 51, 0.7);
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote > :last-child", "margin-bottom: 0;"));
                ret.Add(new KeyValuePair<string, string>("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {options.BodyColor};
                    font-style: normal;
                "));
                ret.Add(new KeyValuePair<string, string>("blockquote cite:before", @"content: ""-"";"));
                ret.Add(new KeyValuePair<string, string>("ul", "list-style: disc;"));
                ret.Add(new KeyValuePair<string, string>("ul,ol", $@"
                    margin-left: 0;
                "));
                ret.Add(new KeyValuePair<string, string>("li>ul,li>ol", $@"
                    margin-left: vr.Rhythm(2 / 3f);
                    margin-bottom: 0;
                "));
                ret.Add(new KeyValuePair<string, string>(vr.MOBILE_MEDIA_QUERY, $@"
                    ul,ol {{
                        margin-left: {vr.Rhythm(1)};
                    }}
                    blockquote {{
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                        padding-left: {vr.Rhythm(9 / 16f)};
                    }}
                "));
                return ret;
            });
    }
}
