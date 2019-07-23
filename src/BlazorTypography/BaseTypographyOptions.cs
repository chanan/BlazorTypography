using System;
using System.Collections.Generic;

namespace BlazorTypography
{
    public abstract class BaseTypographyOptions : ITypographyOptions
    {
        public virtual string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string BaseFontSize { get; set; } = "16px";
        public virtual string BaseLineHeight { get; set; } = "1.45";
        public virtual string HeaderLineHeight { get; set; } = "1.1";
        public virtual double? ScaleRatio { get; set; } = 2;
        public virtual List<string> HeaderFontFamily { get; set; } = new List<string> {
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
                "sans-serif",
            };
        public virtual List<string> BodyFontFamily { get; set; } = new List<string> { "georgia", "serif" };
        public virtual string HeaderColor { get; set; } = "inherit";
        public virtual string BodyColor { get; set; } = "hsla(0,0%,0%,0.8)";
        public virtual string HeaderWeight { get; set; } = "bold";
        public virtual string BodyWeight { get; set; } = "normal";
        public virtual string BoldWeight { get; set; } = "bold";
        public virtual string BlockMarginBottom { get; set; } = "1";
        public virtual bool? IncludeNormalize { get; set; } = true;
        public virtual List<GoogleFont> GoogleFonts { get; set; }
        public virtual Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; } = null;
        public Action<Styles, VerticalRhythm, ITypographyOptions> OverrideThemeStyles { get; set; } = null;
        public List<IPlugin> Plugins { get; set; } = null;
    }
}
