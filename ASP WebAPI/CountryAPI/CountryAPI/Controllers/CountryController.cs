using CountryAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CountryAPI.Controllers
{
    public class CountryController : ApiController
    {
        static List<Country> countries = new List<Country>()
        {
            new Country{ ID=1, CountryName="India", Capital="New Delhi"},
            new Country{ ID=2, CountryName="Japan", Capital="Tokyo"}
        };

       
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

        // GET BY ID
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(x => x.ID == id);

            if (country == null)
                return NotFound();

            return Ok(country);
        }

        // POST
        public IHttpActionResult Post(Country country)
        {
            countries.Add(country);

            return Ok("Country Added");
        }

        // PUT
        public IHttpActionResult Put(int id, Country updatedCountry)
        {
            var country = countries.FirstOrDefault(x => x.ID == id);

            if (country == null)
                return NotFound();

            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;

            return Ok("Country Updated");
        }

        // DELETE
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(x => x.ID == id);

            if (country == null)
                return NotFound();

            countries.Remove(country);

            return Ok("Country Deleted");
        }
    }
}