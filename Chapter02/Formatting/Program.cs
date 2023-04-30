

int numberOfApples = 12;
decimal pricePerApple = 0.35M;
Console.WriteLine(
  format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,       
    arg1: pricePerApple * numberOfApples);
Console.WriteLine(formatted);


Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

int num1 = 15;
decimal num2 = 0.52M;

Console.WriteLine(
    format: "{0} oranges cost {1} dollars",
    arg0: num1,
    arg1: num2 * num1
    );

Console.WriteLine($"{num1} lemons cost {num2*num1} dollars");





int n1 = 15;
decimal n2 = 1.2M;
Console.WriteLine(
    format:"{0} pens cost {1} dollars",
    arg0: n1,
    arg1: n2 * n1);

string f = string.Format(
    format: "{0} cubes cost {1} dollars",
    arg0: n1,
    arg1: n2 * n1);
Console.WriteLine(f);

Console.WriteLine($"{n1} bears cost {n2 * n1} dollars");

Console.WriteLine(".................................");
