using Newtonsoft.Json;
using PracticeNewtonsoft;
using static System.Console;


static void SectionTitle(string title)
{
    ConsoleColor previousColor = ForegroundColor;
    ForegroundColor = ConsoleColor.Yellow;
    WriteLine("*");
    WriteLine($"{title}");
    WriteLine("*");
    ForegroundColor = previousColor;
}

List<Employee> One = new List<Employee>()
{
    new Employee()
    {
        Name = "Filip",Id=1,Location="Skopje"
    },
    new Employee()
    {
        Name = "Martin",Id=2,Location="Kumanovo", klas = new List<Employee>()
        {
            new Employee()
            {
                Name = "Natali",Id=22,Location="Kumanovo",
            }
        }
    },
    new Employee()
    {
        Name = "Stefan",Id=3,Location="Stip", klas = new List<Employee>()
        {
            new Employee()
            {
                Name="Marko",Id=31,Location="Stip"
            },
            new Employee()
            {
                Name="Nikola",Id=3,Location="Stip"
            },new Employee()
            {
                Name="Dragan",Id=33,Location="Stip"
            }
        }
    }

};


//string json = JsonConvert.SerializeObject(One,Formatting.Indented);
//WriteLine(json);
//File.WriteAllText(@"C:\CSharp11andDotNET7\Chapter09\PracticeNewtonsoft\bin\Debug\net7.0\filip.json", json);


//using (StreamWriter file = File.CreateText(@"C:\CSharp11andDotNET7\Chapter09\PracticeNewtonsoft\bin\Debug\net7.0\filip.json"))
//{
//    JsonSerializer jss = new JsonSerializer();
//    jss.Serialize(file, One);
//}
//SectionTitle("============================= Iminja na profesori");


//List<Employee> one = JsonConvert.DeserializeObject<List<Employee>>(json);
//if (one != null)
//{
//    foreach (Employee oo in one)
//    {
//        WriteLine($"{oo.Name}");
//    }
//}
//SectionTitle("============================= Kolku asistenti imaat");
//if (one != null)
//{
//    foreach (Employee person in one)
//    {
//        int childrenCount = person.klas != null ? person.klas.Count : 0;
//        WriteLine($"{person.Name} has {childrenCount} assistants");
//    }
//}

//SectionTitle("============================= Iminja na sisstenti");


//if (one != null)
//{
//    foreach (Employee person in one)
//    {
//        int childrenCount = person.klas != null ? person.klas.Count : 0;
//        WriteLine($"{person.Name} has {childrenCount} assistants");

//        if (person.klas != null)
//        {
//            foreach (Employee child in person.klas)
//            {
//                WriteLine($"  {person.Name.PadLeft(30)}  has - {child.Name} for assistant");
//            }
//        }
//    }
//}


string json = JsonConvert.SerializeObject(One,Formatting.Indented);
WriteLine(json);
File.WriteAllText(@"C:\CSharp11andDotNET7\Chapter09\PracticeNewtonsoft\bin\Debug\net7.0\filip.json", json);
using (StreamWriter file = File.CreateText(@"C:\CSharp11andDotNET7\Chapter09\PracticeNewtonsoft\bin\Debug\net7.0\filip.json"))
{
    JsonSerializer jss = new JsonSerializer();
    jss.Serialize(file, One);

}

SectionTitle("IMINJA NA PROFESORI");
