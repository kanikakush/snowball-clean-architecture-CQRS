using MediatR;
using snowball.Domain.Aggregates.UserProfileAggregate;

namespace snowball.Application.UserProfiles.Queries
{
    public class GetAllUserProfilesQuery : IRequest<IEnumerable<UserProfile>>
    {
    }
}
