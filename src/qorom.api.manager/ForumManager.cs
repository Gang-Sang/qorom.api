using qorom.api.manager.interfaces;
using qorom.api.model;

namespace qorom.api.manager
{
    public class ForumManager : IForumManager
    {
        public Forum[] GetForums()
        {
            return new Forum[0];
        }

        public Forum GetForum(int id)
        {
            return new Forum();
        }
    }
}