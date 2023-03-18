using HelloCSharpSayHello.myClass;

namespace HelloCSharpSayHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = Console.ReadLine();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("HELLO my name is Filip");
            Console.Write("Hello");
            Console.Write(" my name is..." +myName);

            Class1 myClass1 = new Class1();
        }
    }
}