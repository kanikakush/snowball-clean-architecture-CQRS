using MediatR;

namespace snowball.Application.UserProfiles.Commands
{
    public class DeleteUserProfileCommand: IRequest
    {
        public Guid UserProfileId { get; set; }
    }
}
