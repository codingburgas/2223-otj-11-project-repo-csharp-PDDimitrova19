using System;
using System.Collections.Generic;
using sms.bll;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace sms.console
{
    public class LoginMenu
    {
        public static void Print()
        {
            Console.Clear();

            Console.WriteLine("Login Menu");

            Console.WriteLine("Username: ");

            string username = GetUsername();

            Console.WriteLine("Password: ");

            string password = GetPassword();

            if (!UserService.LoginUser(username, password))
            {
                Console.WriteLine();
                Console.Write("Wrong Username or Password");
                Console.ReadKey();
                Print();
            }

            Console.WriteLine();
            Console.Write("User Logged In");
            Console.ReadKey(true);
            StartMenu.Print();
        }

        private static string GetUsername()
        {
            string username = Console.ReadLine();

            //Check if username is null or empty
            //if (username.IsNullOrEmpty())
            //{
            //    Console.WriteLine();
            //    Console.Write("Username must be inputed");
            //    Console.ReadKey();
            //    PrintUsernameAndPassword();
            //}

            //User? user = UserService.GetUserByUsername(username);

            //if (user != null)
            //{
            //    Console.WriteLine();
            //    Console.Write("Username already taken");
            //    Console.ReadKey();
            //    PrintUsernameAndPassword();
            //}
            return username;
        }

        private static string GetPassword()
        {
            string password = Console.ReadLine();

            //if (password.IsNullOrEmpty())
            //{
            //    Console.WriteLine();
            //    Console.Write("Password must be inputed");
            //    Console.ReadKey();
            //    PrintUsernameAndPassword();
            //}

            //if (password.Length < 4 || password.Length > 12)
            //{
            //    Console.WriteLine();
            //    Console.Write("Password must be between 4 and 12 characters");
            //    Console.ReadKey();
            //    PrintUsernameAndPassword();
            //}
            return password;
        }
    }
}
