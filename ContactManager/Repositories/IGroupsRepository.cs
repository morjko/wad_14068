using ContactManager.Models;

namespace ContactManager.Repositories
{
    public interface IGroupsRepository
    {
        Task<IEnumerable<Group>> GetAll();

        Task<Group> GetGroup(int id);

        Task CreateGroup(Group group);

        Task UpdateGroup(Group group);

        Task DeleteGroup(int id);
    }
}
