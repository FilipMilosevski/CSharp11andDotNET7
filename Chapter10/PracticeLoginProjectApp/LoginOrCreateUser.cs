using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeLoginProjectApp
{
    internal static class LoginOrCreateUser
    {
        private static string _username;
        private static string _password;

        public static void Login()
        {

        }
        public static void Create()
        {

        }
        #region Helpers
        private static bool isPasswordAllowed(string? password)
        {
            Regex regx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            if (regx.IsMatch(password) && !String.IsNullOrEmpty(password))
            {
                return true;
            }
            return false;
        }

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
