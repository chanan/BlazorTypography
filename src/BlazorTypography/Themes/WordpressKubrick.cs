using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    public class WordpressKubrick : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Wordpress Kubrick";
        public override string BaseFontSize { get; set; } = "12px";
        public override string BaseLineHeight { get; set; } = "1.4";
        public override List<string> BodyFontFamily { get; set; } = new List<string> { "Lucida Grande", "Verdana", "Arial", "Sans-Serif" };
        public override string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public override string BodyWeight { get; set; } = "normal";
        public override List<string> HeaderFontFamily { get; set; } = new List<string> { "Lucida Grande", "Verdana", "Arial", "Sans-Serif" };
        public override string HeaderWeight { get; set; } = "bold";
        public override string BoldWeight { get; set; } = "bold";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.Add("h2,h3", $@"
                    margin-top: {vr.Rhythm(2f)};
                ");
                styles.Add("p", @"
                    margin-bottom: 1em;
                    margin-top: 1em;
                ");
                styles.Add("ol", $@"
                    margin-bottom: 0;
                    margin-left: {vr.Rhythm(2.125f)};
                ");
                styles.Add("ul", $@"
                    list-style: none;
                    margin-left: 0;
                    padding-left: {vr.Rhythm(5 / 8f)};
                    text-indent: {vr.Rhythm(-5 / 8f)};
                ");
                styles.Add("li", $@"
                    display: list-item;
                    margin-left: {vr.Rhythm(5 / 8f)};
                ");
                styles.Add("ul li:before", @"content: ""» "";");
                styles.Add("a", @"
                    color: #06c;
                    text-decoration: none;
                ");
                styles.Add("a:hover", @"
                    color: #147;
                    text-decoration: underline;
                ");
                styles.Add("a:visited", @"
                    color: #b85b5a;
                ");
                styles.Add("blockquote", $@"
                    color: {vr.Gray(47)};
                    margin-top: {vr.Rhythm(1)};
                    margin-right: {vr.Rhythm(2)};
                    margin-bottom: 0;
                    margin-left: {vr.Rhythm(5 / 8f)};
                    padding-left: {vr.Rhythm(1.25f)};
                    border-left: {vr.Rhythm(1 / 3f)} solid {vr.Gray(87)};
                ");
            });
    }
}
