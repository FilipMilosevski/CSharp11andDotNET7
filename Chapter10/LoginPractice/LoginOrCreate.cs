using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoginPractice
{
    public static class LoginOrCreate
    {
        private static string _username;
        private static string _password;
        private static bool _isLoginCorrect;
        private static string _confirmPassword;
        private static bool _isCorrect;


        /// <summary>
        /// Login User Method
        /// </summary>
        public static void Login()
        {
            _isLoginCorrect = false;
            do
            {
                //login
                Console.WriteLine("ENTER USERNAME");
                 _username = Console.ReadLine();

                Console.WriteLine("ENTER PASSWORD");
                _password = Console.ReadLine();

                if (isUsernameAllowed(_username) && isPasswordAllowed(_password))
                {
                    _isLoginCorrect = true;
                }
                else
                {
                    if (!isUsernameAllowed(_username))
                    {
                        Console.WriteLine("Username is incorrect!");
                    }
                    if (!isPasswordAllowed(_password))
                    {
                        Console.WriteLine("Password is incorrect!");
                    }
                }


            } while (!_isLoginCorrect);

        }
        /// <summary>
        /// Create user Method
        /// </summary>
        public static void Create()
        {
            _isCorrect = false;
            do
            {
                //login
                Console.WriteLine("ENTER USERNAME");
                _username = Console.ReadLine();

                Console.WriteLine("ENTER PASSWORD");
                _password = Console.ReadLine();

                Console.WriteLine("CONFIRM PASSWORD");
                _confirmPassword = Console.ReadLine();

                if (isUsernameAllowed(_username) && isPasswordAllowed(_password) && _password == _confirmPassword)
                {
                    _isCorrect = true;
                }
                else
                {
                    if (!isUsernameAllowed(_username))
                    {
                        Console.WriteLine("Username is incorrect!");
                    }
                    if (!isPasswordAllowed(_password))
                    {
                        Console.WriteLine("Password is incorrect!");
                    }
                    if (_password != _confirmPassword)
                    {
                        Console.WriteLine("Passwords are not the same!");
                    }
                }


            } while (!_isCorrect);

        }

        #region Help Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
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
