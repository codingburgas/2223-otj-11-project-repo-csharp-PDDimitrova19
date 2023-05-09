using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.console
{
    internal class RegisterMenu
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine("You are in the Register form");
            Console.WriteLine("[B] Go Back   [E] Exit");

            while (true)
            {
                var input = char.ToUpper(Console.ReadKey().KeyChar);

                switch (input)
                {
                    case 'B':
                        StartProgram startProgram = new StartProgram();
                        StartProgram.Print(); break;
                    case 'E': 
                        Environment.Exit(0); break;
                    default: break;
                }
            }
        }
    }
}
