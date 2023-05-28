using Microsoft.IdentityModel.Tokens;
using sms.bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.console
{
    internal class DeleteUserMenu
    {
        public static void Print()
        {
            Console.Clear();
            Console.Write("Delete User Menu\n");

            Console.Write("Username: ");
            string username = GetUsername();
            Console.Write("Password: ");
            string password = GetPassword();

            if (!UserService.LoginUser(username, password))
            {
                Console.WriteLine();
                Console.Write("Wrong Username or Password");
                Console.ReadKey();
                Print();
            }

            UserService.DeleteUser(username, password);

            Console.WriteLine();
            Console.Write("User Deleted");
            Console.ReadKey(true);
            StartMenu.Print();
        }

        private static string GetUsername()
        {
            string username = Console.ReadLine();

            //if (username.IsNullOrEmpty())
            //{
            //    Console.WriteLine();
            //    Write.LineToCenter("Username must be inputed");
            //    Console.ReadKey();
            //    Print();
            //}

            return username;
        }

        private static string GetPassword()
        {
            string password = Console.ReadLine();

            //if (password.IsNullOrEmpty())
            //{
            //    Console.WriteLine();
            //    Write.LineToCenter("Password must be inputed");
            //    Console.ReadKey();
            //    Print();
            //}

            return password;
        }
    }
}
