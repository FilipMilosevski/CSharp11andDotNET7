
using Practice;


Console.WriteLine();
Console.WriteLine(Directory.GetCurrentDirectory());
Console.WriteLine("------------------");


//ReadATextFile.CreateFile();
//ReadATextFile.ReadFile();


ReadATextFileWithUsing rd = new ReadATextFileWithUsing(Path.Combine(Directory.GetCurrentDirectory(), "input.txt"));
rd.ReadFile();