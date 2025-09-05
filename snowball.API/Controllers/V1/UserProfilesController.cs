using Asp.Versioning;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using snowball.API.Contracts.UserProfile.Requests;
using snowball.API.Contracts.UserProfile.Responses;
using snowball.Application.UserProfiles.Commands;
using snowball.Application.UserProfiles.Queries;
using static snowball.API.ApiRoutes;

namespace snowball.API.Controllers.V1
{
    [ApiVersion("1.0")]
    //[Route(ApiRoutes.BaseRoute + "/[controller]")]
    [ApiController]
    public class UserProfilesController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public UserProfilesController(IMediator mediator, IMapper mapper) 
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpGet(UserProfiles.GetAllProfiles)]
        public async Task<IActionResult> GetAllProfiles()
        {
            var query = new GetAllUserProfilesQuery();
            var response = await _mediator.Send(query);
            var profiles =  _mapper.Map<List<UserProfileResponse>>(response);
           
            return Ok(profiles);
        }
        [HttpPost(ApiRoutes.UserProfiles.Create)]
        public async Task<IActionResult> CreateUserProfile([FromBody] UserProfileCreateUpdate profile)
        {
            var command = _mapper.Map<CreateUserCommand>(profile);
            var response = await _mediator.Send(command);
            var userProfile = _mapper.Map<UserProfileResponse>(response);
            return CreatedAtAction(nameof(GetUserProfileById), new { id = response.UserProfileID }, userProfile);
        }
        [HttpPost(ApiRoutes.UserProfiles.GetById)]
        public async Task<IActionResult> GetUserProfileById(string id)
        {
            var query = new GetUserProfileByIdQuery { UserProfileID = Guid.Parse(id) };
            var response = await _mediator.Send(query);
            var userProfile = _mapper.Map<UserProfileResponse>(response);
            return Ok(userProfile);
        }
        [HttpPatch(ApiRoutes.UserProfiles.Update)]
        public async Task<IActionResult> UpdateUserProfileById(string id, UserProfileCreateUpdate updateProfile)
        {
            var command = _mapper.Map<UpdateUserProfileBasicInfoCommand>(updateProfile);
            command.UserProfileId = Guid.Parse(id);
            var response = _mediator.Send(command);
            return NoContent();
        }
        [HttpDelete(ApiRoutes.UserProfiles.Delete)]
        public async Task<IActionResult> DeleteUserProfileById(string id)
        {
            var command = new DeleteUserProfileCommand() { UserProfileId = Guid.Parse(id)};
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
