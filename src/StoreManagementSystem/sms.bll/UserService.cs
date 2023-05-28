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

        public static bool LoginUser(string username, string password)
        {
            using (var context = new StoreManagementSystemContext())
            {
                UserRepository userRepository = new(context);

                User user = GetUserByUsername(username);

                if (user != null)
                {
                    string hashedPassword = HashPassword(password);
                    if (user.Password == hashedPassword)
                    {
                        return true;
                    }
                }
                return false;
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

        public static void EditUser(string oldUsername, string newUsername, string newPassword, string newFirstName, string newLastName, string newEmail)
        {
            using (var context = new StoreManagementSystemContext())
            {
                UserRepository userRepository = new(context);

                User user = GetUserByUsername(oldUsername);

                if (user != null)
                {
                    user.Username = newUsername;
                    string hashedPassword = HashPassword(newPassword);
                    user.Password = hashedPassword;
                    user.FirstName = newFirstName; 
                    user.LastName = newLastName;
                    user.EmailAddress = newEmail;

                    userRepository.UserEdit(user);
                }
            }
        }

        public static void DeleteUser(string username, string password)
        {
            using (var context = new StoreManagementSystemContext())
            {
                UserRepository userRepository = new(context);

                User user = GetUserByUsername(username);

                if (user != null)
                {
                    string hashedPassword = HashPassword(password);
                    if (user.Password == hashedPassword)
                    {
                        userRepository.UserDelete(user);
                    }
                }
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
