using Newtonsoft.Json;
using static System.Console;
using NewtonsoftCompany;


static void SectionTitle(string title)
{
    ConsoleColor previousColor = ForegroundColor;
    ForegroundColor = ConsoleColor.Yellow;
    WriteLine("*");
    WriteLine($"{title}");
    WriteLine("*");
    ForegroundColor = previousColor;
}
SectionTitle("COMPANIES");


List<Company> companies = new List<Company>()
{
    new Company()
    {
        companyName = "Apple",
        firstName = "Stefan",
        lastName = "Nedelkovski",
        position = "CEO",
        country = "Macedonia",
        klas = new List<Company>()
        {
            new Company()
            {
                companyName = "Apple",
                firstName = "Martin",
                lastName = "Stojanovski",
                position = "Sales",
                country = "Belgium"
            },
            new Company()
            {
                companyName = "Apple",
                firstName = "Mirko",
                lastName = "Ordanovski",
                position = "Mechanic",
                country = "Spain"
            },
            new Company()
            {
                companyName = "Apple",
                firstName = "Orce",
                lastName = "Jankovski",
                position = "Delivery",
                country = "Japan"
            },
            new Company()
            {
                companyName = "Apple",
                firstName = "Dimo",
                lastName = "Arsovski",
                position = "Accountant",
                country = "England"
            },
            new Company()
            {
                companyName = "Apple",
                firstName = "Martin",
                lastName = "Stojanovski",
                position = "Architect",
                country = "Hungary"
            }
        }
    },
    new Company()
    {
        companyName = "Instagram",
        firstName = "Marijan",
        lastName = "Dimitrov",
        position = "CEO",
        country = "Germany",
        klas = new List<Company>()
        {
            new Company()
            {
                companyName = "Instagram",
                firstName = "Martin",
                lastName = "Stojanovski",
                position = "Designer",
                country = "Belgium"
            },
            new Company()
            {
                companyName = "Instagram",
                firstName = "Filip",
                lastName = "Manasiev",
                position = "Developer",
                country = "Scotland"
            },
            new Company()
            {
                companyName = "Instagram",
                firstName = "Orce",
                lastName = "Jankovski",
                position = "Delivery",
                country = "Russia"
            }            
        }
    },
     new Company()
    {
        companyName = "Dhl",
        firstName = "Vlado",
        lastName = "Siskovski",
        position = "CEO",
        country = "France",
        klas = new List<Company>()
        {
            new Company()
            {
                companyName = "Instagram",
                firstName = "Martin",
                lastName = "Stojanovski",
                position = "Delivery",
                country = "Belgium"
            }          
        }
    },
     new Company()
    {
        companyName = "Google",
        firstName = "Boris",
        lastName = "Evfemov",
        position = "CEO",
        country = "France",
        klas = new List<Company>()
        {
            new Company()
            {
                companyName = "Google",
                firstName = "Aleksandar",
                lastName = "Martinoski",
                position = "Delivery",
                country = "Estonia"
            },
            new Company()
            {
                companyName = "Google",
                firstName = "Sotir",
                lastName = "Nikoloski",
                position = "Sales",
                country = "Wales"
            },
            new Company()
            {
                companyName = "Google",
                firstName = "Jakov",
                lastName = "Ristev",
                position = "Electrician",
                country = "Qatar"
            },
            new Company()
            {
                companyName = "Google",
                firstName = "Trajce",
                lastName = "Kovacevski",
                position = "Teacher",
                country = "Norway"
            }
        }
    },
     new Company()
    {
        companyName = "Walmart",
        firstName = "Risto",
        lastName = "Ilkovski",
        position = "CEO",
        country = "Cuba",
        klas = new List<Company>()
        {
            new Company()
            {
                companyName = "Walmart",
                firstName = "Martin",
                lastName = "Stojanovski",
                position = "Analyst",
                country = "Peru"
            },
            new Company()
            {
                companyName = "Walmart",
                firstName = "Oliver",
                lastName = "Popovski",
                position = "Manager",
                country = "Argentina"
            }
        }
    }



};




//string json = JsonConvert.SerializeObject(companies, Formatting.Indented);

//WriteLine(json);

//File.WriteAllText(@"C:\CSharp11andDotNET7\Chapter09\Newtonsoft Company\bin\Debug\net7.0\companies.json", json);

//using(StreamWriter file = File.CreateText(@"C:\CSharp11andDotNET7\Chapter09\Newtonsoft Company\bin\Debug\net7.0\companies.json"))
//{
//    JsonSerializer jss = new JsonSerializer();
//    jss.Serialize(file, companies);
//}

//List<Company> companyList = JsonConvert.DeserializeObject<List<Company>>(json);


//SectionTitle("IMINJA NA CEO");


//if(companyList != null)
//{
//    foreach (Company com in companyList)
//    {
//        WriteLine($"{com.firstName} {com.lastName} is {com.position} at {com.companyName}");
//    }
//}


