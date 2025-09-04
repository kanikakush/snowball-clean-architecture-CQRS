using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowball.Domain.Aggregates.PostAggregate
{
    public class PostInteraction
    {
        private PostInteraction() { } //for EF
        public Guid InteractionId { get; private set; }
        public Guid PostId { get; private set; }
        public InteractionType InteractionType { get; private set; }

        //factory method
        public static PostInteraction CreatePostInteraction(Guid postId, InteractionType interactionType)
        {
            return new PostInteraction
            {
                InteractionId = Guid.NewGuid(),
                PostId = postId,
                InteractionType = interactionType
            };
        }
    }
}
