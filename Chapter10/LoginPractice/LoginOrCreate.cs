using LoginPractice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace LoginPractice
{
    public static class LoginOrCreate
    {
        private static string _username;
        private static string _password;
        private static bool _isLoginCorrect;
        private static string _confirmPassword;
        private static bool _isCorrect;
        private static int _role;

        /// <summary>
        /// Login User Method
        /// </summary>
        public static void Login()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Login USER");
            Console.WriteLine("---------------------------");
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
                    User loggedInUser;
                    using (LoginContext context = new LoginContext())
                    {
                       loggedInUser = context.users.Where(u => u.Username == _username && u.Password == _password).Include(u => u.Role).FirstOrDefault();
                    }
                    if (loggedInUser != null)
                    {
                        Console.WriteLine($"Welcome {loggedInUser.Username} you are {loggedInUser.Role.RoleName} !");
                        ChooseAction(loggedInUser.Role.RoleName , loggedInUser.ID);


                    }
                    else
                    {

                        Create();
                    
                    }
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
            Console.WriteLine("---------------------------");
            Console.WriteLine("Create USER");
            Console.WriteLine("---------------------------");

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

                Console.WriteLine("SELECT ROLE (Guest= 2, VIP= 3, Regular =4)");
                _role = Convert.ToInt32(Console.ReadLine());

                if (isUsernameAllowed(_username) && isPasswordAllowed(_password) && _password == _confirmPassword)
                {
                    User createUser;
                    using(LoginContext context = new LoginContext())
                    {
                        createUser = context.users.FirstOrDefault(cu => cu.Username == _username);
                       if(createUser == null)
                        {
                            Role role = context.roles.FirstOrDefault(r => r.RoleName == (RoleName)_role);
                            if(role == null)
                            {
                                role = context.roles.FirstOrDefault(r => r.RoleName == (RoleName)2);
                            }
                            context.users.Add(new User() { Username = _username, Password = _password, Role = role });
                            int  changes = context.SaveChanges();
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
        private static void ChooseAction(RoleName roleName , Guid userId)
        {
            int action = 0;
            switch (roleName)
            {
                case RoleName.Admin:
                    {

                        Console.WriteLine("Available actions:  1.List Users, 2.Delete User, 3.Edit, 4.Exit");
                        Console.WriteLine("Example (1)");
                        try
                        {
                            action = Convert.ToInt32(Console.ReadLine());
                            ActionLoader(action, roleName, userId);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("       ===       EXCEPTION       ===");
                            Console.WriteLine(ex.ToString());
                            ChooseAction(roleName , userId);
                        }
                    }
                    break;

               
                case RoleName.Vip:
                    {

                        Console.WriteLine("Available actions:  2.Delete User, 3.Edit, 4.Exit ");
                        Console.WriteLine("Example (2)");
                        try
                        {
                            action = Convert.ToInt32(Console.ReadLine());
                            ActionLoader(action, roleName, userId);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("       ===       EXCEPTION       ===");
                            Console.WriteLine(ex.ToString());
                            ChooseAction(roleName, userId);
                        }
                    }
                    break;
                case RoleName.Regular:
                case RoleName.Guest:
                    {
                        Console.WriteLine("Available actions:  2.Delete User, 4.Exit ");
                        Console.WriteLine("Example (2)");
                        try
                        {
                            action = Convert.ToInt32(Console.ReadLine());
                            ActionLoader(action, roleName, userId);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("       ===       EXCEPTION       ===");
                            Console.WriteLine(ex.ToString());
                            ChooseAction(roleName, userId);
                        }
                    }
                    break;
                default:
                    break;

            }
        }

        private static void ActionLoader(int action, RoleName roleName, Guid userId)
        {
            switch(action)
            {
                case 1:
                    {
                            using(LoginContext context = new LoginContext())
                        {
                            List<User> users = context.users.Include(u => u.Role).ToList();
                            if(users == null)
                            {
                                Console.WriteLine("No users found");
                            }
                            else
                            {
                                Console.WriteLine("| {0,5} | {1,15} | {2,10} |","Nr.", "Username","Role" );
                            }
                            foreach (User user in users)
                            {
                                Console.WriteLine("----------------------------------------");
                                Console.WriteLine("| {0,5} | {1,15} | {2,10} |", users.IndexOf(user) + 1, user.Username, user.Role.RoleName);
                              
                            }
                        }
 
                    }
                    break;
                case 2:
                    {
                        if(roleName == RoleName.Admin)
                        {
                            Console.WriteLine("Enter the username you want to delete ?");
                            string username = Console.ReadLine();
                            User user = null;
                            using(LoginContext context = new LoginContext())
                            {
                                user = context.users.FirstOrDefault(user => user.Username == username);
                                if (user == null)
                                {
                                    Console.WriteLine("User doesn't exist! ");
                                }
                                else
                                {
                                    context.users.Remove(user);
                                    int changes =context.SaveChanges();
                                    if(changes > 0)
                                    {
                                        Console.WriteLine("The user "+ user.Username + " is deleted!");
                                        Console.WriteLine();
                                    }
                                }
                            }
                            ChooseAction(roleName, userId);

                        }

                        else
                        {
                            User user = null;
                            using (LoginContext context = new LoginContext())
                            {
                                user = context.users.FirstOrDefault(user => user.ID == userId);
                                if (user == null)
                                {
                                    Console.WriteLine("User doesn't exist! ");
                                }
                                else
                                {
                                    context.users.Remove(user);
                                    int changes = context.SaveChanges();
                                    if (changes > 0)
                                    {
                                        Console.WriteLine("The user " + user.Username + " is deleted!");
                                        Console.WriteLine();
                                    }
                                }
                            }
                            Login();
                        }
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Choose option:  1.Change Username,   2.Change Password, 3.Cancel");
                        try
                        {
                            int option = Convert.ToInt32(Console.ReadLine());
                            switch(option)
                            {
                                case 1:
                                    {
                                        User user = null;
                                        using(LoginContext context = new LoginContext())
                                        {
                                            user = context.users.FirstOrDefault(u => u.ID == userId);
                                            if(user == null)
                                            {
                                                Console.WriteLine("User with this ID doesn't exist!");
                                            }
                                            else
                                            {
                                                Console.Write("Enter your new Username: ");
                                                string newUserName = Console.ReadLine();
                                                if (isUsernameAllowed(newUserName))
                                                {
                                                    user.Username = newUserName;
                                                    context.users.Update(user);
                                                    int changes = context.SaveChanges();
                                                    if (changes > 0)

                                                        Console.WriteLine("Your username is " + newUserName);
                                                    else
                                                        Console.WriteLine("Username didn't change");
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        User user = null;
                                        using (LoginContext context = new LoginContext())
                                        {
                                            user = context.users.FirstOrDefault(u => u.ID == userId);
                                            if (user == null)
                                            {
                                                Console.WriteLine("User with this ID doesn't exist!");
                                            }
                                            else
                                            {
                                                Console.Write("Enter your new Password: ");
                                                string newPassword = Console.ReadLine();

                                                Console.Write("Confirm your new Password: ");
                                                string confirmNewPassword = Console.ReadLine();
                                                if (isPasswordAllowed(newPassword) && newPassword == confirmNewPassword)
                                                {
                                                    user.Password = newPassword;
                                                    context.users.Update(user);
                                                    int changes = context.SaveChanges();
                                                    if (changes > 0)

                                                        Console.WriteLine("You change the password successfully:");
                                                    else
                                                        Console.WriteLine("Password didn't change");
                                                }
                                                else if (!isPasswordAllowed(newPassword))
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Password is not allowed");
                                                    ActionLoader(3, roleName, userId);
                                                }
                                                else if (newPassword != confirmNewPassword)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Password didn't match");
                                                    ActionLoader(3, roleName, userId);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                            ChooseAction(roleName, userId);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("You selected wrong option");
                            ActionLoader(3, roleName, userId);
                        }
                    }
                    break;
                default:
                    break;
            }
        }


        #endregion
    }
}
