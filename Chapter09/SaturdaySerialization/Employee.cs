using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaturdaySerializationXml
{
    public class Employee
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }

        public string? Address { get; set; }
        public List<Employee>? Suordinared { get; set; }

        public Employee() { }

    }
}
