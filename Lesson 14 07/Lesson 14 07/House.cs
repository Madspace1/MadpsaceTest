using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_07
{
    internal class House
    {
        public string Adress { get; set; }
        public double Area { get; set; }
        public int Rooms { get; set; }
        public House(string adress, double area, int rooms) 
        {
            Adress = adress;
            Area = area;
            Rooms = rooms;
        }

        public override string ToString()
        {
            return Adress + Area + Rooms;
        }
    }
}
