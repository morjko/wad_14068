using ContactManager_14068_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager_14068_DAL.Data
{
    public class ContactManagerDBContext : DbContext
    {
        public ContactManagerDBContext(DbContextOptions<ContactManagerDBContext> options) : base(options) { }

        public DbSet<Group> groups { get; set; }

        public DbSet<Contact> contacts { get; set; }
    }
}
