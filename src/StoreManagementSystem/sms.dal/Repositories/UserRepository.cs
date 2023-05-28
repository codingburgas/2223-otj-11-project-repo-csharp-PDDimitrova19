using sms.dal.Data;
using sms.dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.dal.Repositories
{
    public class UserRepository
    {
        //Connection with database
        private readonly StoreManagementSystemContext context;
        public UserRepository(StoreManagementSystemContext _context)
        {
            context = _context;
        }

        //Method which gets all users from database
        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }

        //Method which add a row in database
        public void UserRegistration (User user)
        {
            if(user !=null)
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        //Method whichc updates a row in database
        public void UserEdit(User user)
        {
            if (user != null)
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }

        //Method which removes a row in database
        public void UserDelete(User user)
        {
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
    }
}
