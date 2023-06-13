
//Create account
using LoginProject;
using System.Text.RegularExpressions;


SeedToLoginDB db = new SeedToLoginDB();

db.Seed();

LoginOrCreateUser.Login();

//LoginOrCreateUser.Create();


