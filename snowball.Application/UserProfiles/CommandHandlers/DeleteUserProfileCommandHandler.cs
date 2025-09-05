using MediatR;
using Microsoft.EntityFrameworkCore;
using snowball.Application.UserProfiles.Commands;
using snowball.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowball.Application.UserProfiles.CommandHandlers
{
    internal class DeleteUserProfileCommandHandler : IRequestHandler<DeleteUserProfileCommand>
    {
        private readonly DataContext _dbContext;
        public DeleteUserProfileCommandHandler(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Handle(DeleteUserProfileCommand request, CancellationToken cancellationToken)
        {
            var userProfile = await _dbContext.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileID == request.UserProfileId);
            if (userProfile is null)
                return;

            _dbContext.UserProfiles.Remove(userProfile);
            await _dbContext.SaveChangesAsync();
        }
    }
}
