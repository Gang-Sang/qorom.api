
namespace qorom.api.model
{
    public class Forum
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Post? LastPost { get; set; }
    }
}
