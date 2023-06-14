
using MongoDB.Bson;

namespace qorom.api.infrastructure.mongo.dataModel
{
    public class Post
    {
        public ObjectId _id { get; set; }
        public int PostId { get; set; }
        public int ForumId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public PostType PostType { get; set; }
    }
}
