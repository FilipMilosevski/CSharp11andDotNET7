using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;

public class Proba
{
    public string? Name;
    public DateTime Birthdate;


    public static List<Proba> Tuka = new List<Proba>()
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

    public static void ShowTuka()
    {
        WriteLine();
        WriteLine("ShowTuka method --------");
        foreach (var proba in Tuka)
        {
            Console.WriteLine(proba.Name);
            WriteLine(proba.Birthdate);
        }
        WriteLine("==================");
        WriteLine();
    }
}
