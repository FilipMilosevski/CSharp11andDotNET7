

using ConsoleApp1;

Console.WriteLine("Quizz");
//nekoja klasa (tip) sto ke ni sodrzi prasanja

// bonus dadete opcija na userot da izbere kategorija

//

//switch (quizSelection)
//{
//    case "geography":
//        QuizzQuestions.SetGeographyQuestions();
//        break;
//    case "economy":
//        QuizzQuestions.SetEconomyQuestions();
//        break;
//    default:
//        break;
//}








Console.WriteLine("Which quiz do you want to play: Geography or Economy?");
string quizSelection = Console.ReadLine().ToLower().Trim();

if (quizSelection == "geography")
{
    QuizzQuestions.SetGeographyQuestions();
}
else if (quizSelection == "economy")
{
    QuizzQuestions.SetEconomyQuestions();
}
else
{
    Console.WriteLine("Thanks for playing!");
    return;
}



foreach (Question question in QuizzQuestions.Questions)
{
    Console.WriteLine(question.Text);
    for (int i = 0; i < question.Options.Length; i++)
    {
        Console.WriteLine($"{i + 1} . {question.Options[i]}");
    }
    string userAnswer = Console.ReadLine().Trim();
    if (userAnswer.ToLower() == question.Answer.ToLower())
    {
        Console.WriteLine();
        Console.WriteLine("You guessed right!");
        Console.WriteLine();
    } else 
    {
        Console.WriteLine();
        Console.WriteLine($"The right answer was {question.Answer}");
        Console.WriteLine();

    };
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Do you want to continue with the quiz?");
string continueResponse = Console.ReadLine().ToLower().Trim();
if (continueResponse == "yes")
{
    Console.WriteLine("Let's continue!");
}
else
{
    Console.WriteLine("Thanks for playing! Goodbye.");
    return;
}

QuizzQuestions.SetEconomyQuestions();


foreach (Question question in QuizzQuestions.Questions)
{
    Console.WriteLine(question.Text);
    for (int i = 0; i < question.Options.Length; i++)
    {
        Console.WriteLine($"{i + 1} . {question.Options[i]}");
    }
    string userAnswer = Console.ReadLine().Trim();
    if (userAnswer.ToLower() == question.Answer.ToLower())
    {
        Console.WriteLine();
        Console.WriteLine("You guessed right!");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"The right answer was {question.Answer}");
        Console.WriteLine();

    };
}





//bool newGame = Console.ReadLine().ToLower() == "yes";
//if (newGame)
//{
//    //treba da napravime nova igra so druga kategorija
//    // primer QuizzQuestion.SetHistoryQuestions();
//}