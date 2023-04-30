using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        internal int Age;
        internal void Greet()
        {
            Console.WriteLine("Hello!");
        }
        internal void SetAge(int age)
        {
            this.Age = age;
        }
    }
}
