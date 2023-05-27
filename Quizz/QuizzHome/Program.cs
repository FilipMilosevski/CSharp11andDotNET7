using QuizzHome;

Console.WriteLine("Which quizz do you want to play: Animal or Car?");


string quizSelection = Console.ReadLine().ToLower().Trim();

if (quizSelection == "animal")
{
    QuizzQuestion1.setAnimalQuestion();
}
else if (quizSelection == "car")
{
    QuizzQuestion1.setCarQuestion();
}
else
{
    Console.WriteLine("Thanks for playing!");
    return;
}



foreach (Question1 question in QuizzQuestion1.questions)
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

QuizzQuestion1.setCarQuestion();


foreach (Question1 question in QuizzQuestion1.questions)
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

