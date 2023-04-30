using ConsoleApp;
using System.Threading.Channels;

Console.WriteLine("QUIZZ");

//nekoja klasa(tip) sto ke ni sodrzi prasanja 


//bonus dadete opcija na userot da odbere kategorija
QuizzQuestions.SetGeographyQuestions();
foreach (Question question in QuizzQuestions.Questions)
{
    Console.WriteLine(question.Text);
	for (int i = 0; i < question.Options. Length; i++)
	{
        Console.WriteLine($"{i + 1} . {question.Options[i]}");
    }
    string userAnswer = Console.ReadLine().Trim();
    if (userAnswer.ToLower() == question.Answer.ToLower())
    {
        Console.WriteLine("You quessed right!");
    } else
    {
        Console.WriteLine($"The right answer was {question.Answer}");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}

bool newGame = Console.ReadLine().ToLower() == "yes";
if (newGame)
{
    //Treba da napravite nova igra so druga kategorija
    //primer QuizzQuestion.SetHistoryQuestions();
}