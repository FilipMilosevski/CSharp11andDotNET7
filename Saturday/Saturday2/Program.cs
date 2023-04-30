//1 Check if two integers are equal or not
//int int1, int2;
//Write("\n\n");
//Write("Check if two integers are equal or not");
//Write("===================");
//Write("\n\n");
//Write("Input first number :   ");
//int1 = Convert.ToInt32(ReadLine());
//Write("Input second number :   ");
//int2 = Convert.ToInt32(ReadLine());
//if (int1 == int2)
//    WriteLine("{0} and {1} are equal. \n", int1, int2);
//else
//    WriteLine("{0} and {1} are NOT equal. \n", int1, int2);




//2 The number is positive or negative
//int num;
//Write("\n\n");
//Write("Check the number is positive or negative");
//Write("==================================");
//Write("\n\n");
//Write("Input some integer");
//num = Convert.ToInt32(ReadLine());
//if (num >= 0)
//    Write("{0} is a positive number. \n", num);
//else
//    Write("{0} is a negative number. \n", num);



//3 Categorize the height of the people
//float perHeight;
//Write("\n\n");
//Write("Accept the height of a person in centimeter and categorize them:\n");
//Write("=====================================");
//Write("\n\n");
//Write("Input the height of the person (in centimeters):");
//perHeight = Convert.ToInt32(ReadLine());
//if (perHeight < 150.0)
//    Write("The person is Dwarf. \n\n");
//else if ((perHeight >= 150.0) && (perHeight <= 165.0))
//{
//    Write("The person is with average height. \n\n");
//}
//else if ((perHeight >= 165.0) && (perHeight <= 195.0))
//{
//    Write("The person is taller. \n\n");
//}
//else
//    Write("The person is with abnormal height");



//4 Categorize school success
//int p, c, m;
//Write("\n\n");
//Write("Find eligibility for admission :\n");
//Write("=================================");
//Write("\n\n");
//Write("Eligibility criteria: \n\n");
//Write("Marks in Maths >=65\n");
//Write("and Marks in Phy >=55\n");
//Write("and Marks in Chem >=50\n");
//Write("and Total in all three subjects >=180\n");
//Write("ant Total in Maths an Physics >=140\n");
//Write("==============================");
//Write("Input the marks obtained in Physics:");
//p = Convert.ToInt32(ReadLine());
//Write("Input the marks obtained in Chemistry:");
//c = Convert.ToInt32(ReadLine());
//Write("Input the marks obtained in Maths:");
//m = Convert.ToInt32(ReadLine());
//Write("Total marks of Maths,Physics and Chemistry: {0}\n", m + p + c);
//Write("Total marks of Maths and Physics: {0}\n", m + p);

//if (m >= 65)
//    if (p >= 55)
//        if (c >= 50)
//            if ((m + p + c) >= 180 || (m + p) >= 140)
//                Write("The candidate is eligible for admission.\n");
//            else
//                Write("The candidate is not eligible.\n");
//            else 
//                Write("The candidate is not eligible.\n");
//            else
//                Write("The candidate is not eligible.\n");
//            else
//                Write("The candidate is not eligible.\n");




//5 Find the sum of first 10 natural numbers
//int j, sum = 0;
//Write("Find the sum of first 10 natural numbers: \n");
//Write("==================================");
//Write("\n\n");
//Write("The first 10 natural numbers are: \n");
//for (j = 1; j <= 10; j++)
//{
//    sum = sum + j;
//    Write("{0}", j);
//}





//6 Read 10 numbers and calculate sum and average
//int i, n, sum = 0;
//double avg;
//Write("\n\n");
//Write("Input 10 numbers:\n\n");
//for (i = 1; i<=10;i++)
//{
//    Write("Number-{0}:", i);
//    n = Convert.ToInt32(ReadLine());
//    sum += n;
//}
//avg = sum / 10.0;
//Write("The sum of 10 numbers is: {0}\n The average is: {1}\n",sum,avg);




//7 Multiplication Table
//int i = 1, n = 5, product;
//do
//{
//    product = n * i;
//    Console.WriteLine("{0} * {1} = {2}", n, i, product);
//    i++;
//} while (i <= 10);
//int sum = 0;
//int n1;
//int n2 = 0;
//Console.Write("Input the 5 numbers : \n");
//while (i < 5)
//{
//    Console.Write("Number-{0} :", i);
//    n = Convert.ToInt32(Console.ReadLine());
//    if (n > n2)
//    {
//        n2 = n;
//   }
//    sum += n;
//    i++;
//}
//int sum2 = sum - n2;
//if (n2 == sum2)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}



