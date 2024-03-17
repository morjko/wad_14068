using ContactManager.Models;

namespace ContactManager.Repositories
{
    public interface IContactsRepository
    {
        Task<IEnumerable<Contact>> GetAll();

        Task<IEnumerable<Contact>> GetAllByGroup(int groupId);

        Task<Contact> GetContact(int id);

        Task CreateContact(Contact contact);

        Task UpdateContact(Contact contact);

        Task DeleteContact(int id);
    }
}
