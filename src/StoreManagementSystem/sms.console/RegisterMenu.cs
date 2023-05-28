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

            Console.Write("Email Address: ");
            string email = Console.ReadLine();

            Console.Write("Username: ");
            string username = GetUsername(firstName, lastName, email);

            Console.Write("Password: ");
            string password = GetPassword(firstName, lastName, username, email);

            UserService.RegisterUser(firstName, lastName, username, email, password);

            Console.WriteLine("User Registered");
            Console.ReadKey(true);
            StartMenu.Print();
        }

        public static void PrintPassword(string firstName, string lastName, string username, string email)
        {
            Console.Write("New Password: ");
            string password = GetPassword(firstName, lastName, username, email);

            if (password.IsNullOrEmpty() || (password.Length < 4 || password.Length > 12))
            {
                GetPassword(firstName, lastName, username, email);
            }
            else
            {
                UserService.RegisterUser(firstName, lastName, username, email, password);
                Console.WriteLine("User Registered");
                Console.ReadKey(true);
                StartMenu.Print();
            }
        }

        public static void PrintUsernameAndPassword(string firstName, string lastName, string email)
        {
            Console.Write("New Username: ");
            string username = GetUsername(firstName, lastName, email);

            Console.Write("New Password: ");
            string password = GetPassword(firstName, lastName, username, email);

            User? user = UserService.GetUserByUsername(username);

            if(user == null) 
            {
                UserService.RegisterUser(firstName, lastName, username, email, password);
                Console.WriteLine("User Registered");
                Console.ReadKey(true);
                StartMenu.Print();
            }
            else
            {
                GetUsername(firstName, lastName, email);
            }

            if(password.IsNullOrEmpty() || (password.Length < 5 || password.Length > 12) )
            {
                GetPassword(firstName, lastName, username, email);
            }
            else
            {
                UserService.RegisterUser(firstName, lastName, username, email, password);
                Console.WriteLine("User Registered");
                Console.ReadKey(true);
                StartMenu.Print();
            }
            
        }

        private static string GetUsername(string firstName,string lastName, string email)
        {
            string username = Console.ReadLine();

            //Check if username is null or empty
            if (username.IsNullOrEmpty())
                {
                    Console.WriteLine();
                    Console.WriteLine("Please insert Username");
                    Console.ReadKey();
                    Console.Clear();
                    PrintUsernameAndPassword(firstName, lastName, email);
                }

            User? user = UserService.GetUserByUsername(username);

            if (user != null)
            {
                Console.WriteLine();
                Console.WriteLine("This Username is already taken");
                Console.ReadKey();
                Console.Clear();
                PrintUsernameAndPassword(firstName, lastName, email);
            }
            return username;
        }

        private static string GetPassword(string firstName, string lastName, string username, string email)
        {
            string password = Console.ReadLine();

            if (password.IsNullOrEmpty())
            {
                Console.WriteLine();
                Console.WriteLine("Please insert Password");
                Console.ReadKey();
                Console.Clear();
                PrintPassword(firstName, lastName, username, email);
            }

            if (password.Length < 4 || password.Length > 12)
            {
                Console.WriteLine();
                Console.WriteLine("Password must be between 4 and 12 characters");
                Console.ReadKey();
                Console.Clear();
                PrintPassword(firstName, lastName, username, email);
            }
            return password;
        }
    }
}
