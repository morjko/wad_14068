using ContactManager_14068_DAL.Data;
using ContactManager_14068_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager_14068_DAL.Repositories
{
    public class GroupsRepository : IGroupsRepository
    {
        private readonly ContactManagerDBContext _dbContext;

        public GroupsRepository(ContactManagerDBContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task CreateGroup(Group group)
        {
            await _dbContext.groups.AddAsync(group);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteGroup(int id)
        {
            var group = await _dbContext.groups.FirstOrDefaultAsync(g => g.Id == id);

            if (group != null)
            {
                _dbContext.groups.Remove(group);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Group>> GetAll()
        {
            return await _dbContext.groups.ToListAsync();
        }

        public async Task<Group> GetGroup(int id)
        {
            return await (_dbContext.groups.FirstOrDefaultAsync(g => g.Id == id));
        }

        public async Task UpdateGroup(Group group)
        {
            _dbContext.Entry(group).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
