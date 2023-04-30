using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp.Library
{
    public class Person
    {
        public string? Fname;
        public string? Lname;
        public int  Id;
        public Person()
        {
            Fname = "Unknown";
            Lname = "Unknown";
            Id = 0;
        }
        public Person (string Firstname,  string Lastname, int ID)
        {
            Fname = Firstname;
            Lname = Lastname;
            Id = ID;
        }
    }
}
