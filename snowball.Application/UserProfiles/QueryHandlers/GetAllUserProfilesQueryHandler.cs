using MediatR;
using Microsoft.EntityFrameworkCore;
using snowball.Application.UserProfiles.Queries;
using snowball.Domain.Aggregates.UserProfileAggregate;
using snowball.Infrastructure;

namespace snowball.Application.UserProfiles.QueryHandlers
{
    internal class GetAllUserProfilesQueryHandler : IRequestHandler<GetAllUserProfilesQuery, IEnumerable<UserProfile>>
    {
        private readonly DataContext _dbContext;
        public GetAllUserProfilesQueryHandler(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<UserProfile>> Handle(GetAllUserProfilesQuery request, CancellationToken cancellationToken)
        {
            var profiles = await _dbContext.UserProfiles.ToListAsync();
            return profiles;
        }
    }
}
