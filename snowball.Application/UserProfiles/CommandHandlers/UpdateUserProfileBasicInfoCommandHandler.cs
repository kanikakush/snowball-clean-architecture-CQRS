using MediatR;
using Microsoft.EntityFrameworkCore;
using snowball.Application.UserProfiles.Commands;
using snowball.Domain.Aggregates.UserProfileAggregate;
using snowball.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowball.Application.UserProfiles.CommandHandlers
{
    internal class UpdateUserProfileBasicInfoCommandHandler : IRequestHandler<UpdateUserProfileBasicInfoCommand>
    {
        private readonly DataContext _dbContext;
        public UpdateUserProfileBasicInfoCommandHandler(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Handle(UpdateUserProfileBasicInfoCommand request, CancellationToken cancellationToken)
        {
            var userProfile = await _dbContext.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileID == request.UserProfileId);
            var basicInfo = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName,
                request.EmailAddress, request.Phone, request.DateOfBirth, request.CurrentCity);

            userProfile.UpdateBasicInfo(basicInfo);
            _dbContext.Update(userProfile);
            await _dbContext.SaveChangesAsync();
        }
    }
}
