using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Data;
namespace WebApi.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        Data.UserDataStore store = new UserDataStore();
        // GET api/values
        public IEnumerable<User> Get()
        {
            // return new string[] { "value1", "value2" };
            return store.GetUsers();           
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public User Post(List<string> val)
        {
            try
            {
   
                User user = new Data.User();
                user.UserName = val[0];
                user.Password = val[1];
                user.FirstName = val[2];
                user.LastName = val[3];
                user.DateOfBirth = Convert.ToDateTime(val[4]);
                store.CreateUser(user);
                return user;
                //Person obj = new Person();
                //obj.Name = val[0];
                //obj.Address = val[1];
                //obj.DOB = Convert.ToDateTime(val[2]);
                //db.Persons.Add(obj);
                //db.SaveChanges();
            }
            catch (Exception) {
                return null;
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
