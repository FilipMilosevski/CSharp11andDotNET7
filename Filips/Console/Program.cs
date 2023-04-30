using Filip.Shared;
using System.Reflection.Metadata;

Person Filip = new Person();
WriteLine(Filip.ToString());
WriteLine(Filip);
Filip.Name = "Filip";
Person Martin = new Person()
{
    Name = "Martin Stojkovski",
    Dateofbirth = new(1992, 3, 5)
};

WriteLine(format: "{0} is born on {1} in USA",
    arg0: Martin.Name,
    arg1: Martin.Dateofbirth);
WriteLine($"{Martin.Name} is born on" +
    $" {Martin.Dateofbirth:dddd,MMMM,yyyy} in USA");
Person Stefan = new Person()
{
    Name = "Stefan Ilievski",
    Dateofbirth = new(1979, 5, 5)
};
WriteLine(format: "{0}'s favorite city is {1}",
    arg0: Stefan.Name,
    arg1:Cities.London
    );
WriteLine($"{Stefan.Name} is also born in {Stefan.Dateofbirth}");

Stefan.favoritecity = Cities.Rim;
WriteLine(format: "{0}'s favorite CITY is {1}. Its integer is {2}",
    arg0: Stefan.Name,
    arg1: Stefan.favoritecity,
    arg2: (int)Stefan.favoritecity);

Filip.Children.Add(new () { Name = "Filip1" });
Filip.Children.Add(new () { Name = "Filip2" });
Filip.Children.Add(new () { Name = "Filip2" });



WriteLine($"{Filip.Name} has {Filip.Children.Count} children");

for (int chind = 0; chind < Filip.Children.Count; chind++)
{
    WriteLine($"{Filip.Children[chind].Name}");
}

BankAccount.InterestRate = 0.012M;
BankAccount petarAccount = new ();
petarAccount.AccountName = "MR Petar";
petarAccount.Balance = 2400;
WriteLine(format: "{0} have balance of {1:C} with interest rate of {2}",
    arg0: petarAccount.AccountName,
    arg1: petarAccount.Balance,
    arg2: BankAccount.InterestRate);
WriteLine($"{petarAccount.AccountName} have balance " +
    $"of {petarAccount.Balance:C} with interest rate of {BankAccount.InterestRate}");

BankAccount oliverAccount = new();
oliverAccount.AccountName = "MR Oliver";
oliverAccount.Balance = 2500;
WriteLine(format: "{0} have balance of {1:C} with interest rate of {2}",
    arg0: oliverAccount.AccountName,
    arg1: oliverAccount.Balance,
    arg2: BankAccount.InterestRate);
WriteLine($"{oliverAccount.AccountName} have balance" +
    $" of {oliverAccount.Balance:C} with interest rate of {BankAccount.InterestRate}");
WriteLine($"{Filip.Name} is {Person.Species}");
WriteLine($"{Filip.Name} is born on {Filip.HomePlanet}");


ReadLine();

Person blankPerson = new Person();
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: Filip.Name,
    arg1: Filip.HomePlanet,
    arg2: Filip.Instantiated);

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person Gunny = new(initialName: "Gunny", homePlanet: "Mars");
// Person Gunny = new("Gunny", "Mars"); vtor nacin

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: Gunny.Name,
    arg1: Gunny.HomePlanet,
    arg2: Gunny.Instantiated);

Filip.WriteToConsole();
WriteLine(Filip.GetOrigin());

(string, int) fruit = Filip.GetFruit(); 
WriteLine($"{fruit.Item1},{fruit.Item2} there are");

var fruitNamed = Filip.GetNamedFruit(); 
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (Filip.Name, Filip.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

WriteLine(Filip.SayHello());
//moze samo SayHello
WriteLine(Filip.SayHelloTo("Emily"));

WriteLine(Filip.OptionalParameters(command:"start"));
WriteLine(Filip.OptionalParameters("Jump", 98.5));
//moze i da gi izmestime poziciite
WriteLine(Filip.OptionalParameters(number: 52.7, command: "Hide!"));

int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
Filip.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");


