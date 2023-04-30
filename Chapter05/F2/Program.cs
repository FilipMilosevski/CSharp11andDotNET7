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
