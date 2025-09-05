using MediatR;
using snowball.Domain.Aggregates.UserProfileAggregate;

namespace snowball.Application.UserProfiles.Queries
{
    public class GetUserProfileByIdQuery : IRequest<UserProfile>
    {
        public Guid UserProfileID { get; set; }
    }
}
