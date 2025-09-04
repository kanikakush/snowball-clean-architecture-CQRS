
namespace snowball.Domain.Aggregates.PostAggregate
{
    public class Post
    {
        private readonly List<PostComment> _comments = new List<PostComment>();
        private readonly List<PostInteraction> _interactions = new List<PostInteraction>();
        private Post()
        {
        }
        public Guid Id { get; private set; }
        public Guid UserProfileId { get; private set; }
        public UserProfile UserProfile { get; private set; }
        public string TextContent { get; private set; } = string.Empty;
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }
        public IEnumerable<PostComment> Comments { get { return _comments; } }
        public IEnumerable<PostInteraction> Interactions { get; private set; }

        //factory method
        public static Post CreatePost(Guid userProfileId, string textContent)
        {
            return new Post
            {
                Id = Guid.NewGuid(),
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
        public void AddComment(PostComment newComment)
        {
            _comments.Add(newComment);
            LastModified = DateTime.UtcNow;
        }
        public void AddInteraction(PostInteraction newInteraction)
        {
            _interactions.Add(newInteraction);
            LastModified = DateTime.UtcNow;
        }
        public void RemoveInteraction(PostInteraction interaction)
        {
            _interactions.Remove(interaction);
            LastModified = DateTime.UtcNow;
        }
        public void RemoveComment(PostComment comment)
        {
            _comments.Remove(comment);
            LastModified = DateTime.UtcNow;
        }
        public void ClearInteractions()
        {
            _interactions.Clear();
            LastModified = DateTime.UtcNow;
        }
        public void ClearComments()
        {
            _comments.Clear();
            LastModified = DateTime.UtcNow;
        }
    }
}
