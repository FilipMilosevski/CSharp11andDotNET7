using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentProfessorTest
    {
        internal void Main()
        {
            Person filip = new Person();
            filip.Greet();


            Student newstudent = new Student();
            newstudent.SetAge(15);
            newstudent.ShowAge();
            newstudent.Greet();

            Professor newprofessor = new Professor();
            newprofessor.SetAge(25);
            newprofessor.Greet();
            newprofessor.Explain();

        }
    }
}
