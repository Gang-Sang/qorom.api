using qorom.api.model;

namespace qorom.api.manager.interfaces
{
    public interface IForumManager
    {
        Forum[] GetForums();
        Forum GetForum(int id);
    }
}
