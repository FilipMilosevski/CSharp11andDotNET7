﻿using LoginProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text.RegularExpressions;

namespace LoginProject
{
    internal static class LoginOrCreateUser
    {
        private static string _username;
        private static string _password;
        private static string _confirmPassword;
        private static bool _isCorrect;
        private static int _role;

        /// <summary>
        /// User login method.
        /// </summary>
        public static void Login()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Login User: ");
            Console.WriteLine("==============================");

            _isCorrect = false;

            do
            {
                Console.WriteLine("Enter username");
                _username = Console.ReadLine();

                Console.WriteLine("Enter password");
                _password = Console.ReadLine();

                if (isUsernameAllowed(_username) && isPasswordAllowed(_password))
                {
                    User loggedInUser;
                    using (LoginContext context = new LoginContext())
                    {
                        loggedInUser = context.users.Where(u => u.Username == _username && u.Password == _password).Include(u => u.Role).FirstOrDefault();
                    }
                    if (loggedInUser != null)
                    {
                        Console.WriteLine($"Welcome {loggedInUser.Username}! you are {loggedInUser.Role.RoleName}");
                    }
                    else
                    {
                        Create();
                    }
                    _isCorrect = true;

                }
                else
                {
                    if (!isUsernameAllowed(_username))
                    {
                        Console.WriteLine("Username is incorect!");
                    }
                    if (!isPasswordAllowed(_password))
                    {
                        Console.WriteLine("Password is incorect!");
                    }
                }
            } while (!_isCorrect);
        }

        /// <summary>
        /// Creates user.
        /// </summary>
        public static void Create()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Create User: ");
            Console.WriteLine("==============================");

            _isCorrect = false;

            do
            {
                Console.WriteLine("Enter username");
                _username = Console.ReadLine();

                Console.WriteLine("Enter password");
                _password = Console.ReadLine();

                Console.WriteLine("Confirm password");
                _confirmPassword = Console.ReadLine();

                Console.WriteLine("Select role:  example(Guest = 2, VIP = 3, Regular = 4");
                _role = Convert.ToInt32(Console.ReadLine());

                if (isUsernameAllowed(_username) && isPasswordAllowed(_password) && _password == _confirmPassword)
                {
                    User createUser;
                   using(LoginContext context = new LoginContext())
                    {
                        createUser = context.users.FirstOrDefault(cu => cu.Username == _username);
                        if (createUser == null)
                        {
                            Role role = context.roles.FirstOrDefault(r => r.RoleName == (RoleName)_role); 
                            if(role == null)
                            {
                                role = context.roles.FirstOrDefault(r => r.RoleName == (RoleName)2);
                            }
                            context.users.Add(new User() { Username = _username, Password = _password, Role = role});
                            int changes = context.SaveChanges();

                            if(changes > 0)
                            {
                                Login();
                            }
                        }
                    }
                    _isCorrect = true;
                }
                else
                {
                    if (!isUsernameAllowed(_username))
                    {
                        Console.WriteLine("Username is incorect!");
                    }
                    if (!isPasswordAllowed(_password))
                    {
                        Console.WriteLine("Password is incorect!");
                    }
                    if (_password != _confirmPassword)
                    {
                        Console.WriteLine("Passwords are not the same!");
                    }
                }
            } while (!_isCorrect);
        }

        #region Helpers 

        /// <summary>
        /// Determines whether [is password allowed] [the specified password].
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns>
        ///   <c>true</c> if [is password allowed] [the specified password]; otherwise, <c>false</c>.
        /// </returns>
        private static bool isPasswordAllowed(string? password)
        {
            Regex regx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");

            if (regx.IsMatch(password) && !String.IsNullOrEmpty(password))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether [is username allowed] [the specified username].
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>
        ///   <c>true</c> if [is username allowed] [the specified username]; otherwise, <c>false</c>.
        /// </returns>
        private static bool isUsernameAllowed(string? username)
        {
            Regex regx = new Regex(@"^(?=[A-Za-z0-9])(?!.*[._()\[\]-]{2})[A-Za-z0-9._()\[\]-]{3,15}$");

            if (regx.IsMatch(username) && !String.IsNullOrEmpty(username))
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
