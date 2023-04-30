using Csss;
using Filip.Shared;


Person Filip = new Person();
WriteLine(Filip);
WriteLine(Filip.ToString());
Filip.Name = "Filip Milosevski";
WriteLine(Filip.Name);

Person Martin = new Person()
{
    Name = "Martin Tasevski",
    DateOfBirth = new(1992, 5, 3)
};
WriteLine(format:"{0} is born on {1:dddd,MMMM.yyyy}",
    arg0:Martin.Name,
    arg1:Martin.DateOfBirth);

WriteLine($"{Martin.Name}'s favorite city is {Cities.London}");
WriteLine(format: "{0}'s favorite city is {1}",
    arg0: Martin.Name,
    arg1: Cities.Belgrad);
Person Stefan = new Person()
{
    Name = "Stefan Nikolov",
    DateOfBirth = new(1987, 9, 2)
};
Stefan.FavoriteCity = Cities.Barselona;
WriteLine(format: "{0} is born on {1} in {2}",
    arg0: Stefan.Name,
    arg1: Stefan.DateOfBirth,
    arg2: Stefan.FavoriteCity);

Filip.Children.Add(new() {Name="Child 1"});
Filip.Children.Add(new() {Name="Child 2"});
Filip.Children.Add(new() {Name="Child 3"});
WriteLine($"{Filip.Name} has {Filip.Children.Count} kids.");
for (int child = 0; child <Filip.Children.Count; child++)
{
    WriteLine($"{Filip.Children[child].Name}");
}

BankAccount.InterestRate = 0.012M;
BankAccount nikolaAccount = new();
nikolaAccount.AccountName = "Nikola Stoilkovski";
nikolaAccount.Balance = 2400;
WriteLine(format: "{0} have balance of {1:C} with interest rate of {2}",
    arg0: nikolaAccount.AccountName,
    arg1: nikolaAccount.Balance,
    arg2: BankAccount.InterestRate);
WriteLine($"{nikolaAccount.AccountName} have balance" +
    $" of {nikolaAccount.Balance} with interest rate of {BankAccount.InterestRate}");
WriteLine($"{Filip.Name} is {Person.Species}");
WriteLine($"{Filip.Name} is born on {Filip.HomePlanet}");


WriteLine(format: "{0}'s favorite city is {1}. Its integer {2}",
    arg0:Stefan.Name,
    arg1:Stefan.FavoriteCity,
    arg2:(int)Stefan.FavoriteCity);


ReadLine();
Person blankPerson = new Person();
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
    arg0:Filip.Name,
    arg1:Filip.HomePlanet,
    arg2:Filip.Instantiated);

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);


Person Gunny = new(initialName: "Gunny", homePlanet: "Mars");
// Person Gunny = new("Gunny", "Mars");
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0:Gunny.Name,
    arg1:Gunny.HomePlanet,
    arg2:Gunny.Instantiated);

Filip.WriteToConsole();
WriteLine(Filip.GetOrigin());

(string, int) fruit = Filip.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are");
var fruitNamed = Filip.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} and {thing1.Item2}");

var thing2 = (Filip.Name, Filip.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children");

WriteLine(Filip.SayHello());
WriteLine(Filip.SayHello("Emily"));

WriteLine(Filip.OptionalParameters());
WriteLine(Filip.OptionalParameters(command:"start"));
WriteLine(Filip.OptionalParameters(number:3, command: "city"));


int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before     a={a}, b={b}, c={c}");


Filip.PassingParameters(a, ref b, out c);


WriteLine($"After     a={a}, b={b}, c={c}");    