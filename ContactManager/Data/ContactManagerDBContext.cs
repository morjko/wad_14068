using ContactManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Data
{
    public class ContactManagerDBContext : DbContext
    {
        public ContactManagerDBContext(DbContextOptions<ContactManagerDBContext> options) : base(options) { }

        public DbSet<Group> groups { get; set; }
    }
}
