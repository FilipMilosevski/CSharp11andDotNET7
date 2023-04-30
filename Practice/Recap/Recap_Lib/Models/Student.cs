using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Lib.Models
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name,age)
        {
            
        }
        // : Person za da nasledi od Person, posledno go pisav
        public void Study()
        {
            WriteLine("I'm studying");
        }
        public string Introduce()
        {
            return $"Hi my name is {this.name}. I'm a student, and i'm {this.GetAge()} old.";
        }
       
    }
}
