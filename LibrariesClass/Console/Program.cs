using Filip.Shared;
using System.Text;

Person Filip = new Person();
WriteLine(Filip.ToString());
WriteLine(Filip);

OutputEncoding = Encoding.UTF8; 

Filip.Name = "Filip";
Filip.Dateofbirth = new DateTime(1999, 5, 2);
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0:Filip.Name,
    arg1:Filip.Dateofbirth);
WriteLine($"{Filip.Name} was born on {Filip.Dateofbirth:dddd, d MMMM yyyy}");

Person Alice = new Person()
{
    Name = "Alice Jones",
    Dateofbirth = new(1988, 1, 2)
};
WriteLine(format: "{0} was born on {1:dd MMM yy}",
    arg0: Alice.Name,
    arg1: Alice.Dateofbirth);
WriteLine($"{Alice.Name} was born on {Alice.Dateofbirth:dd MMM yy}");

Filip.FavoriteCities = Cities.Madrid;

WriteLine(format: "{0}'s favorite city is {1}",
    arg0: Filip.Name,
    arg1: (int)Filip.FavoriteCities);
WriteLine($"{Filip.Name}'s favorite city is {Filip.FavoriteCities}");

Filip.Children.Add(new Person { Name = "Stefan" });
//   c# 3.0 and later
Filip.Children.Add(new() { Name = "Nikola" });
//   c# 9.0 and later
Filip.Children.Add(new() { Name = "Nikola" });
Filip.Children.Add(new() { Name = "Nikola" });


WriteLine($"{Filip.Name} has {Filip.Children.Count} children: ");
for (int ci = 0; ci < Filip.Children.Count; ci++)
{
    WriteLine($">{Filip.Children[ci].Name}");
} // da gi izvrti site iminja


BankAccount.InterestRate = 0.012M;
BankAccount StefanAccount = new();
StefanAccount.AccountName = "Mr Stefan";
StefanAccount.Balance = 2500;
WriteLine(format: "{0}'s balance is {1}",
    arg0: StefanAccount.AccountName,
    arg1: StefanAccount.Balance);
WriteLine($"{StefanAccount.AccountName}'s balance is {StefanAccount.Balance}");

WriteLine(format: "{0} earned {1:C} interest.",
    StefanAccount.AccountName,
    StefanAccount.Balance * BankAccount.InterestRate);
WriteLine($"{StefanAccount.AccountName} earned " +
    $"{StefanAccount.Balance * BankAccount.InterestRate:C} interest.");


BankAccount KostaAccount = new();
KostaAccount.AccountName = "Mr Kosta";
KostaAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: KostaAccount.AccountName,
    arg1: KostaAccount.Balance *BankAccount.InterestRate);
WriteLine($"{KostaAccount.AccountName} earned " +
    $"{KostaAccount.Balance * BankAccount.InterestRate:C} interest.");