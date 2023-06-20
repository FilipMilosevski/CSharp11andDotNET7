// a string array is a sequence that implements IEnumerable<string>
using System.Numerics;

string[] names = new[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };

//question koe ime zavrsuva so m 
// Question: Which names end with an M?
// (written using a LINQ extension method)
var query1 = names.Where(name => name.EndsWith("m"));
//WriteLine(query1);
foreach (string name in query1)
{
    WriteLine(name);
}
SectionTitle("Deferred execution");

IEnumerable<string> query2 = from name in names where name.EndsWith("a") select name;

WriteLine("linq query");


foreach (string name in query2)
{
    WriteLine(name);
}


//dali imeto sodrzi a 
SectionTitle("koi sodrzat a");
var query3 = names.Where(name => name.Contains("a"));

foreach (string name in query3)
{
    WriteLine(name);
}
