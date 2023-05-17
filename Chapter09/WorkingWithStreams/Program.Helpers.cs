

partial class Program
{

    //static void MyMethod2()
    //{
    //    WriteLine("From Program.Helpers.CS");
    //}


    static void SectionTitle(string title)
    {
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine("*");
        WriteLine($"*{title}");
        WriteLine("*");
        ForegroundColor = previousColor;
    }
}