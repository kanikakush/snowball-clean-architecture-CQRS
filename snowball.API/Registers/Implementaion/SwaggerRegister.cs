using Microsoft.AspNetCore.Mvc.Rendering;
using snowball.API.Options;
using snowball.API.Registers.Interface;

namespace snowball.API.Registers.Implementaion
{
    public class SwaggerRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}
