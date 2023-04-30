using Recap_Lib.Models;

Person myPerson = new Person("Filip",5);

//ctrl shift space na Person()

myPerson.Greet();
//Person.Greet ne go naogja zatoa sto ne e static 

Student student = new Student("Dame",5);
student.SetAge(21);
string intro = student.Introduce();
WriteLine(intro);


Professor.Explain();




static void Main(string[] args)
{
    // Display a welcome message
    Console.WriteLine("Welcome to my C# console application!");

    // Wait for user input
    Console.ReadLine();
    Console.WriteLine("Thanks for your application");
}
Main(args);













//void test(int num)
//{
//    WriteLine($"The number is {num}");
//}
//test(4);

//int n1 = 5;
//int n2 = 10;
//int Add(int num1, int num2)
//{
//    return num1 + num2;
//}
//WriteLine(format: "The sum of {0} and {1} is {2} ",
//    arg0:n1,
//    arg1:n2,
//    arg2:Add(n1,n2)
//    );
////moze i bez args
///









