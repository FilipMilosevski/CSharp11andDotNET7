using System.Runtime.Intrinsics.X86;
using System.Security.Claims;

//SectionTitle("1 First example - How to write and read text file using streamwriter and streamreader");
//string file = @"C:\ManagingFiles\csharpfile1.txt";
//using (StreamWriter writer = new StreamWriter(file))
//{
//    writer.WriteLine("FILIP");
//    writer.WriteLine("MILOSEVSKI");
//    writer.WriteLine("SKOPJE");

//}
//using (StreamReader reader = new StreamReader(file))
//{
//    Console.WriteLine(reader.ReadToEnd());
//}
////Console.ReadKey();



//SectionTitle("1 Second example - How to write and read text file using streamwriter and streamreader");

//string file1 = @"C:\ManagingFiles\csharpfile2.txt";
//using (StreamWriter writer = new StreamWriter(file1))
//{
//    writer.Write("Hello");
//    writer.WriteLine("Hellow StreamWriter     Class");
//    writer.WriteLine("How are you!");
//}
//using (StreamReader reader = new StreamReader(file1))
//{
//    Console.WriteLine(reader.ReadToEnd());
//}
//Console.ReadKey();


//string file2 = @"C:\ManagingFiles\FILIPS.txt";
//using (TextWriter writer = File.CreateText(file2))
//{
//    writer.WriteLine("Hello TextWriter!");
//    writer.WriteLine("File Handling Tutorial");
//}
//Console.WriteLine("Entry stored successfull!");
//Console.ReadKey();







//SectionTitle("2 First way - Make and delete folder");
//string path = @"C:\Vezba\";
//DirectoryInfo dir = new DirectoryInfo(path);

//if (dir.Exists)
//{
//    Console.WriteLine("{0} Directory is already exists", path);
//    Console.WriteLine("Directory Name : " + dir.Name);
//    Console.WriteLine("Path : " + dir.FullName);
//    Console.WriteLine("Directory is created on : " + dir.CreationTime);
//    Console.WriteLine("Directory is Last Accessed on " + dir.LastAccessTime);
//}
//else
//{
//    dir.Create();
//    Console.WriteLine(path + "Directory is created successfully");
//}

//dir.Delete();




//SectionTitle("2 Second way - Make and delete folder");

//string path = @"C:\Vezba\";
//DirectoryInfo dir = new DirectoryInfo(path);
//try
//{
//    if (dir.Exists)
//    {
//        Console.WriteLine("{0} Directory is already exists", path);
//        Console.WriteLine("Directory Name : " + dir.Name);
//        Console.WriteLine("Path : " + dir.FullName);
//        Console.WriteLine("Directory is created on : " + dir.CreationTime);
//        Console.WriteLine("Directory is Last Accessed on " + dir.LastAccessTime);
//    }
//    else
//    {
//        dir.Create();
//        Console.WriteLine(path + "Directory is created successfully");
//    }
//    //Delete this directory
//    Console.WriteLine("If you want to delete this directory press small y. Press any key to exit.");
//    try
//    {
//        char ch = Convert.ToChar(Console.ReadLine());
//        if (ch == 'y')
//        {
//            if (dir.Exists)
//            {
//                dir.Delete();
//                Console.WriteLine(path + "Directory Deleted");
//            }
//            else
//            {
//                Console.WriteLine(path + "Directory Not Exists");
//            }
//        }
//    }
//    catch
//    {
//        Console.WriteLine("Press Enter to Exit");
//    }
//    Console.ReadKey();
//}
//catch (DirectoryNotFoundException d)
//{
//    Console.WriteLine("Exception raised : " + d.Message);
//}





//SectionTitle("3 StringWriter and StringReader");

//string path = @"C:\ManagingFiles\fileinfonNEW.txt";
//FileInfo file = new FileInfo(path);
////Create File
//using (StreamWriter sw = file.CreateText())
//{
//    sw.WriteLine("Hello FileInfo");
//}
////ova e za kopija
//file.CopyTo(@"C:\ManagingFiles\kopija1.txt");
//Console.WriteLine("The file has been copied");
//file.Delete();

