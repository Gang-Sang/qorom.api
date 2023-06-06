using qorom.api.model;

namespace qorom.api.infrastructure.interfaces
{
    public interface IForumDataRepository
    {
        IReadOnlyList<Forum> GetForums();
    }
}
