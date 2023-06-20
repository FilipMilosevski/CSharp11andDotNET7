
using LoginPractice;
using System.Text.RegularExpressions;


SeedLoginDb sedlog = new SeedLoginDb();
sedlog.Seed();

LoginOrCreate.Login();
LoginOrCreate.Create();