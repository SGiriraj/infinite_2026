using AsyncRepoDemo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IContactRepository
{
    Task<List<Contact>> GetAllAsync();

    Task CreateAsync(Contact contact);

    Task DeleteAsync(long Id);
}