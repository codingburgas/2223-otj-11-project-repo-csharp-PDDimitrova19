using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.console
{
    internal class LoginMenu
    {
        //private readonly string connectionString;

        //public Login(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}

        //public bool Authenticate(string username, string password)
        //{
        //    using (var connection = new SqlConnection(connectionString))
        //    {
        //        var command = new SqlCommand("SELECT COUNT(*) FROM users WHERE username = @username AND password = @password");
        //        command.Parameters.AddWithValue("@username", username);
        //        command.Parameters.AddWithValue("@password", password);

        //        connection.Open();
        //        var result = (int)command.ExecuteScalar();

        //        return result == 1;
        //    }
        //}

        public void Print()
        {
            Console.Clear();
            Console.WriteLine("You are in the Login form");
            Console.WriteLine("[B] Go Back   [E] Exit");

            while (true)
            {
                var input = char.ToUpper(Console.ReadKey().KeyChar);

                switch (input)
                {
                    case 'B':
                        StartProgram startProgram = new StartProgram();
                        StartProgram.Print(); break;
                    case 'E': Environment.Exit(0); break;
                    default: break;
                }
            }
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    var loginMenu = new LoginMenu();
        //    loginMenu.Print();
        //}
    }
}
