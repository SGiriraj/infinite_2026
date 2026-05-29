using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using AsyncRepoDemo.Models;

namespace AsyncRepoDemo.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactContext db;

        public ContactRepository()
        {
            db = new ContactContext();
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            return await db.Contacts.ToListAsync();
        }

        public async Task CreateAsync(Contact contact)
        {
            db.Contacts.Add(contact);

            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(long Id)
        {
            Contact contact = await db.Contacts.FindAsync(Id);

            if (contact != null)
            {
                db.Contacts.Remove(contact);

                await db.SaveChangesAsync();
            }
        }
    }
}