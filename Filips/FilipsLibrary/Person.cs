using System;
using System.Collections.Generic;
using System.Text;

namespace Filip.Shared;

public class Person
{
    public string? Name;
    public DateTime Dateofbirth;
    public Cities favoritecity;
    public List<Person> Children = new();
    public const string Species = "Homo Sapiens";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Dateofbirth:dddd}");
    }
    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }
    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }
    public string SayHello()
    {
        return $"{Name} says Hello!";
    }
    public string SayHelloTo(string name)
    //moze da go smenime so SayHello i tuka i vo program.cs
    {
        return $"{Name} says Hello, {name}!";
    }
    public string OptionalParameters(string command = "Run!",
double number = 0.0, bool active = true)
    {
        return string.Format(
        format: "command is {0}, number is {1}, active is {2}",
        arg0: command,
        arg1: number,
        arg2: active);
    }
    public void PassingParameters(int x, ref int y, out int z)
    {
        z = 99;
        x++;
        y++;
        z++;
    }
}
