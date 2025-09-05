using MediatR;
using snowball.Domain.Aggregates.UserProfileAggregate;

namespace snowball.Application.UserProfiles.Commands
{
    public class CreateUserCommand : IRequest<UserProfile>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string CurrentCity { get; set; } = string.Empty;
    }
}
