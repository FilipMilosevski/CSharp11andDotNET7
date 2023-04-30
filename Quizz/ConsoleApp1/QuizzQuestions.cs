using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class QuizzQuestions
    {
        public static Question[] Questions { get; private set; }
        public static void SetGeographyQuestions()
        {
            Questions = new Question[]
            {
                new Question("What is the name of the tallest mountain in the world?",
                "Mount Everest",
                new string[] { "Himalayas", "Mount Everest", "Alps", "Lhotse" }),
                new Question("What is the biggest continent of the world?",
               "Asia",
               null),
                new Question("What is the smallest country in europe?",
               "Malta",
               null)
            };
        }


        public static void SetEconomyQuestions()
        {
            Questions = new Question[]
            {
                new Question("Which country GDP is highest in the world?",
                "USA",
                new string[] { "China", "USA","India"}),
                new Question("Who has the strongest economy in Europe?",
                "Germany",
                null)
            };
        }
    }
}
