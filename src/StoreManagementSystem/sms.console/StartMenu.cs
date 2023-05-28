using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.console
{
    public class StartMenu
    {
        public static void Print()
        {
            bool exit = false;
            int currentOption = 1;
            int totalOptions = 5;
            int i = 1;

            Console.CursorVisible = false; // Hide the cursor

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Store Management System");
                Console.WriteLine();

                // Display the menu options with arrow indicator
                for (i = 1; i <= totalOptions; i++)
                {
                    Console.SetCursorPosition(0, Console.CursorTop); // Move cursor to the beginning of the line

                    if (currentOption == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("=> ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("   ");
                    }

                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Login User");
                            break;
                        case 2:
                            Console.WriteLine("Register User");
                            break;
                        case 3:
                            Console.WriteLine("Edit User");
                            break;
                        case 4:
                            Console.WriteLine("Delete User");
                            break;
                        case 5:
                            Console.WriteLine("Exit");
                            break;
                    }
                }

                Console.ResetColor();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        currentOption = (currentOption == 1) ? totalOptions : currentOption - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        currentOption = (currentOption == totalOptions) ? 1 : currentOption + 1;
                        break;
                    case ConsoleKey.Enter:
                        ExecuteOption(currentOption);
                        break;
                }
            }

            Console.CursorVisible = true; // Show the cursor
        }

        static void ExecuteOption(int option)
        {
            Console.Clear();
            switch (option)
            {
                case 1:
                    LoginMenu.Print();
                    break;
                case 2:
                    RegisterMenu.Print();
                    break;
                case 3:
                    EditUserMenu.Print();
                    break;
                case 4:
                    DeleteUserMenu.Print();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
