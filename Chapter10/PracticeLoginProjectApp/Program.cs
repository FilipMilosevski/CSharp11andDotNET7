
//create
using PracticeLoginProjectApp;
using System.Text.RegularExpressions;


SeedToLoginDB db = new SeedToLoginDB();

db.Seed();

LoginOrCreateUser.Login();

//LoginOrCreateUser.Create();
