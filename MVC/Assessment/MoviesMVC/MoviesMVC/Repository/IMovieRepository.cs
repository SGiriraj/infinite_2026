using System.Collections.Generic;
using MoviesMVC.Models;

namespace MoviesMVC.Repository
{
    interface IMovieRepository
    {
        List<Movie> GetAll();

        Movie GetById(int id);

        void Insert(Movie movie);

        void Update(Movie movie);

        void Delete(int id);

        List<Movie> GetByYear(int year);

        List<Movie> GetByDirector(string director);
    }
}