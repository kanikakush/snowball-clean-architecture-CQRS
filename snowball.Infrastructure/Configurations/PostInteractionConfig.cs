using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using snowball.Domain.Aggregates.PostAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowball.Infrastructure.Configurations
{
    internal class PostInteractionConfig : IEntityTypeConfiguration<PostInteraction>
    {
        public void Configure(EntityTypeBuilder<PostInteraction> builder)
        {
            builder.HasKey(pi => pi.InteractionId);
        }
    }
}
