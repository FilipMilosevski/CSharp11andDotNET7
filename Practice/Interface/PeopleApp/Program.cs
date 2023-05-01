using Packt.Shared;

Person Filip = new Person()
{
    Name = "Filip",
    DateOfBirth = new DateTime(year: 2001, month: 3, day: 25)
};
Filip.WriteToConsole();


//non generic lookup collection so add metoda 
System.Collections.Hashtable lookupObject = new System.Collections.Hashtable();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: Filip, value: "Delta");

int key = 2;

WriteLine(format: "Key {0} has value: {1}",
    arg0: key,
    arg1: lookupObject[key]);
WriteLine(format: "Key {0} has value: {1}",
    arg0: Filip,
    arg1: lookupObject[Filip]);

// generic lookup collection
Dictionary<int, string> lookupIntString = new Dictionary<int, string>();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "Key {0} has value: {1}",
    key,
    lookupIntString[key]);


//a method to handle the Shout event recieved by the Filip object
static void Filip_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person? p = sender as Person;
    if (p == null) return;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
}

//assign a method to the Shout delegate
Filip.Shout += Filip_Shout;
Filip.Shout += Filip_Shout2;
//call the  Poke method that raises the Shout event
Filip.Poke();
Filip.Poke();
Filip.Poke();
Filip.Poke();
Filip.Poke();

static void Filip_Shout2 (object? sender, EventArgs e)
{
    if (sender is null) return;
    Person? p = sender as Person;
    if (p is null) return;
    WriteLine($"Stop it!");
}

void OutputPeopleNames(IEnumerable<Person?> people, string title)
{
    WriteLine(title);
    foreach (Person? p in people)
    {
        WriteLine(" {0}",
        p is null ? "<null> Person" : p.Name ?? "<null> Name");
        /* if p is null then output: <null> Person
        else output: p.Name
        unless p.Name is null in which case output: <null> Name */
    }
}

Person?[] people =
        {
            null,
            new() { Name = "Simon" },
            new() { Name = "Jenny" },
            new() { Name = "Adam" },
            new() { Name = null },
            new() { Name = "Richard" }
        };

OutputPeopleNames(people, "Initial list of people:");
Array.Sort(people);
OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");

//IPlayable player1 = new DvdPlayer();
//player1.Play();
//player1.Pause();

//IPlayable player2 = new CdPlayer();
//player2.Play();
//player2.Pause();

//IPlayable player3 = new Filips();
//player3.Play();
//player3.Pause();

List<IPlayable> MyPlayers = new List<IPlayable>();
MyPlayers.Add(new DvdPlayer());
MyPlayers.Add(new CdPlayer());
MyPlayers.Add(new Filips());
foreach (IPlayable item in MyPlayers)
{
    item.Play();
}