﻿
//Create account
using LoginProject;


SeedToLoginDB db = new SeedToLoginDB();

db.Seed();

LoginOrCreateUser.Login();

//LoginOrCreateUser.Create();

Console.WriteLine("Filip");
Console.WriteLine("Practice");