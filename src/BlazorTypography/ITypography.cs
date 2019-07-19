using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTypography
{
    public interface ITypography
    {
        Task ApplyTypography();
        Task ApplyTypography(ITypographyOptions options);
        List<string> Themes { get; }
        ITypographyOptions ThemeForName(string name);
        float Unitless(string value);
    }
}