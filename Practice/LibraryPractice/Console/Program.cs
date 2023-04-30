using static System.Console;

using System;
using ConsoleApp.Library;



Person FM29 = new Person()
{
    Fname = "Filip",
    Lname = "Milosevski",
    Id = 29
};
Person MA25 = new Person("Martin", "Atanasovski", 25);

WriteLine(FM29.Fname);
WriteLine(MA25.Fname);