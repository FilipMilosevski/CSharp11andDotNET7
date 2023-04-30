using System;
using System.Collections.Generic;
using System.Text;

namespace Filip.Shared;

public class Person : object
{
    public string? Name;
    public DateTime Dateofbirth;
    public Cities FavoriteCities;
    public List<Person> Children = new List<Person>();
}
