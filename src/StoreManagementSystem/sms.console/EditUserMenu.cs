﻿using Microsoft.IdentityModel.Tokens;
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
    internal class EditUserMenu
    {
        public static void Print()
        {
            Console.Clear();
            Console.WriteLine("      ╔═╗┌┬┐┬┌┬┐  ╔╦╗┌─┐┌┐┌┬ ┬");
            Console.WriteLine(" -----║╣  │││ │   ║║║├┤ ││││ │-----");
            Console.WriteLine("|     ╚═╝─┴┘┴ ┴   ╩ ╩└─┘┘└┘└─┘     |");
            Console.WriteLine("|                                  |");
            
            Console.Write("\n      Old Username: ");
            string oldUsername = GetOldUsername();

            Console.Write("\n      New Username: ");
            string newUsername = GetNewUsername();

            Console.Write("\n      New Password: ");
            string newPassword = GetNewPassword();

            Console.Write("\n\n    New First Name: ");
            string newFirstName = Console.ReadLine();

            Console.Write("\n     New Last Name: ");
            string newLastName = Console.ReadLine();

            Console.Write("\n         New Email: ");
            string newEmail = Console.ReadLine();

            UserService.EditUser(oldUsername, newUsername, newPassword, newFirstName, newLastName, newEmail);

            Console.WriteLine();
            Console.WriteLine("\n\n         ---User Edited---");
            Console.ReadKey(true);
            StartMenu.Print();
        }

        private static string GetOldUsername()
        {
            string username = Console.ReadLine();

            if (username.IsNullOrEmpty())
            {
                Console.WriteLine();
                Console.WriteLine("\n    ---Please insert Username---");
                Console.ReadKey();
                Print();
            }

            User? user = UserService.GetUserByUsername(username);
            if (user == null)
            {
                Console.WriteLine();
                Console.WriteLine("\n    ---Username doesn't exist---");
                Console.ReadKey();
                Print();
            }
            return username;
        }

        private static string GetNewUsername()
        {
            string username = Console.ReadLine();

            if (username.IsNullOrEmpty())
            {
                Console.WriteLine();
                Console.WriteLine("\n    ---Please insert Username---");
                Console.ReadKey();
                Print();
            }

            User? user = UserService.GetUserByUsername(username);
            if (user != null)
            {
                Console.WriteLine();
                Console.WriteLine("\n---This Username is already taken---");
                Console.ReadKey();
                Print();
            }
            return username;
        }

        private static string GetNewPassword()
        {
            string password = Console.ReadLine();

            if (password.IsNullOrEmpty())
            {
                Console.WriteLine();
                Console.WriteLine("\n    ---Please insert Password---");
                Console.ReadKey();
                Print();
            }

            if (password.Length < 4 || password.Length > 12)
            {
                Console.WriteLine();
                Console.WriteLine("\n-Password must be between 4 and 12 characters-");
                Console.ReadKey();
                Print();
            }

            return password;
        }
    }
}
