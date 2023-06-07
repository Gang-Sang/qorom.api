using qorom.api.model;

namespace qorom.api.manager.interfaces
{
    public interface IPostManager
    {
        IReadOnlyList<Post> GetPostsForForum(int forumId, int? pageNum, int? pageSize);
        void CreatePost(int forumId, Post post);
        Post GetPost(int id, int? pageNum, int? pageSize);
    }
}
