

// a string array is a sequence that implements IEnumerable<string>
string[] names = new[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };

SectionTitle("HOMEWORK");


// koe ime zavrsuva na M   
//var query1 = names.Where(name => name.EndsWith("m")); PRV NACIN
IEnumerable<string> query1 = names.Where(name => name.EndsWith("m")); //VTOR NACIN

//WriteLine(query1);
WriteLine("LINQ METHOD");

foreach (string name in query1)
{
    WriteLine(name);
}

// vtor nacin so query koe ime zavrsuva na m
WriteLine("LINQ QUERY");

IEnumerable<string> query2 = from name in names where  name.EndsWith("m") select name;
foreach (string name in query2)
{

    WriteLine(name);
}

// koi ja sodrzat bukvata a 
SectionTitle("koi iminja imaat a");
IEnumerable<string> query3 = names.Where(name => name.Contains("a"));
foreach ( string name in names)
{
    WriteLine(name);
}