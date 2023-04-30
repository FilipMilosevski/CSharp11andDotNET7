using Excercises;
using System.Runtime.Intrinsics.X86;

int a1 = AreaOfTriangle.Triangle(3, 2);
WriteLine(a1);
int a2 = AreaOfTriangle.Triangle(7, 4);
WriteLine(a2);
int a3 = AreaOfTriangle.Triangle(10, 10);
WriteLine(a3);

int min1 = AreaOfTriangle.Minutes(5);
WriteLine(min1);
int min2 = AreaOfTriangle.Minutes(3);
WriteLine(min2);
int min3 = AreaOfTriangle.Minutes(2);
WriteLine(min3);

bool a = AreaOfTriangle.Equal(5);
WriteLine(a);
bool b = AreaOfTriangle.Equal(0);
WriteLine(b);
bool c = AreaOfTriangle.Equal(-2);
WriteLine(c);

string c1 = AreaOfTriangle.Something(" is better than nothing");
WriteLine(c1);
string c2 = AreaOfTriangle.Something(" Bob Jane");
WriteLine(c2);
string c3 = AreaOfTriangle.Something(" something");
WriteLine(c3);

bool t = AreaOfTriangle.TrueFalse(true);
WriteLine(t);
bool f = AreaOfTriangle.TrueFalse(false);
WriteLine(f);

bool num1 = AreaOfTriangle.NumbersTrueFalse(5, 2);
WriteLine(num1);
bool num2 = AreaOfTriangle.NumbersTrueFalse(2, 2);
WriteLine(num2);
bool num3 = AreaOfTriangle.NumbersTrueFalse(1, 0);
WriteLine(num3);

int b1 = AreaOfTriangle.Basketball(1, 1);
WriteLine(b1);
int b2 = AreaOfTriangle.Basketball(7, 5);
WriteLine(b2);
int b3 = AreaOfTriangle.Basketball(38, 8);
WriteLine(b3);




AreaOfTriangle.sum1(4, " minutes");


//second way
//static void Sum(int num, string name)
//{
//    int total = (num * 60);
//    var s = total + name;
//    Console.WriteLine(s);
//};
//Sum(1, " minutes");
//Sum(5, " minutes");


