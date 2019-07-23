using System;
using System.Collections.Generic;

namespace BlazorTypography
{
    public class VerticalRhythmOptions : ITypographyOptions
    {
        private readonly ITypographyOptions _typographyOptions;
        public VerticalRhythmOptions()
        {
            _typographyOptions = new DefaultTypographyOptions();
        }

        public VerticalRhythmOptions(ITypographyOptions typographyOptions)
        {
            _typographyOptions = typographyOptions;
        }
        public string RhythmUnit { get; set; } = "rem";
        public string DefaultRhythmBorderWidth { get; set; } = "1px";
        public string DefaultRhythmBorderStyle { get; set; } = "solid";
        public bool RoundToNearestHalfLine { get; set; } = true;
        public string MinLinePadding { get; set; } = "2px";
        public string BaseFontSize { get => _typographyOptions.BaseFontSize; set => _typographyOptions.BaseFontSize = value; }
        public string BaseLineHeight { get => _typographyOptions.BaseLineHeight; set => _typographyOptions.BaseLineHeight = value; }
        public string BlockMarginBottom { get => _typographyOptions.BlockMarginBottom; set => _typographyOptions.BlockMarginBottom = value; }
        public string BodyColor { get => _typographyOptions.BodyColor; set => _typographyOptions.BodyColor = value; }
        public List<string> BodyFontFamily { get => _typographyOptions.BodyFontFamily; set => _typographyOptions.BodyFontFamily = value; }
        public string BodyWeight { get => _typographyOptions.BodyWeight; set => _typographyOptions.BodyWeight = value; }
        public string BoldWeight { get => _typographyOptions.BoldWeight; set => _typographyOptions.BoldWeight = value; }
        public string HeaderColor { get => _typographyOptions.HeaderColor; set => _typographyOptions.HeaderColor = value; }
        public List<string> HeaderFontFamily { get => _typographyOptions.HeaderFontFamily; set => _typographyOptions.HeaderFontFamily = value; }
        public string HeaderLineHeight { get => _typographyOptions.HeaderLineHeight; set => _typographyOptions.HeaderLineHeight = value; }
        public string HeaderWeight { get => _typographyOptions.HeaderWeight; set => _typographyOptions.HeaderWeight = value; }
        public bool? IncludeNormalize { get => _typographyOptions.IncludeNormalize; set => _typographyOptions.IncludeNormalize = value; }
        public double? ScaleRatio { get => _typographyOptions.ScaleRatio; set => _typographyOptions.ScaleRatio = value; }
        public string Title { get => _typographyOptions.Title; set => _typographyOptions.Title = value; }
        public List<GoogleFont> GoogleFonts { get => _typographyOptions.GoogleFonts; set => _typographyOptions.GoogleFonts = value; }
        public Action<Styles, VerticalRhythm, ITypographyOptions> OverrideStyles { get => _typographyOptions.OverrideStyles; set => _typographyOptions.OverrideStyles = value; }
        public Action<Styles, VerticalRhythm, ITypographyOptions> OverrideThemeStyles { get => _typographyOptions.OverrideThemeStyles; set => _typographyOptions.OverrideThemeStyles = value; }
        public List<IPlugin> Plugins { get => _typographyOptions.Plugins; set => _typographyOptions.Plugins = value; }
    }
}
