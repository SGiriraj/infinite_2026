using System.Web.Mvc;
using MoviesMVC.Models;
using MoviesMVC.Repository;

namespace MoviesMVC.Controllers
{
    public class MoviesController : Controller
    {
        MovieRepository repo = new MovieRepository();

        // INDEX
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        // CREATE
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            repo.Insert(movie);

            return RedirectToAction("Index");
        }

        // EDIT
        public ActionResult Edit(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            repo.Update(movie);

            return RedirectToAction("Index");
        }

        // DELETE
        public ActionResult Delete(int id)
        {
            repo.Delete(id);

            return RedirectToAction("Index");
        }

        // SEARCH BY YEAR
        public ActionResult MoviesByYear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoviesByYear(int year)
        {
            var result = repo.GetByYear(year);

            return View("YearResult", result);
        }

        // SEARCH BY DIRECTOR
        public ActionResult MoviesByDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoviesByDirector(string director)
        {
            var result = repo.GetByDirector(director);

            return View("DirectorResult", result);
        }
    }
}