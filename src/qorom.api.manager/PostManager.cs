using qorom.api.manager.interfaces;
using qorom.api.model;

namespace qorom.api.manager
{
    public class PostManager : IPostManager
    {
        public Post[] GetPostsForForum(int forumId, int? pageNum, int? pageSize)
        {
            return new Post[0];
        }
        public Post GetPost(int id, int? pageNum, int? pageSize)
        {
            return new Post();
        }
    }
}
