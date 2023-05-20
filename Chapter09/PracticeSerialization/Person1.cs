
namespace Packt.Shared;

public class Person1
{
    

    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public DateTime DateOfBirth { get;set; }

    public HashSet<Person1> Children { get; set; }
    protected decimal Salary { get; set; }

    public Person1(decimal salary)
    {
        this.Salary = salary;
    }
    public Person1()
    {

    }
 

}
