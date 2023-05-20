using Newtonsoft.Json;
using SaturdaySerializationNewtonsoft;
using static System.Console;

List<Employee> One = new List<Employee>()
{

    new Employee()
    {

    Id=1, Name="Ljupcho", Address="Zadrugarska br.10", Position="Head of Department", Suordinared=new List<Employee>(){
    new Employee()
    {

        Id=2,
        Position="Advisor",

        Address="Vostanichka",

        Name="Maja",



    }

    } },

 new Employee()
    {

    Id=2, Name="Petko", Address="Car Dushan br.10", Position="Head of Department", Suordinared=new List<Employee>(){
    new Employee()
    {

        Id=2,
        Position="Associate",

        Address="Vostanichka",

        Name="Trajche",



    }

    } }






};

string json = JsonConvert.SerializeObject(One);

Console.WriteLine(json);



// serialize JSON to a string and then write string to a file
File.WriteAllText(@"C:\CSharp11andDotNET7\Chapter09\fff\bin\Debug\net7.0\proba2.json", JsonConvert.SerializeObject(One));

// serialize JSON directly to a file
using (StreamWriter file = File.CreateText(@"C:\CSharp11andDotNET7\Chapter09\fff\bin\Debug\net7.0\proba2.json"))
{
    JsonSerializer serializer = new JsonSerializer();
    serializer.Serialize(file, One);
}


List<Employee> one = JsonConvert.DeserializeObject<List<Employee>>(json);
if (one != null)
{
    foreach (Employee o in one)
    {
        Console.WriteLine(o.Name);
    }
}

