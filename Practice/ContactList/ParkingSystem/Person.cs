﻿namespace ParkingSystem
{
    public class Person
    {
       
        public string Embg { get; set; }    
        public string Name { get; set; }
        public string Surname { get; set; }

    public int Age { get; set; }    
        public string Address { get; set; }
        public Person() { }
        public Person(string embg, string name, string surname, int age, string address)
        {
            Embg = embg;
            Name = name;
            Surname = surname;
            Age = age;
            Address = address;
        }
    }
}