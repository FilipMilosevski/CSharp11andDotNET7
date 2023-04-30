Proba fm = new Proba()
{
    Name = "Filip Milosevski",
    Birthdate = new(1998, 3, 7)
};
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: fm.Name,
    arg1: fm.Birthdate);


Proba il = new Proba()
{
    Name = "Ilija Nikolovski",
    Birthdate = new(1955, 1, 3)
};
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: il.Name,
    arg1: il.Birthdate);
Proba al = new Proba()
{
    Name = "Aleksandar Stankovski",
    Birthdate = new(1982, 2, 5)
};
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: al.Name,
    arg1: al.Birthdate);





List<Class1> probaList = new List<Class1>()
{
    new Class1()
    {
        Name = "Stefan Markovski",
        Birthdate = new(1985, 5, 3)
    },
    new Class1()
    {
        Name = "Trajko Stefanovski",
        Birthdate = new(1992, 1, 9)
    }
};

foreach (Class1 p in probaList)
{
    WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
        arg0: p.Name,
        arg1: p.Birthdate);
}




Proba.Tuka.Add(new()
{
    Name = "Fudbal Kosarka ",
    Birthdate = new(1998, 3, 7)
});
Proba.Tuka.Add(new()
{
    Name = "Ragbi Tenis ",
    Birthdate = new(1976, 5, 2)
});
Proba.Tuka.Add(new()
{
    Name = "Rakomet Odbojka ",
    Birthdate = new(1965, 1, 4)
});


foreach (var n in Proba.Tuka)
{
    WriteLine(n.Name + n.Birthdate);

}

Proba.ShowTuka();