//SectionTitle("BROJ NA VRABOTENI");

//if(companyList != null)
//{
//    foreach (Company com in companyList)
//    {
//        if (com != null)
//        {
//            int empCount = com.klas != null ? com.klas.Count : 0;
//            WriteLine($"{com.companyName} has {empCount} emplloyees");
//        }
//    }
//}


//SectionTitle("BROJ I IME NA VRABOTENI");

//if(companyList != null)
//{
//    foreach (Company com in companyList)
//    {
//        if(com != null)
//        {
//            int empCount = com.klas != null ? com.klas.Count : 0;
//            WriteLine($"{com.firstName} at {com.companyName} has {empCount} employees");
//            foreach (Company emp in com.klas)
//            {
//                WriteLine($"{emp.firstName.PadLeft(30)} is working at {com.companyName}");
//            }
//        }
//    }
//}






//string json = JsonConvert.SerializeObject(companies, Formatting.Indented);

//WriteLine(json);


//File.WriteAllText(@"C:\CSharp11andDotNET7\Chapter09\Newtonsoft Company\bin\Debug\net7.0\companies.json", json);

//using(StreamWriter file = File.CreateText(@"C:\CSharp11andDotNET7\Chapter09\Newtonsoft Company\bin\Debug\net7.0\companies.json"))
//{
//    JsonSerializer jss = new JsonSerializer();
//    jss.Serialize(file, companies);
//}

//List<Company> companyList = JsonConvert.DeserializeObject<List<Company>>(json);


//SectionTitle("IMINJA NA CEO");

//if(companyList != null)
//{
//    foreach (Company com in companyList)
//    {
//        WriteLine($"{com.firstName} {com.lastName} is {com.position} at {com.companyName}");
//    }
//}


//SectionTitle("BROJ NA VRABOTENI");

//if(companyList != null)
//{
//    foreach (Company com in companyList)
//    {
//        int empNum = com.klas != null ? com.klas.Count : 0;
//        WriteLine($"{com.firstName} {com.lastName} at {com.companyName} has {empNum} employees");
//    }
//}

//SectionTitle("IMINJA I BROJ NA VRABOTENI");

//if(companyList != null)
//{
//    foreach (Company com in companyList)
//    {
//        int empNum = com.klas != null ? com.klas.Count : 0;
//        WriteLine($"{com.firstName} {com.lastName} at {com.companyName} has {empNum} employees");
//        if(com.klas != null)
//        {
//            foreach (Company emp in com.klas)
//            {
//                WriteLine($"{emp.firstName.PadLeft(30)} {emp.lastName} is working at {com.companyName}");
//            }
//        }
//    }
//}



// prv nacin
//if(companyList != null)
//{
//    foreach (Company com in companyList)
//    {
//        if(com != null)
//        {
//            int empCount = com.klas != null ? com.klas.Count : 0;
//            WriteLine($"{com.firstName} at {com.companyName} has {empCount} employees");
//            foreach (Company emp in com.klas)
//            {
//                WriteLine($"{emp.firstName.PadLeft(30)} is working at {com.companyName}");
//            }
//        }
//    }
//}

string json = JsonConvert.SerializeObject(companies, Formatting.Indented);
WriteLine(json);

File.WriteAllText(@"C:\CSharp11andDotNET7\Chapter09\Newtonsoft Company\bin\Debug\net7.0\companies.json", json);

using (StreamWriter file = File.CreateText(@"C:\CSharp11andDotNET7\Chapter09\Newtonsoft Company\bin\Debug\net7.0\companies.json"))
{
    JsonSerializer jss = new JsonSerializer();
    jss.Serialize(file, companies);
}

List<Company> companyList = JsonConvert.DeserializeObject<List<Company>>(json);

SectionTitle("IMINJA NA CEO");

if(companyList != null)
{
    foreach (Company com in companyList)
    {
        WriteLine($"{com.firstName} {com.lastName} is {com.position} at {com.companyName}");
    }
}

SectionTitle("BROJ NA VRABOTENI");

if(companyList != null)
{
    foreach (Company com in companyList)
    {
        int empNum = com.klas != null ? com.klas.Count : 0;
        WriteLine($"{com.firstName} {com.lastName} at {com.companyName} has {empNum} employees");
    }
}

SectionTitle("BROJ I IME NA VRABOTENI");

if (companyList != null)
{
    foreach (Company com in companyList)
    {
        int empNum = com.klas != null ? com.klas.Count : 0;
        WriteLine($"{com.firstName} {com.lastName} at {com.companyName} has {empNum} employees");
        if (com != null)
        {
            foreach (Company emp in com.klas)
            {
                WriteLine($"{emp.firstName.PadLeft(30)} is working at {com.companyName}");
            }
            WriteLine($"At {com.companyName} are working total of {empNum} employees");

        }
    }
}


SectionTitle("FILIP");
SectionTitle("FILIPSON")