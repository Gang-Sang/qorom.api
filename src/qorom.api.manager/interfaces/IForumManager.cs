using qorom.api.model;

namespace qorom.api.manager.interfaces
{
    public interface IForumManager
    {
        IReadOnlyList<Forum> GetForums();
        void CreateForum(Forum forum);
    }
}
