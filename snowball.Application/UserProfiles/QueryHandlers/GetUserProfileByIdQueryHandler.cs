using MediatR;
using Microsoft.EntityFrameworkCore;
using snowball.Application.UserProfiles.Queries;
using snowball.Domain.Aggregates.UserProfileAggregate;
using snowball.Infrastructure;

namespace snowball.Application.UserProfiles.QueryHandlers
{
    internal class GetUserProfileByIdQueryHandler : IRequestHandler<GetUserProfileByIdQuery, UserProfile>
    {
        private readonly DataContext _dbContext;
        public GetUserProfileByIdQueryHandler(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<UserProfile> Handle(GetUserProfileByIdQuery request, CancellationToken cancellationToken)
        {
            var userProfile = await _dbContext.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileID == request.UserProfileID);
            return userProfile;
        }
    }
}
