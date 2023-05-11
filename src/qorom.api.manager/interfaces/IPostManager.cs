using qorom.api.model;

namespace qorom.api.manager.interfaces
{
    public interface IPostManager
    {
        Post[] GetPostsForForum(int forumId, int? pageNum, int? pageSize);
        Post GetPost(int id, int? pageNum, int? pageSize);
    }
}
