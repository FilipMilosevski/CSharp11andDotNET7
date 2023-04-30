using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    internal class Student : Person
    {
        internal void ShowAge()
        {
            Console.WriteLine($"My age is is {this.Age} years old.");
        }
    }
}
