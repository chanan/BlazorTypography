using System.Collections.Generic;

namespace BlazorTypography
{
    public interface ITypography
    {
        void ApplyTypography();
        void ApplyTypography(ITypographyOptions options);
        List<string> Themes { get; }
        ITypographyOptions ThemeForName(string name);
        float Unitless(string value);
        VerticalRhythm VerticalRhythm { get; set; }
    }
}