using Asp.Versioning;
using snowball.API.Registers.Interface;

namespace snowball.API.Registers.Implementaion
{
    public class MvcRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddApiVersioning(builder =>
            {
                builder.AssumeDefaultVersionWhenUnspecified = true;
                builder.DefaultApiVersion = new ApiVersion(1, 0);
                builder.ReportApiVersions = true;
                builder.ApiVersionReader = new UrlSegmentApiVersionReader();
            })
            .AddApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });
            builder.Services.AddEndpointsApiExplorer();


        }
    }
}
