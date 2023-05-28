using System;
using System.Collections.Generic;
using sms.bll;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using sms.dal.Models;

namespace sms.console
{
    public class LoginMenu
    {
        public static void Print()
        {
            Console.Clear();


            Console.WriteLine("      ╦  ┌─┐┌─┐┬┌┐┌  ╔╦╗┌─┐┌┐┌┬ ┬");
            Console.WriteLine(" -----║  │ ││ ┬││││  ║║║├┤ ││││ │-----");
            Console.WriteLine("|     ╩═╝└─┘└─┘┴┘└┘  ╩ ╩└─┘┘└┘└─┘     |");
            Console.WriteLine("|                                     |");

            Console.Write("          Username: ");

            string username = GetUsername();

            Console.Write("\n          Password: ");

            string password = GetPassword();

            if (!UserService.LoginUser(username, password))
            {
                Console.WriteLine();
                Console.WriteLine("\n    ---Wrong Username or Password---");
                Console.ReadKey();
                Print();
            }

            Console.WriteLine();
            Console.Write("\n         ---User Logged In---");
            Console.ReadKey(true);
            StartMenu.Print();
        }

        private static string GetUsername()
        {
            string username = Console.ReadLine();

            if (username.IsNullOrEmpty())
            {
                Console.WriteLine();
                Console.WriteLine("\n      ---Please insert Username---");
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
                Console.WriteLine("\n      ---Please insert Passsword---");
                Console.ReadKey();
                Print();
            }

            return password;
        }
    }
}
