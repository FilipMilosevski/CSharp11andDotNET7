using Newtonsoft.Json;
using NewtonsoftCars;
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
