using Microsoft.EntityFrameworkCore;
using snowball.API.Registers.Interface;
using snowball.Infrastructure;

namespace snowball.API.Registers.Implementaion
{
    public class DbRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}
