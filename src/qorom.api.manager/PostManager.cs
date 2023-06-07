using qorom.api.infrastructure.interfaces;
using qorom.api.manager.interfaces;
using qorom.api.model;

namespace qorom.api.manager
{
    public class PostManager : IPostManager
    {
        private readonly IForumDataRepository _forumRepository;

        public PostManager(IForumDataRepository forumRepository)
        {
            _forumRepository = forumRepository;
        }

        public IReadOnlyList<Post> GetPostsForForum(int forumId, int? pageNum, int? pageSize)
        {
            return _forumRepository.GetPostsForForum(forumId);
        }

        public Post GetPost(int id, int? pageNum, int? pageSize)
        {
            return _forumRepository.GetPost(id);
        }

        public void CreatePost(int forumId, Post post)
        {
            _forumRepository.CreatePost(forumId, post);
        }
    }
}
