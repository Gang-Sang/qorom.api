
namespace qorom.api.model
{
    public class Forum
    {
        public int ForumId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? CategoryName { get; set; }
        public Post? LastPost { get; set; }
    }
}
