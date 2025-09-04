using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using static snowball.API.ApiRoutes;

namespace snowball.API.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class UserProfilesController : Controller
    {
        public UserProfilesController() { }

        [HttpGet]
        [Route(UserProfiles.GetAllProfiles)]
        public IActionResult GetAllProfiles()
        {
            var post = new
            {
                //Id = id,
                Text = "Hello World!"
            };
            return Ok(post);
        }
    }
}
