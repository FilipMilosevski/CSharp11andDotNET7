

uint naturalNumber = 23;

int integerNumber = -23;

float realNumber = 2.3F;

double anotherRealNumber = 2.3;



// three variables that store the number 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// check the three variables have the same value
// both statements output true 
//Console.WriteLine($"{decimalNotation == binaryNotation}");
//Console.WriteLine($"{decimalNotation == hexadecimalNotation}");



Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}




Console.WriteLine("Using DECIMALS:");
decimal c = 0.1M;
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}



Console.WriteLine("Practice");
decimal aa = 0.9M;
decimal bb = 0.9M;
if ( aa+bb == 1.8M)
{
    Console.WriteLine($"{aa} + {bb} equals {1.8M}");
}
else
{
    Console.WriteLine($"{aa} + {bb} does NOT equal {1.8M}");
}


decimal x = 1.5M;
decimal y = 1.5M;
if (x+y == 3.0M)
{
    Console.WriteLine($"{x} + {y} equals  {3.0M}");
}
else
{
    Console.WriteLine($"{x} + {y} does NOT equal {3.0M}");
}