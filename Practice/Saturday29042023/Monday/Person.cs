using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday
{
    public class Person : object, Interface1
    {
        public string? Fname { get; set; }
        public string? Lname { get; set; }

        public int ID { get; set; }
        public void play()
        {
            Console.WriteLine("PERSON IS PLAY");
        }
        public void pause()
        {
            Console.WriteLine("PERSON IS PAUSE");
        }


    }
}
