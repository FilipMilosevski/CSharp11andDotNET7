using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Economy
    {
        public List<string> questions = new List<string>();
        public List<string> answers = new List<string>();
        public Economy()
        {
            questions = new List<string>
            {
                "What is micro economy ?"
            };
            answers = new List<string>
            {
                "local"
            };
        }
    }
}
