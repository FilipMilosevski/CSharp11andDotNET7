using System.Xml.Serialization;
using Packt.Shared;
using static System.Environment;
using static System.IO.Path;
using static System.Console;
using Newtonsoft.Json;



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

XmlSerializer xs = new XmlSerializer(typeof(List<Person1>));
string path = Path.Combine(Environment.CurrentDirectory, "people.xml");
using (FileStream stream = File.Create(path))
{
    xs.Serialize(stream, people);
}
WriteLine("Serializing XML");
WriteLine(new FileInfo(path).Length);
WriteLine(path);
WriteLine("Written {0:N0} words in {1}", new FileInfo(path).Length, path);
WriteLine("==========================================");

string[] lines = File.ReadAllLines(path);
foreach (string line in lines)
{
    WriteLine(line);
}
WriteLine("===========================================");

WriteLine("Deserialization of XML");
using (FileStream xmlLoad = File.Open(path, FileMode.Open))
{
    List<Person1>? loadedPeople = xs.Deserialize(xmlLoad) as List<Person1>;
    if(loadedPeople != null)
    {
        foreach (Person1 person in loadedPeople)
        {
            WriteLine($"{person.LastName} has {person.Children.Count} children");
        }
    }
}
WriteLine("==========================================");


WriteLine("Serializing JSON");
string pathJson = Combine(CurrentDirectory, "people.json");
using (StreamWriter streamJson = File.CreateText(pathJson))
{
    JsonSerializer jss = new JsonSerializer();
    string json = JsonConvert.SerializeObject(people, Formatting.Indented);
    streamJson.Write(json);
}
WriteLine(new FileInfo(pathJson).Length);
WriteLine(pathJson);
WriteLine("Written {0:N0} words in {1}", new FileInfo(pathJson).Length, pathJson);
WriteLine("======================================");
WriteLine(File.ReadAllText(pathJson));
WriteLine("====================================");
WriteLine("Deserializing JSON files");
string jsonText = File.ReadAllText(pathJson);
List<Person1> jsonPeople = JsonConvert.DeserializeObject<List<Person1>>(jsonText);
if(jsonPeople != null)
{
    foreach (Person1 person in jsonPeople)
    {
        int childrenCount = person.Children != null ? person.Children.Count : 0;
        WriteLine($"{person.FirstName} has {childrenCount} children");  
    }
}