using System.Threading.Tasks;

namespace BlazorTypography
{
    public interface ITypography
    {
        Task ApplyTypography();
        Task ApplyTypography(ITypographyOptions options);
    }
}