using static System.Console;
using SaturdaySerializationJson;

using System.Text.Json;

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

string filename = @"C:\CSharp11andDotNET7\Chapter09\SaturdaySerializationJson\bin\Debug\net7.0\filip.json";

string jsonstring = JsonSerializer.Serialize(One);

File.WriteAllText(filename, jsonstring);

Console.WriteLine(File.ReadAllText(filename));




