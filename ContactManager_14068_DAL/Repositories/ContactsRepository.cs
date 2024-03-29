﻿using ContactManager_14068_DAL.Data;
using ContactManager_14068_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager_14068_DAL.Repositories
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly ContactManagerDBContext _dbContext;

        public ContactsRepository(ContactManagerDBContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task CreateContact(Contact contact)
        {
            await _dbContext.contacts.AddAsync(contact);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteContact(int id)
        {
            var contact = await _dbContext.contacts.FirstOrDefaultAsync(c => c.Id == id);

            if (contact != null)
            {
                _dbContext.contacts.Remove(contact);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
            return await _dbContext.contacts.Include(c => c.Group).ToListAsync();
        }

        public async Task<IEnumerable<Contact>> GetAllByGroup(int groupId)
        {
            return await _dbContext.contacts.Where(c => c.GroupId == groupId).Include(c => c.Group).ToListAsync();
        }

        public async Task<Contact> GetContact(int id)
        {
            return await (_dbContext.contacts.Include(c => c.Group).FirstOrDefaultAsync(c => c.Id == id));
        }

        public async Task UpdateContact(Contact contact)
        {
            _dbContext.Entry(contact).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
