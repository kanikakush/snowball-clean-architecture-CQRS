using MediatR;
using snowball.Application.UserProfiles.Commands;
using snowball.Domain.Aggregates.UserProfileAggregate;
using snowball.Infrastructure;

namespace snowball.Application.UserProfiles.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserProfile>
    {
        private readonly DataContext _dbContext;
        public CreateUserCommandHandler(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<UserProfile> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var basicInfo = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName, 
                request.EmailAddress, request.Phone, request.DateOfBirth, request.CurrentCity);

            var userProfile = UserProfile.CreateUserProfile(Guid.NewGuid().ToString(), basicInfo);

            _dbContext.UserProfiles.Add(userProfile);
            await _dbContext.SaveChangesAsync();
            return userProfile;

        }
    }
}
