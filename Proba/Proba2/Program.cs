using Proba1.myClass;

namespace Proba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Class1 myClass = new Class1();
            myClass.MyProperty = 1;
            int mySecondInt = myClass.MyProperty;
            myClass.ShowMyInt();
        }
    }
}