using BlazorStyled;
using BlazorTypography;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using SamplePages;

namespace Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTypography();
            services.AddBlazorStyled(); //Note: to use BlazorTypography you do not need this line, BlazorStyled is also used by the sample site
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
