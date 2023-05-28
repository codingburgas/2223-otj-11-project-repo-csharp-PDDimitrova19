using System;
using sms.dal.Data;
using sms.dal.Models;
using sms.dal.Repositories;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.bll
{
    public class UserService
    {
        public static User? GetUserByUsername(string username)
        {
            using (var context = new StoreManagementSystemContext())
            {
                UserRepository userRepository = new(context);

                User? user = userRepository.GetUsers().FirstOrDefault(u => u.Username == username);

                return user;
            }
        }

        public static void RegisterUser(string firstName, string lastName, string username, string email, string password)
        {
            using (var context = new StoreManagementSystemContext())
            {
                UserRepository userRepository = new(context);

                User user = new User()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Username = username,
                    EmailAddress = email,
                    Password = HashPassword(password)
                };

                userRepository.UserRegistration(user);
            }
        }

        public static string HashPassword(string password)
        {
            SHA256 hash = SHA256.Create();

            byte[] passBytes = Encoding.Default.GetBytes(password);

            string hashedPass = Convert.ToHexString(hash.ComputeHash(passBytes));

            return hashedPass;
        }
    }
}
