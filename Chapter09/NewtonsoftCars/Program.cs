using Newtonsoft.Json;
using NewtonsoftCars;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Console;



static void SectionTitle(string title)
{
    ConsoleColor previousColor = ForegroundColor;
    ForegroundColor = ConsoleColor.Yellow;
    WriteLine("*");
    WriteLine($"{title}");
    WriteLine("*");
    ForegroundColor = previousColor;
}
SectionTitle("CARS");

List<Cars> One = new List<Cars>()
{
    new Cars()
    {
        make = "Bmw",
        model = "F10",
        country = "Germany",
        year = 2011,
        fuelType = "Diesel",
        klas = new List<Cars>()
        {
            new Cars()
            {
                make = "Vw",
                model = "Golf",
                country = "Germany",
                year = 2015,
                fuelType = "Diesel"
            },
              new Cars()
            {
                make = "Audi",
                model = "A6",
                country = "Germany",
                year = 2017,
                fuelType = "Diesel"
            },
            
                  new Cars()
            {
                make = "Mercedes",
                model = "S500",
                country = "Germany",
                year = 2017,
                fuelType = "Gasoline"
            }

        }


    },
    new Cars()
    {
         make = "Citroen",
        model = "C4",
        country = "France",
        year = 2007,
        fuelType = "Gasoline",
        klas = new List<Cars>()
        {
            new Cars()
            {
                make = "Peugeot",
                model = "206",
                country = "France",
                year = 2003,
                fuelType = "Diesel"
            },
            new Cars()
            {
                make = "Renault",
                model = "Clio",
                country = "France",
                year = 2009,
                fuelType = "Diesel"
            }
        }
    },
    new Cars()
    {
        make = "Seat",
        model = "Ibiza",
        country = "Spain",
        year = 2007,
        fuelType = "Diesel",
       
    },
    new Cars()
    {
        make = "Honda",
        model = "Civic",
        country = "Japan",
        year = 2020,
        fuelType = "Gasoline",
        klas = new List<Cars>()
        {
            new Cars()
            {
                make = "Toyota",
                model = "Yaris",
                country = "Japan",
                year = 2005,
                fuelType = "Gasoline"
            },
            new Cars()
            {
                make = "Mazda",
                model = "6",
                country = "Japan",
                year = 2015,
                fuelType = "Diesel"
            },
            new Cars()
            {
                make = "Mitsubishi",
                model = "Colt",
                country = "Japan",
                year = 2008,
                fuelType = "Gasoline"
            }
        }
    },
    new Cars()
    {
        make = "Alfa Romeo",
        model = "Brera",
        country = "Italy",
        year = 2007,
        fuelType = "Gasoline",
        klas = new List<Cars>()
        {
            new Cars()
            {
                make = "Fiat",
                model = "Doblo",
                country = "Italy",
                year = 2011,
                fuelType = "Diesel"
            },
            new Cars()
            {
                make = "Lancia",
                model = "Delta",
                country = "Italy",
                year = 2009,
                fuelType = "Diesel"
            }
        }
    }
};

SectionTitle("Serializing JSON");

string json = JsonConvert.SerializeObject(One, Formatting.Indented);
WriteLine(json);
File.WriteAllText(@"\CSharp11andDotNET7\Chapter09\NewtonsoftCars\bin\Debug\net7.0\cars.json", json);

using (StreamWriter file = File.CreateText(@"\CSharp11andDotNET7\Chapter09\NewtonsoftCars\bin\Debug\net7.0\cars.json"))
{
    JsonSerializer jss = new JsonSerializer();
    jss.Serialize(file, One);
}

SectionTitle("IMINJA NA OSNOVACKI MARKI");
List<Cars> here = JsonConvert.DeserializeObject<List<Cars>>(json);
if (here != null)
{
    foreach (Cars car in here)
    {
        WriteLine(car.make);
    }
}

SectionTitle("KOLKU BRENDOVI IMAAT POD NIV");

if (here != null)
{
    foreach (Cars future in here)
    {
        int childCount = future.klas != null ? future.klas.Count : 0;
        WriteLine($"{future.make} has own the {childCount}");
    }
}

SectionTitle("IMINJA NA BRENDOVITE POD NIV");
if (here != null)
{
    foreach(Cars future in here)
    {
        int childCount = future.klas != null ? future.klas.Count : 0;
        WriteLine($"{future.make} has own the {childCount}");   
        if (future.klas != null)
        {
            foreach (Cars child in future.klas)
            {
                WriteLine($"{future.make.PadLeft(30)} has  owning the {child.make} ");
            }
            
                
            
        }
    }
}