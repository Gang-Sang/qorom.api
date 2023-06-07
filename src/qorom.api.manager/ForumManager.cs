using qorom.api.infrastructure.interfaces;
using qorom.api.manager.interfaces;
using qorom.api.model;

namespace qorom.api.manager
{
    public class ForumManager : IForumManager
    {
        private readonly IForumDataRepository _forumRepository;

        public ForumManager(IForumDataRepository forumRepository)
        {
            _forumRepository = forumRepository;
        }

        public void CreateForum(Forum forum)
        {
            _forumRepository.CreateForum(forum);
        }

        public IReadOnlyList<Forum> GetForums()
        {
            return _forumRepository.GetForums();
        }
    }
}