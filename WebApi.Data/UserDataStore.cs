using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Data
{
    public class UserDataStore
    {
        private UserDBContext _context = new UserDBContext();

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
            //return new string[] { "value1", "value2" };
        }
            
        public bool CreateUser(User user)
        {
            bool retVal = true;
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                retVal = true;
            }
            catch(Exception ex)
            {
                retVal = false;
            }
            return retVal; 
        }
        
    }
}
