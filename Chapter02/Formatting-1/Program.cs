﻿//using static System.Console;
int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
  format: "{0} apples cost {1:C}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
  format: "{0} apples cost {1:C}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples);
//WriteToFile(formatted); // writes the string into a file

WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");


string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
string bananasCount = "56789";

WriteLine(
    format: "{0,-30} {1,6}",
    arg0: "Name",
    arg1: "Count");
WriteLine(
    format: "{0,-30} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);
WriteLine(
    format: "{0,-30} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount);



Write("Type your first name and press Enter: ");
string firstName = ReadLine();

Write("Type your age and press Enter: ");
string age = ReadLine();

WriteLine($"Hello {firstName}, you look good for {age}.");





Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers);  

