using ContactManager_14068_DAL.Models;

namespace ContactManager_14068_DAL.Repositories
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
