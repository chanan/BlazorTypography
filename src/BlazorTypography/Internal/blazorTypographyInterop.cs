using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorTypography.Internal
{
    public class BlazorTypographyInterop
    {
        private IJSRuntime JSRuntime { get; set; }

        public BlazorTypographyInterop(IJSRuntime jsRuntime)
        {
            JSRuntime = jsRuntime;
        }

        public Task SetGoogleFont(string font)
        {
            return JSRuntime.InvokeAsync<bool>("blazorTypography.addFont", font);
        }
    }
}
