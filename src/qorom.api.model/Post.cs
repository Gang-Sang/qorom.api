namespace qorom.api.model
{
    public class Post
    {
        public int PostId { get; set; }
        public int ForumId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int NumOfComments { get; set; }

        public PostType PostType { get; set; }
    }
}
