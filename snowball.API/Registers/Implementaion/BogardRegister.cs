using MediatR;
using snowball.API.Registers.Interface;
using snowball.Application.UserProfiles.Commands;
using snowball.Application.UserProfiles.Queries;
using snowball.Domain.Aggregates.UserProfileAggregate;
using System.Reflection;

namespace snowball.API.Registers.Implementaion
{
    public class BogardRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(Program), typeof(GetAllUserProfilesQuery));
            builder.Services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssemblies(
                    Assembly.GetExecutingAssembly(),
                    Assembly.GetExecutingAssembly(),                 // snowball.API
                    typeof(CreateUserCommand).Assembly,              // snowball.Application
                    typeof(UserProfile).Assembly
                    ));
        }
    }
}
