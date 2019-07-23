using System;
using System.Collections.Generic;

namespace BlazorTypography
{
    public interface ITypographyOptions
    {
        string BaseFontSize { get; set; }
        string BaseLineHeight { get; set; }
        string BlockMarginBottom { get; set; }
        string BodyColor { get; set; }
        List<string> BodyFontFamily { get; set; }
        string BodyWeight { get; set; }
        string BoldWeight { get; set; }
        string HeaderColor { get; set; }
        List<string> HeaderFontFamily { get; set; }
        string HeaderLineHeight { get; set; }
        string HeaderWeight { get; set; }
        bool? IncludeNormalize { get; set; }
        double? ScaleRatio { get; set; }
        string Title { get; set; }
        List<GoogleFont> GoogleFonts { get; set; }
        Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get; set; }
        Action<Styles, VerticalRhythm, ITypographyOptions> OverrideThemeStyles { get; set; }
        List<IPlugin> Plugins { get; set; }
    }
}