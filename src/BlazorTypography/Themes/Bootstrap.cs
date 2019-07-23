using System;
using System.Collections.Generic;

namespace BlazorTypography.Themes
{
    internal class Bootstrap : BaseTypographyOptions
    {
        public override string Title { get; set; } = "Bootstrap";
        public override string BaseFontSize { get; set; } = "16px";
        public override string BaseLineHeight { get; set; } = "1.5";
        public override List<string> BodyFontFamily { get; set; } = new List<string>
        {
            "-apple-system",
            "BlinkMacSystemFont",
            "Segoe UI",
            "Roboto",
            "Oxygen",
            "Ubuntu",
            "Cantarell",
            "Fira Sans",
            "Droid Sans",
            "Helvetica Neue",
            "sans-serif"
        };
        public override double? ScaleRatio { get; set; } = 2.25;
        public override string BodyWeight { get; set; } = "400";
        public override string HeaderWeight { get; set; } = "500";
        public override string BoldWeight { get; set; } = "bold";
        public override Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } =
            new Action<Styles, VerticalRhythm, ITypographyOptions>((styles, vr, options) =>
            {
                styles.AddStyle("body", $"color: {vr.Gray(23, "204")};");
                styles.AddStyle("h1", $"{vr.Scale(4 / 4f)}");
                styles.AddStyle("h2", $"{vr.Scale(3 / 4f)}");
                styles.AddStyle("h3", $"{vr.Scale(2 / 4f)}");
                styles.AddStyle("h4", $"{vr.Scale(1 / 6f)}");
                styles.AddStyle("h5", $"{vr.Scale(-1 / 6f)}");
                styles.AddStyle("h6", $"{vr.Scale(-2 / 6f)}");
                styles.AddStyle("blockquote", $@"
                    {vr.Scale(1 / 4f)}
                    border-left: {vr.Rhythm(1 / 6f)} solid #eceeef;
                    padding-top: {vr.Rhythm(1 / 3f)};
                    padding-bottom: {vr.Rhythm(1 / 3f)};
                    padding-left: {vr.Rhythm(2 / 3f)};
                    padding-right: {vr.Rhythm(2 / 3f)};
                ");
                styles.AddStyle("blockquote > :last-child", "margin-bottom: 0;");
                styles.AddStyle("blockquote cite", $@"
                    {vr.AdjustFontSizeTo(options.BaseFontSize)}
                    color: {vr.Gray(54, "204")};
                    font-weight: {options.BodyWeight};
                    font-style: normal;
                ");
            });
    }
}
