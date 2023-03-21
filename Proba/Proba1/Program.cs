using Proba1.myClass;    
namespace Proba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Filip ");
            Console.Write("Fico ");
            Console.WriteLine(" Enter      a number in miles");
            var x = Convert.ToDouble(Console.ReadLine());
            var y = x * 1.61;
            Console.WriteLine("The distance in kilemeters is {0} from {1}  miles", y,x);



            Class1 myclass1 = new Class1();
        }
    }
}