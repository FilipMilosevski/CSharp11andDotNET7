///// 1 TYPE TEXT IN 2 LINES
//Console.WriteLine("Filip \nMilosevski");



///// 2 TEMPERATURE CONVERTER
//Console.WriteLine("Enter the temperture in celsius degrees");
//double temcel = Convert.ToDouble(Console.ReadLine());
//double temfar = temcel * 1.8 + 32;
//Console.WriteLine("The temperature of {0} in celsius is {1} farenheit", temcel ,  temfar);



///// 3 PRODUCT OF TWO NUMBERS
//int a = 5;
//int b = 3;
//int sum = a + b;
//Console.WriteLine(sum);



///// 4 PRODUCT OF DIVIDING TWO NUMBERS
//int a = 10;
//int b = 2;
//int sum = a / b;
//Console.WriteLine(sum);
//Console.WriteLine("The result from {0} divide with {1} is: {a/b}", a,b); // first way
//Console.WriteLine($"The sum is of {a} and {b} is: {a / b}");  // second way



///// 5 SWAP TWO NUMBERS
//int x = 20, y = 30;
//Console.WriteLine("Before swap:");
//Console.WriteLine("x = " + x + " and y = " + y);
//x = x * y;
//y = x / y;
//x = x / y;
//Console.WriteLine("After swap:");
//Console.WriteLine("x = " + x + " and y = " + y);      /// first way
//int a, b, c;
//a = 10;
//b = 5;
//c = a;
//a = b;
//b = c;
//Console.WriteLine($"{a},{b}");     /// second way



///// 6 MULTIPLICATION OF THREE NUMBERS
//int a, b, c;
//a = 3;
//b = 5;
//c = 7;
//Console.WriteLine($"{a*b*c}");



///// 7 CALCULATOR
//Console.WriteLine("Enter first number: ");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter second number: ");
//double b = Convert.ToDouble(Console.ReadLine());
//double c = a * b;
//double d = a / b;
//Console.WriteLine($"The product of {a} nad {b} is {c} \n the division of {a} and {b} is {d}");//first way

//Console.Write("Enter a number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter another number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
//Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
//Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
//Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
//Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);  //second way



/////8 ASK YOUR AGE
////int age;
////Console.Write("Enter your age ");
////age = Convert.ToInt32(Console.ReadLine());
////Console.Write("You look younger than {0} ", age);




///////9  CALCULATE YOUR SPEED AND DISTANCE
//float distance;
//float hour, min, sec;

//float timeSec;
//float mps;
//float kph, mph;

//Console.Write("Input distance(metres): ");
//distance = Convert.ToSingle(Console.ReadLine());
//Console.Write("Input timeSec(hour): ");
//hour = Convert.ToSingle(Console.ReadLine());
//Console.Write("Input timeSec(minutes): ");
//min = Convert.ToSingle(Console.ReadLine());
//Console.Write("Input timeSec(seconds): ");
//sec = Convert.ToSingle(Console.ReadLine());

//timeSec = (hour * 3600) + (min * 60) + sec;
//mps = distance / timeSec;
//kph = (distance / 1000.0f) / (timeSec / 3600.0f);
//mph = kph / 1.609f;

//Console.WriteLine("Your speed in metres/sec is {0}", mps);
//Console.WriteLine("Your speed in km/h is {0}", kph);
//Console.WriteLine("Your speed in miles/h is {0}", mph);       // first way



///// 10 REVERSE ORDER

//char letter,letter1,letter2;
//Console.Write("Input letter: ");
//letter = Convert.ToChar(Console.ReadLine());

//Console.Write("Input letter: ");
//letter1 = Convert.ToChar(Console.ReadLine());

//Console.Write("Input letter: ");
//letter2 = Convert.ToChar(Console.ReadLine());

//Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);



/////11 PERIMETAR
//double r, per_cir;
//double PI = 3.14;
//Console.WriteLine("Input the radius of the circle : ");
//r = Convert.ToDouble(Console.ReadLine());
//per_cir = 2 * PI * r;
//Console.WriteLine("Perimeter of Circle : {0}", per_cir);
//Console.Read();



/////12 LENGTH OF A STRING
//string s1 = "Computer";
//Console.WriteLine("The Length of the First String is : " + s1.Length);
//Console.WriteLine("ENTER A NAME: ");
//string name = Console.ReadLine();
//Console.WriteLine(name.Length);




///// 13 TOTAL WORDS IN A STRING
//string str;
//int i, wrd, l;
//Console.Write("\n\nCount the total number of words in a string :\n");
//Console.Write("------------------------------------------------------\n");
//Console.Write("Input the string : ");
//str = Console.ReadLine();
//l = 0;
//wrd = 1;
//while (l <= str.Length - 1)
//{
//    /* check whether the current character is white space or new line or tab character*/
//    if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
//    {
//        wrd++;
//    }
//    l++;
//}
//Console.Write("Total number of words in the string is : {0}\n", wrd);


///// 14 CONCATINATION OF TWO STRINGS
//string firstName = "John ";
//string lastName = "Doe";
//string name = string.Concat(firstName, lastName);
//Console.WriteLine(name);



///// 15 GREATER THAN YOUR AGE
//int age = 24;
//Console.WriteLine(age>18);



//Console.WriteLine(true ^ true);
//Console.WriteLine(false ^ false);
//Console.WriteLine(true ^false);
//Console.WriteLine(false ^ true);






/// XOR
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
//WriteToFile(formatted); // writes the string into a file

Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");



string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
string bananasCount = "56789";

Console.WriteLine(
    format: "{0,-30} {1,6}",
    arg0: "Name",
    arg1: "Count");
Console.WriteLine(
    format: "{0,-30} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);
Console.WriteLine(
    format: "{0,-30} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount);


