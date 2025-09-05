using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using snowball.Domain.Aggregates.UserProfileAggregate;

namespace snowball.Infrastructure.Configurations
{
    internal class UserProfileConfig : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.OwnsOne(up => up.BasicInfo);
            //builder.HasKey(up => up.UserId);
        }
    }
}
