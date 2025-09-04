using snowball.API.Registers.Interface;

namespace snowball.API.Extensions
{
    //Why This Pattern?
    //This gives you modular service registration.Instead of dumping everything into Program.cs
    public static class RegisterExtensions
    {
        public static void RegisterBuilderServices(this WebApplicationBuilder builder, Type scanningType)
        {
            var registers = scanningType.Assembly.GetTypes()
                .Where(t => typeof(IWebApplicationBuilderRegister).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .Select(t => (IWebApplicationBuilderRegister)Activator.CreateInstance(t)!);
            //Uses reflection (Activator.CreateInstance) to new-up each matching class at runtime.
            //Casts to IWebApplicationBuilderRegister.

            foreach (var register in registers)
            {
                //Invokes each class’s registration logic.
                register.RegisterServices(builder);
            }
        }
        public static void RegisterPipelineComponents(this WebApplication app, Type scanningType)
        {
            var registers = scanningType.Assembly.GetTypes()
                .Where(t => typeof(IWebApllicationRegister).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .Select(t => (IWebApllicationRegister)Activator.CreateInstance(t)!);
            foreach (var register in registers)
            {
                register.RegisterPipelineComponents(app);
            }
        }
    }
}
