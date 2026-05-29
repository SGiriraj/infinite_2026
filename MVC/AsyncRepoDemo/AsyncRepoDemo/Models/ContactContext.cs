using System.Data.Entity;

namespace AsyncRepoDemo.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("MyConnection")
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}