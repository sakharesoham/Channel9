using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingwithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Tata";
            car1.Model = "Sumo";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Honda";
            car2.Model = "Jazz";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Title = "Alchemist";
            b1.Author = "Soham";
            b1.ISBN = "0-76-8534";

            //create arraylist
            /* ArrayList myarraylist = new ArrayList();
             myarraylist.Add(car1);
             myarraylist.Add(car2);
             myarraylist.Add(b1);
             myarraylist.Remove(b1);

             foreach (Car car in myarraylist)
             {
                 Console.WriteLine(car.Model);
             }*/

            /* List<Car> mylist = new List<Car>();
             mylist.Add(car1);
             mylist.Add(car2);

             foreach (Car car in mylist)
             {
                 Console.WriteLine(car.Model);
             }*/

            /*Dictionary<string, Car> mydictionary = new Dictionary<string, Car>();
            mydictionary.Add(car1.VIN, car1);
            mydictionary.Add(car2.VIN, car2);

            Console.WriteLine(mydictionary["A1"].Make);*/

            List<Car> mylist = new List<Car>()
            {
                new Car{Make="Suzuki",Model="Desire",VIN="C3"},
                new Car{Make="Hynudai",Model="Creta",VIN="D4"}
            };

            
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
