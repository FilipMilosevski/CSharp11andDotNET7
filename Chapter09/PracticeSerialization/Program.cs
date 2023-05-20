using System.Xml.Serialization;
using Packt.Shared;
using static System.Environment;
using static System.IO.Path;
using static System.Console;
using Newtonsoft.Json;


static void SectionTitle(string title)
{
    ConsoleColor previousColor = ForegroundColor;
    ForegroundColor = ConsoleColor.Yellow;
    WriteLine("*");
    WriteLine($"*{title}");
    WriteLine("*");
    ForegroundColor = previousColor;
}

List<Person1> people = new List<Person1>()
{
    new Person1(10000M)
    {
        FirstName = "Marko",
        LastName = "Stojanovski",
        DateOfBirth = new DateTime(2001,04,03)
    },
    new Person1(20000M)
    {
        FirstName = "Stefan",
        LastName = "Nikolovski",
        DateOfBirth = new DateTime(1999,01,02)
    },
    new Person1(30000M)
    {
        FirstName = "Bojan",
        LastName = "Trajkovski",
        DateOfBirth = new DateTime(1992,12,11)
    },
    new Person1(40000M)
    {
        FirstName = "Nikola",
        LastName = "Petkovksi",
        DateOfBirth = new DateTime(2003,09,27)
    },
    new Person1(50000M)
    {
        FirstName = "Risto",
        LastName = "Martinovski",
        DateOfBirth = new DateTime(1997,10,12),
        Children = new HashSet<Person1>()
        {
            new Person1(0M)
            {
                FirstName = "Goran",
                LastName = "Martinovski",
                DateOfBirth = new DateTime(2015,01,25)
            },
            new Person1(0M)
            {
                FirstName = "Vlado",
                LastName = "Martinovski",
                DateOfBirth = new DateTime(2017,11,22)
            }
        }
    }
};


SectionTitle("Serialiizing JSON");
SectionTitle("==============================");

string pathJson = Combine(CurrentDirectory, "people.json");
using (StreamWriter streamJson = File.CreateText(pathJson))
{
    JsonSerializer jss = new JsonSerializer();
    string json = JsonConvert.SerializeObject(people, Formatting.Indented);
    streamJson.Write(json);
    //jss.Serialize(streamJson, people);
};
WriteLine(new FileInfo(pathJson).Length);
WriteLine(pathJson);
WriteLine("Written {0:N0} in {1}", new FileInfo(pathJson).Length, pathJson);
SectionTitle("---------------------------------------------------");
WriteLine(File.ReadAllText(pathJson)+"   SEE");
SectionTitle("==============================");

SectionTitle("Deserialiizing JSON files");
string jsonText = File.ReadAllText(pathJson);
List<Person1>? jsonPeople = JsonConvert.DeserializeObject<List<Person1>>(jsonText);
if (jsonPeople != null)
{
    foreach (Person1 person in jsonPeople)
    {
        int childrenCount = person.Children != null ? person.Children.Count : 0;
        WriteLine($"{person.FirstName} has {childrenCount} children");
    }
}



