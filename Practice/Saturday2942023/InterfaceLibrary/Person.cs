namespace Filip.Shared;

public class Person
{
    public string ? Name { get; set; }
    public DateTime Date { get; set; }
    public void WTC()
    {
        WriteLine($"{Name} was born on {Date}");
    }
}