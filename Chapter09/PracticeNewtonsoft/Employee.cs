using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNewtonsoft
{
    public class Employee
    {
        public string? Name { get; set; }
        public int? Id { get; set; }
        public string? Location { get; set; }
        public List<Employee>?  klas {get;set;}

        public Employee() { }
    }
}
