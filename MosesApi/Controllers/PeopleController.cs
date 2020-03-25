using MosesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MosesApi.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Moses", LastName = "Lazaro", Id = 1 });
            people.Add(new Person { FirstName = "Thomas", LastName = "Noel", Id = 2 });
            people.Add(new Person { FirstName = "Joe", LastName = "Paul", Id = 3 });
            people.Add(new Person { FirstName = "Merry", LastName = "Moses", Id = 4 });
            people.Add(new Person { FirstName = "James", LastName = "Gabriel", Id = 5 });
        }
        /// <summary>
        /// Get list of people
        /// </summary>
        /// <returns></returns>

        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        
        }
        // GET: api/People
        public List<Person> Get() 
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault(); 
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
