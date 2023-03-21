
using Filip1.myClass;

namespace Filip2
   
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, FILIP 2!");
            int myInt = 256;
            byte myByte = 255;
            bool myBool = false;
            string myString = "Filip";
            char myChar = 'F';
            DateTime myDate = DateTime.Now;
            Console.WriteLine("My int is: " + myInt);
            Console.WriteLine("My byte is: " +myByte);
            Console.WriteLine("My boolean is: " +myBool);
            Console.WriteLine("My string is: " +myString);
            Console.WriteLine("My char is: " +myChar);
            Console.WriteLine("My date is: " +myDate);


            NC myClass = new NC();
            myClass.MyProperty = 1;
            int mySecondInt = myClass.MyProperty;
            myClass.ShowMyInt();
        }
    }
}