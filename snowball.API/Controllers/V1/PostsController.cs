using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using snowball.API.Contracts.UserProfile.Requests;
using snowball.Application.UserProfiles.Queries;
using static snowball.API.ApiRoutes;


namespace snowball.API.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]    
    public class PostsController : Controller
    {
        private readonly ILogger<PostsController> _logger;
        private readonly IMediator _mediator;
        public PostsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            //var query = new GetUserProfileByIdQuery { UserProfileID = Guid.Parse(id)};
            var post = new 
            {
                Id = id,
                Text = "Hello World!"
            };
            return Ok(post);
        }
       
    }
}
