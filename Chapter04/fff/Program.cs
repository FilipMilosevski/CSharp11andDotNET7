

static int factorial (int n)
{
    if (n == 0) return 1;
    return n *  factorial(n -1);
}

    Console.WriteLine("Vnesi broj: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("{0}={1}", n, factorial(n));




static int Factorial(int number)
{
    if (number < 0)
    {
        throw new ArgumentException(message:
            $"The factorial function is defined for non-negative integers only. Input: {number}",
            paramName: nameof(number));
    }
    else if (number == 0)
    {
        return 1;
    }
    else
    {
        checked
        {
            return number * Factorial(number - 1);

        }
    }


}
int factorialOfFive = Factorial(5);
Console.WriteLine(factorialOfFive);





 static int Factorial1(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * Factorial1(n - 1);
    }
}
int f1 = Factorial1(7);
Console.WriteLine(f1);


Console.WriteLine("VNESI SEGA ");
int f2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial1(f2));

static void Factorial123(int n, ref int result)
{
    if (n == 0)
    {
        result = 1;
    }
    else
    {
        Factorial123(n - 1, ref result);
        result *= n;
    }
}


int result = 0;
Factorial123(5, ref result);

Console.WriteLine(result); // Outputs 120






static void CountDown(int n)
{
    if (n == 0)
    {
        Console.WriteLine("Blast off!");
    }
    else
    {
        Console.WriteLine(n);
        CountDown(n - 1);
    }
}

CountDown(4);