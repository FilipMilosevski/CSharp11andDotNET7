using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzHome
{
    public static class QuizzQuestion1
    {
        public static Question1[] questions { get;private set; }    
        public static void setAnimalQuestion()
        {
            questions = new Question1[]
            {
                new Question1("What is dog?","two", new string[]{"one","two","three"}),
                new Question1("What is cat", "one",null),
                new Question1("What is horse","three",null)
            };
        }
        public static void setCarQuestion()
        {
            questions = new Question1[]
            {
                new Question1("Mondeo is model of ?","ford",new string[]{"vw","seat","ford"}),
                new Question1("Passat is model of ?","vw",null),
                new Question1("Ibiza is model of ?", "seat",null),
                new Question1("Jimmy is model of ?", "suzuki", new string[]{"suzuki","audi","bmw"})
            };
        }

    }
}
