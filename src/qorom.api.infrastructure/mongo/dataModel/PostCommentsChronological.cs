
namespace qorom.api.infrastructure.mongo.dataModel
{
    internal class PostCommentsChronological
    {
        internal int PostCommentId { get; set; }
        internal int PostId { get; set; }
        internal string[]? Comments { get; set; }
    }
}