//8 Read and Print elements of an array
//int[] arr = new int[10];
//int i;
//Console.Write("\n\nRead and Print elements of an array:\n");
//Console.Write("-----------------------------------------\n");
//Console.Write("Input 10 elements in the array :\n");
//for (i = 0; i < 10; i++)
//{
//    Write("element - {0} : ", i);
//    arr[i] = Convert.ToInt32(ReadLine());
//}
//Write("\nElements in array are: ");
//for (i = 0; i < 10; i++)
//{
//    Write("{0}  ", arr[i]);
//}
//Write("\n");
//int[] a = new int[100];

//int n, sum = 0;
//Write("\n\nFind sum of all elements of array:\n");
//Write("--------------------------------------\n");
//Write("Input the number of elements to be stored in the array :");
//n = Convert.ToInt32(ReadLine());
//Write("Input {0} elements in the array :\n", n);
//for (i = 0; i < n; i++)
//{
//    Write("element - {0} : ", i);
//    a[i] = Convert.ToInt32(ReadLine());
//}
//for (i = 0; i < n; i++)
//{
//    sum += a[i];
//}
//Write("Sum of all elements stored in the array is : {0}\n\n", sum);



//9 Count total numbers of duplicate elements in an array
//int[] arr1 = new int[100];
//int[] arr2 = new int[100];
//int[] arr3 = new int[100];
//int s1, s2, mm = 1, ctr = 0;
//int i, j;
//Write("\n\nCount total number of duplicate elements in an array:\n");
//Write("---------------------------------------------------------\n");
//Write("Input the number of elements to be stored in the array :");
//s1 = Convert.ToInt32(ReadLine());
//Write("Input {0} elements in the array :\n", s1);
//for (i = 0; i < s1; i++)
//{
//    Write("element - {0} : ", i);
//    arr1[i] = Convert.ToInt32(ReadLine());
//}
///*----------------- copy in other array ------------------------------------*/
//for (i = 0; i < s1; i++)
//{
//    arr2[i] = arr1[i];
//    arr3[i] = 0;
//}
///*------------------- mark the elements are duplicate -------------------------*/
//for (i = 0; i < s1; i++)
//{
//    for (j = 0; j < s1; j++)
//    {
//        if (arr1[i] == arr2[j])
//        {
//            arr3[j] = mm;
//            mm++;
//        }
//    }
//    mm = 1;
//}
///*--------------- Prints the array ------------------------------------*/
//for (i = 0; i < s1; i++)
//{
//    if (arr3[i] == 2) { ctr++; }
//}
//Write("The number of duplicate elements is: {0} \n", ctr);
//Write("\n\n");



//10 Find maximum and minimum element in an array
//int[] arr1 = new int[100];
//int i, mx, mn, n;
//Write("\n\nFind maximum and minimum element in an array :\n");
//Write("--------------------------------------------------\n");
//Write("Input the number of elements to be stored in the array :");
//n = Convert.ToInt32(ReadLine());
//Write("Input {0} elements in the array :\n", n);
//for (i = 0; i < n; i++)
//{
//    Write("element - {0} : ", i);
//    arr1[i] = Convert.ToInt32(ReadLine());
//}
//mx = arr1[0];
//mn = arr1[0];
//for (i = 1; i < n; i++)
//{
//    if (arr1[i] > mx)
//    {
//        mx = arr1[i];
//    }
//    if (arr1[i] < mn)
//    {
//        mn = arr1[i];
//    }
//}
//Write("Maximum element is : {0}\n", mx);
//Write("Minimum element is : {0}\n\n", mn);
//DateTime[] dates = { DateTime.Now,
//                           new DateTime(2016, 8, 16, 9, 28, 0),
//                           new DateTime(2011, 5, 28, 10, 35, 0),
//                           new DateTime(1979, 12, 25, 14, 30, 0) };
//foreach (var date in dates)
//{
//    WriteLine("Day: {0:d} Time: {1:g}", date.Date, date.TimeOfDay);
//    WriteLine("Day: {0:d} Time: {0:t}\n", date);
//};




