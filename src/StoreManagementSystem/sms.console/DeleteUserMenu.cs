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
            Console.WriteLine("      ╔╦╗┌─┐┬  ┌─┐┌┬┐┌─┐  ╔╦╗┌─┐┌┐┌┬ ┬");
            Console.WriteLine(" ----- ║║├┤ │  ├┤  │ ├┤   ║║║├┤ ││││ │-----");
            Console.WriteLine("|     ═╩╝└─┘┴─┘└─┘ ┴ └─┘  ╩ ╩└─┘┘└┘└─┘     |");
            Console.WriteLine("|                                          |");

            Console.Write("             Username: ");
            string username = GetUsername();
            Console.Write("\n             Password: ");
            string password = GetPassword();

            if (!UserService.LoginUser(username, password))
            {
                Console.WriteLine();
                Console.Write("\n      ---Wrong Username or Password---");
                Console.ReadKey();
                Print();
            }

            UserService.DeleteUser(username, password);

            Console.WriteLine();
            Console.Write("\n            ---User Deleted---");
            Console.ReadKey(true);
            StartMenu.Print();
        }

        private static string GetUsername()
        {
            string username = Console.ReadLine();

            if (username.IsNullOrEmpty())
            {
                Console.WriteLine();
                Console.WriteLine("\n        ---Please insert Username---");
                Console.ReadKey();
                Print();
            }

            return username;
        }

        private static string GetPassword()
        {
            string password = Console.ReadLine();

            if (password.IsNullOrEmpty())
            {
                Console.WriteLine();
                Console.WriteLine("\n        ---Please insert Password---");
                Console.ReadKey();
                Print();
            }

            return password;
        }
    }
}
