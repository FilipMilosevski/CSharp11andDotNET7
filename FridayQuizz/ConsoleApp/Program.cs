using ConsoleApp;

Economy equestion = new Economy();


foreach (string question in equestion.questions)
{
    Console.WriteLine(question);
}


foreach (string question in equestion.answers)
{
    Console.WriteLine(question);
}
