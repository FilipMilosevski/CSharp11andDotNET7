using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    public class Person : IRecreation, ISleep, IWork
    {
        

       

        public string sleep(string x)
        {
            return  "I sleep " + x;
        }

       

        public string working(string x)
        {
            return "I'm working " + x;
        }

        public DateTime recreation()
        {
            DateTime now = DateTime.Now;
            return now;

        }
        public void recreation1()
        {
            Console.WriteLine($" am recreating {DateTime.Now} ");
        }

    }
}
