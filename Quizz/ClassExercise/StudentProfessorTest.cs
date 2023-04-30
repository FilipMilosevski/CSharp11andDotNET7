using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    internal class StudentProfessorTest
    {
        internal void Main() {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(21);
            student.ShowAge();
            student.Greet();

            Professor professor = new Professor();
            professor.SetAge(53);
            professor.Greet();
            professor.Explain();
        }
    }
}
