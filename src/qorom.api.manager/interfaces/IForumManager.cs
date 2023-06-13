using qorom.api.model;

namespace qorom.api.manager.interfaces
{
    public interface IForumManager
    {
        IReadOnlyList<Forum> GetForums();
        Forum GetForum(int id);
        void CreateForum(Forum forum);
    }
}
