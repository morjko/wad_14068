using ContactManager.Models;

namespace ContactManager.Repositories
{
    public interface IContactsRepository
    {
        Task<IEnumerable<Contact>> GetAll();

        Task<Contact> GetContact(int id);

        Task CreateContact(Contact contact);

        Task UpdateContact(Contact contact);

        Task DeleteContact(int id);
    }
}
