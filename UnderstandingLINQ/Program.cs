using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> mycars = new List<Car>() {
            new Car() { VIN = "A1", Make = "BMW", Model = "550i", Year = 2010, StickerPrice = 550000 },
            new Car() { VIN = "B2", Make = "Toyota", Model = "Fortuner", Year = 2015, StickerPrice = 600000 },
            new Car() { VIN = "C3", Make = "BMW", Model = "720d", Year = 2017, StickerPrice = 450000 },
            new Car() { VIN = "D4", Make = "Audi", Model = "A8L", Year = 2015, StickerPrice = 530000 },
            new Car() { VIN = "E5", Make = "BMW", Model = "745li", Year = 2019, StickerPrice = 650000 },
                };

            /*var bmws = from car in mycars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;

            var orderedCars = from car in mycars
                              orderby car.Year 
                              select car;*/

            //            var bmws = mycars.Where(p => p.Make == "BMW" && p.Year == 2010);
            // var orderedCar = mycars.OrderByDescending(p => p.Year);

            /* var FirstBMW = mycars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
             Console.WriteLine(FirstBMW.Model);*/

            // Console.WriteLine(mycars.TrueForAll(p=>p.Year>2010));
            // mycars.ForEach(p => Console.WriteLine(string.Format(new CultureInfo("en-US"), "{0} {1:C0}",p.VIN,p.StickerPrice)));
            //Console.WriteLine(mycars.Sum(p=>p.StickerPrice));
            // Console.WriteLine(mycars.GetType());

            try { }
            catch(FileNotFoundException ex) { }
            catch(DirectoryNotFoundException ex) { }
            finally { }

            var newcars = from car in mycars
                          where car.Make == "Toyota"
                          && car.Year == 2015
                          select new { car.Make, car.Model };

            
            foreach (var car in newcars)
            {
                Console.WriteLine("{0}", car.Model);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
