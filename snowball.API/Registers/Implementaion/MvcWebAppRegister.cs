using snowball.API.Registers.Interface;

namespace snowball.API.Registers.Implementaion
{
    public class MvcWebAppRegister : IWebApllicationRegister
    {
        public void RegisterPipelineComponents(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {

            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
