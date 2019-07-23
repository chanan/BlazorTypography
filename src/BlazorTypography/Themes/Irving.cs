using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class Irving : BaseTypographyOptions
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
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.Add("a", $@"
                    color: {options.BodyColor};
                ");
                styles.Add("a:hover,a:active", $@"
                    color: #3498DB;
                ");
                styles.Add("blockquote", $@"
                    {vr.Scale(1 / 5f)}
                    border-left: {vr.Rhythm(1 / 4f)} solid {vr.Gray(13)};
                    color: {vr.Gray(30)};
                    padding-left: {vr.Rhythm(3 / 4f)};
                    margin-left: 0;
                    margin-right: 0;
                ");
                styles.Add("h3, h4, h5, h6", $"{vr.Rhythm(1 / 2f)};");
                styles.Add("table", $@"
                    {vr.Scale(-1 / 5f)}
                ");
                styles.Add(vr.TABLET_MEDIA_QUERY, $@"
                    blockquote {{
                        padding-left: {vr.Rhythm(1 / 2)};
                        margin-left: {vr.Rhythm(-3 / 4f)};
                        margin-right: 0;
                    }}
                ");
            });
    }
}
