
using MongoDB.Bson;

namespace qorom.api.infrastructure.mongo.dataModel
{
    public class Forum
    {
        public ObjectId _id { get; set; }
        public int ForumId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? CategoryName { get; set; }
    }
}
