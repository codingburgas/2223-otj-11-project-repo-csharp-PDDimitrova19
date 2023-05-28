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

            Console.WriteLine("Login Menu\n");

            Console.Write("Username: ");

            //string username = GetUsername();

            Console.Write("\nPassword: ");

            //string password = GetPassword();
        }
    }
}
