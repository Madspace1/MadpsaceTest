using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_classes__car_
{
    internal class Car
    {
        public string Make { get; set;}
        public string Model { get; set; }
        public int Year { get; set; }
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public string GetCarInfo()
        {
            return $"{Make} {Model} {Year}";
        }
    }
}
