using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Geography
    {
        public List<string> questions = new List<string>();
        public List<string> answers = new List<string>();
        public Geography()
        {
            questions = new List<string>
            {
                "What is the capital of England?"
            };
            answers = new List<string>
            {
                "London"
            };
        }
    }
}
