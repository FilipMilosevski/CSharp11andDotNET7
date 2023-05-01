using Monday;


List<Person> people = new List<Person>()
{
    new Person() { Fname = "FILIP", Lname = "MILOSEVSKI", ID = 1 },
    new Person() { Fname = "NIKOLA", Lname = "STOJANOVSKI", ID = 2 },
    new Person() { Fname = "JANE", Lname = "DIMISKOVSKI", ID = 3 },
    new Person() { Fname = "VOJDAN", Lname = "MILEVSKI", ID = 4 },
    new Person() { Fname = "KOSTA", Lname = "PAVLOVSKI", ID = 5 },
    
};

Person newPerson = new Person()
{
    Fname = "NEW",
    Lname = "PERSON",
    ID = 123
};
people.Add(newPerson);


foreach (Person data in people)
{
    Console.WriteLine(data.Fname);
    Console.WriteLine(data.Lname);
    Console.WriteLine(data.ID);
    Console.WriteLine();
}

Person secondPerson = people[1];

Console.WriteLine("First Name: " + secondPerson.Fname);
Console.WriteLine("Last Name: " + secondPerson.Lname);
Console.WriteLine("ID: " + secondPerson.ID);

newPerson.player1();


