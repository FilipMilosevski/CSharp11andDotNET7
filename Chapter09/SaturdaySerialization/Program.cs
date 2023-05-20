using SaturdaySerializationXml;
using System.Xml.Serialization;

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
XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));

using (TextWriter writer = new StreamWriter(@"people.xml"))
{
    serializer.Serialize(writer, One);
}
using (FileStream fileStream = new FileStream(@"people.xml", FileMode.Open))
{
    List<Employee>? emp = serializer.Deserialize(fileStream) as List<Employee>;

    if (emp != null)
    {
        foreach (Employee employee in emp)
        {
            var under = employee.Suordinared;
            foreach (Employee employee1 in under)
            {
                Console.WriteLine($"{employee.Name} has under  {employee1.Name} employee");
            }
        }
    }
}