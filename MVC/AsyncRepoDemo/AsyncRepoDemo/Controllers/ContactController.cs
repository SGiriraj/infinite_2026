using System.Threading.Tasks;
using System.Web.Mvc;
using AsyncRepoDemo.Models;
using AsyncRepoDemo.Repositories;

namespace AsyncRepoDemo.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository repo;

        public ContactController()
        {
            repo = new ContactRepository();
        }

        // GET : Contact
        public async Task<ActionResult> Index()
        {
            var contacts = await repo.GetAllAsync();

            return View(contacts);
        }

        // GET : Create
        public ActionResult Create()
        {
            return View();
        }

        // POST : Create
        [HttpPost]
        public async Task<ActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                await repo.CreateAsync(contact);

                return RedirectToAction("Index");
            }

            return View(contact);
        }

        // GET : Delete
        public async Task<ActionResult> Delete(long id)
        {
            await repo.DeleteAsync(id);

            return RedirectToAction("Index");
        }
    }
}