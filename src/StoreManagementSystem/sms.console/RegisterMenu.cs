using sms.bll;
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
            Console.Write("Username: \n");
            //string username = GetUsername()
            Console.Write("Email Address: ");
            string email = Console.ReadLine(); ;
            Console.Write("Password: \n");
            //string password = GetPassword();
        }
    }
}
