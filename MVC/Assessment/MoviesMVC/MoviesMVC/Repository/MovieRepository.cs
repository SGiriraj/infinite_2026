using System.Collections.Generic;
using System.Linq;
using MoviesMVC.Models;

namespace MoviesMVC.Repository
{
    public class MovieRepository : IMovieRepository
    {
        MovieContext db = new MovieContext();

        public List<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return db.Movies.Find(id);
        }

        public void Insert(Movie movie)
        {
            db.Movies.Add(movie);

            db.SaveChanges();
        }

        public void Update(Movie movie)
        {
            db.Entry(movie).State =
            System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Movie m = db.Movies.Find(id);

            db.Movies.Remove(m);

            db.SaveChanges();
        }

        public List<Movie> GetByYear(int year)
        {
            return db.Movies
                     .Where(x => x.DateOfRelease.Year == year)
                     .ToList();
        }

        public List<Movie> GetByDirector(string director)
        {
            return db.Movies
                     .Where(x => x.DirectorName == director)
                     .ToList();
        }
    }
}