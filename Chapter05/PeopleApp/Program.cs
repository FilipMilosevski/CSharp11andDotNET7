using Packt.Shared;
using System.Text;


Person bob = new Person();
///ili moze samo new() zatoa sto vekje sme go imenuvale;
WriteLine(bob.ToString());
WriteLine(bob);
bob.Name = "Bob Smith";

bob.DateOfBirth = new DateTime(1965, 12, 22);

Console.OutputEncoding = Encoding.UTF8;
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: bob.Name,
    arg1: bob.DateOfBirth);

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};
WriteLine(format: "{0} was born on {1:dd, MM yy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);


bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;


WriteLine(
    format: "{0} 's favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);


bob.Children.Add(new Person { Name = "Alfred" }); //c# 3.0 and later
bob.Children.Add(new() { Name = "Zoe" }); //c# 9.0 and later

WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($">{bob.Children[childIndex].Name}");
}



BankAccount.InterestRate = 0.012M;

BankAccount jonesAccount = new BankAccount();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} EARNED {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);


BankAccount gerrierAccount = new BankAccount();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);


BankAccount filAccount = new BankAccount();
filAccount.AccountName = "Mr. Filip";
filAccount.Balance = 103;
WriteLine(format: "{0} earned {1:C} interest",
    arg0: filAccount.AccountName,
    arg1: filAccount.Balance * BankAccount.InterestRate);

BankAccount ficAccount = new BankAccount();
ficAccount.AccountName = "Mr. Fico";
ficAccount.Balance = 53;
WriteLine(format: "{0} earned {1:C} interest",
    arg0: ficAccount.AccountName,
    arg1: ficAccount.Balance * BankAccount.InterestRate);

WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}");
ReadLine();
Person blankPerson = new();

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: bob.Name,
    arg1: bob.HomePlanet,
    arg2: bob.Instantiated);

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: gunny.Name, 
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());


(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));///overload
WriteLine(bob.OptionalParameters(command:"start"));
///optional gornovo moze da pratime i ne mora-()

WriteLine(bob.OptionalParameters(number: 32, command: "hiiii"));
WriteLine();
WriteLine("---------------------------------------");
WriteLine();

Proba fm = new Proba()
{
    Name = "Filip Milosevski",
    Birthdate = new(1998, 3, 7)
};
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: fm.Name,
    arg1: fm.Birthdate);


Proba il = new Proba()
{
    Name = "Ilija Nikolovski",
    Birthdate = new(1955, 1, 3)
};
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: il.Name,
    arg1: il.Birthdate);
Proba al = new Proba()
{
    Name = "Aleksandar Stankovski",
    Birthdate = new(1982, 2, 5)
};
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: al.Name,
    arg1: al.Birthdate);





List<Proba> probaList = new List<Proba>()
{
    new Proba()
    {
        Name = "Stefan Markovski",
        Birthdate = new(1985, 5, 3)
    },
    new Proba()
    {
        Name = "Trajko Stefanovski",
        Birthdate = new(1992, 1, 9)
    }
};

foreach (Proba p in probaList)
{
    WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
        arg0: p.Name,
        arg1: p.Birthdate);
}




Proba.Tuka.Add(new() {
    Name = "Fudbal Kosarka ",
    Birthdate = new(1998, 3, 7)
});
Proba.Tuka.Add(new() {
    Name = "Ragbi Tenis ",
    Birthdate = new(1976, 5, 2)
});
Proba.Tuka.Add(new()
{
    Name = "Rakomet Odbojka ",
    Birthdate = new(1965, 1, 4)
});


foreach (var n in Proba.Tuka)
{
    WriteLine(n.Name + n.Birthdate) ;
    
}

Proba.ShowTuka();

