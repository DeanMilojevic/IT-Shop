using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.DependencyInjection;

namespace Api.Ocelot
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication()
                .AddJwtBearer("test", options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.Authority = "http://test.com";
                    options.Audience = "test";
                });

            services.AddOcelot();
        }

        public void Configure(IApplicationBuilder app)
        {
            app
                .UseOcelot()
                .Wait();
        }
    }
}
