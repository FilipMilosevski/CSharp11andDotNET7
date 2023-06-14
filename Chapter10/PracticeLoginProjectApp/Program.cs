
//create
using System.Text.RegularExpressions;

//Console.WriteLine("Enter username");
//string createUsername = Console.ReadLine();

//Console.WriteLine("Enter password");
//string createPassword = Console.ReadLine();

//Console.WriteLine("Confirm password");
//string confirmPassword = Console.ReadLine();


bool isLoginCorrect = false;
do
{
    //login
    Console.WriteLine("Enter username");
    string username = Console.ReadLine();

    Console.WriteLine("Enter password");
    string password = Console.ReadLine();

    if (isUsernameAllowed(username) && isPasswordAllowed(password))
    {
        isLoginCorrect = true;
    }
    else
    {
        if (isUsernameAllowed(username))
        {
            Console.WriteLine("Username is incorrect");
        }
        if (isPasswordAllowed(password))
        {
            Console.WriteLine("Password is incorrect");
        }
    }
        
} while (!isLoginCorrect);

bool isPasswordAllowed(string? password)
{
    Regex regx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
    if (regx.IsMatch(password) && !String.IsNullOrEmpty(password))
    {
        return true;
    }
    return false;
}

bool isUsernameAllowed(string? username)
{
    Regex regx = new Regex(@"^(?=[A-Za-z0-9])(?!.*[._()\[\]-]{2})[A-Za-z0-9._()\[\]-]{3,15}$");

    if (regx.IsMatch(username) && !String.IsNullOrEmpty(username))
    {
        return true;
    }
    return false;
}