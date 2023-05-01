using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday
{
    public class Person : object, Interface1, Interface2, Interface3
    {
        public string? Fname { get; set; }
        public string? Lname { get; set; }

        public int ID { get; set; }
        public void player1()
        {
            Console.WriteLine("THIS PERSON IS PLAYER 1");
        }


    }
}
