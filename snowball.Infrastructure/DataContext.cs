using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using snowball.Domain.Aggregates.PostAggregate;
using snowball.Infrastructure.Configurations;

namespace snowball.Infrastructure
{
    public class DataContext: IdentityDbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostCommentConfig());
            modelBuilder.ApplyConfiguration(new PostInteractionConfig());
            modelBuilder.ApplyConfiguration(new UserProfileConfig());
            modelBuilder.ApplyConfiguration(new IdentityUserLoginConfig());
            modelBuilder.ApplyConfiguration(new IdentityUserRoleConfig());
            modelBuilder.ApplyConfiguration(new IdentityUserTokenConfig());
        }
    }
}
