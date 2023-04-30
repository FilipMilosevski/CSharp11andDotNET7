

using System.Security.Cryptography;

//static int f1 (int p1, int p2)
//{
//    int res = p1 + p2;
//    return res;
//}

//WriteLine(f1(2, 5));
//WriteLine(f1(5, 1));
//WriteLine(f1(3, 5));

//static void f2 (int p1, int p2)
//{
//    int res = p1+p2;
//    WriteLine(res);
//}
//f2(2,5);
//f2(5,1);
//f2(3,5);


//static int sss (int num1, int num2)
//{
//    int total; 
//    total = num1 + num2;
//    return total;
//}
//WriteLine("ENTER FIRST NUMBER");
//int n1 = Convert.ToInt32(ReadLine());
//WriteLine("ENTER SECOND NUMBER");
//int n2 = Convert.ToInt32(ReadLine());
//WriteLine("The sum of two numbers is: {0} ", sss(n1, n2));


//static int SpaceCount(string str)
//{
//    int spccstr = 0;
//    string str1;
//    for (int i = 0;i < str.Length; i++)
//    {
//        str1 = str.Substring(i, 1);
//        if (str1 == " ")
//            spccstr++;
//    }
//    return spccstr;
//}
//WriteLine("Write a function to count spaces");
//WriteLine("Input a string");
//string str2;
//str2 = ReadLine();
//WriteLine("\"" + str2 + "\"" + "\"contains {0} spaces", SpaceCount(str2));



//static int Sum(int[] arr1)
//{
//    int tot = 0;
//    for (int i = 0; i < arr1.Length; i++)
//    {
//        tot+= arr1[i];
//        return tot;
//    }
//}
//int[] arr1 = new int[5];
//WriteLine("Calculate the sum of elements in array");
//WriteLine("Input 5 elements in array");
//for (int j = 0; j < 5; j++)
//{
//    WriteLine("elemeent-{0}:", j);
//    arr1[j] = Convert.ToInt32(ReadLine());
//}
//WriteLine("The sum of the elements in the array is:{0} ", Sum(arr1));



//Calculate the sum of the elements in an array
//static int Sum(int[] arr1)
//{
//    int tot = 0;
//    for (int i = 0; i < arr1.Length; i++)
//        tot += arr1[i];
//    return tot;
//}
//int[] arr1 = new int[5];
//Console.Write("\n\nFunction : Calculate the sum of the elements in an array :\n");
//Console.Write("--------------------------------------------------------------\n");
//Console.Write("Input 5 elements in the array :\n");
//for (int j = 0; j < 5; j++)
//{
//    Console.Write("element - {0} : ", j);
//    arr1[j] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("The sum of the elements of the array is {0}", Sum(arr1));



//Change the position on two numbers
//static void interchange (ref int num1, ref int num2)
//{
//    int newnum;
//    newnum = num1;
//    num1 = num2;
//    num2 = newnum;

//}
//int a1, a2;
//Console.Write("Enter a number");
//a1 = Convert.ToInt32(ReadLine());
//Console.Write("Enter a number");
//a2 = Convert.ToInt32(ReadLine());
//interchange(ref a1, ref a2);
//Console.WriteLine("Now the first number is {0}, and the second number is: {1}", a1, a2);


static int PowerRaising(int num, int exp)
{
    int rvalue = 1;
    int i;
    for (i = 1; i <= exp; i++)
        rvalue = rvalue * num;
    return rvalue;
}
int n1;
int exp1;
Console.Write("\n\nFunction : To calculate the result of raising an integer number to another :\n");
Console.Write("--------------------------------------------------------------------------------\n");
Console.Write("Input Base number: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the Exponent : ");
exp1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2} ", n1, exp1, PowerRaising(n1, exp1));


WriteLine("FILIP");
WriteLine("Fico");