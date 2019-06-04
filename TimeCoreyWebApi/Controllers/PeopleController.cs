using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimeCoreyWebApi.Models;

namespace TimeCoreyWebApi.Controllers
{
    /// <summary>
    /// This is where I give you all the info about my peeps
    /// </summary>
    public class PeopleController : ApiController
    {
        private List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Ameet", LastName = "Jayawant", Id = 1 });
            people.Add(new Person { FirstName = "James", LastName = "Jayawant", Id = 2 });
            people.Add(new Person { FirstName = "Logan", LastName = "Jayawant", Id = 3 });
        }
        // GET: api/People
        public IEnumerable<Person> Get()
        {
            return people;
        }

        /// <summary>
        /// Gets a list of the first names of all users
        /// </summary>
        /// <param name="userId">The unique identifier for this person</param>
        /// <param name="age">We want to know how old they are</param>
        /// <returns>A list of first names</returns>
        [HttpGet]
        [Route("api/people/GetFirstNames/{userId:int}/{age:int}")]
        public List<string> GetFirstNames(int userId, int age)
        {
            
            List<string> output = new List<string>();

            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }

            return output;
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
            var person = people.Where(p => p.Id == id).FirstOrDefault();

            people.Remove(person);
        }
    }
}
