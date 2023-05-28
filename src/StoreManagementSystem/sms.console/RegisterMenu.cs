using Microsoft.IdentityModel.Tokens;
using sms.bll;
using sms.dal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.console
{
    internal class RegisterMenu
    {
        public static void Print()
        {
            Console.Clear();

            Console.Write("Register Menu\n");

            Console.Write("First Name: ");
            string firstName = Console.ReadLine(); ;

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine(); ;

            Console.Write("Username: ");
            string username = GetUsername();

            Console.Write("Email Address: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = GetPassword();

            UserService.RegisterUser(firstName, lastName, username, email, password);

            Console.WriteLine("User Registered");
            Console.ReadKey(true);
            StartMenu.Print();
        }

        public static void PrintUsernameAndPassword()
        {
            Console.Write("Username: \n");
            string username = GetUsername();

            Console.Write("Password: \n");
            string password = GetPassword();
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
