using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowball.Domain.Aggregates.PostAggregate
{
    public class PostComment
    {
        public Guid CommentId { get; private set; }
        public Guid PostId { get; private set; }
        public Guid UserProfileId { get; private set; }
        public string TextContent { get; private set; } = string.Empty;
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }
        //factory method
        public static PostComment CreatePostComment(Guid postId, Guid userProfileId, string textContent)
        {
            return new PostComment
            {
                CommentId = Guid.NewGuid(),
                PostId = postId,
                UserProfileId = userProfileId,
                TextContent = textContent,
                CreatedDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }
        //public methods
        public void UpdateTextContent(string textContent)
        {
            TextContent = textContent;
            LastModified = DateTime.UtcNow;
        }
        public void UpdateCommentText(Guid userProfileId, string newText)
        {
            //if (UserProfileId != userProfileId)
            //{
            //    throw new UnauthorizedAccessException("You can only update your own comments.");
            //}
            TextContent = newText;
            LastModified = DateTime.UtcNow;
        }
    }
}
