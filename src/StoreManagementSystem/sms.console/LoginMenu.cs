using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.console
{
    public class LoginMenu
    {
        public static void Print()
        {
            Console.Clear();

            Console.WriteLine("Login Menu\n");

            Console.Write("Username: ");

            string username = GetUsername();

            Console.Write("\nPassword: ");

            string password = GetPassword();
            
        }

        private static string GetUsername()
        {
            string username = Console.ReadLine();

            return username;
        }

        private static string GetPassword()
        {
            string password = Console.ReadLine();

            return password;
        }
    }
}
