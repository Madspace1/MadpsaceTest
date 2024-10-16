using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14_07
{
    public class Animal
    {
        private string _name;

        public Animal(string name, int age, bool isDomestic)
        {
            Name = name;
            Age = age;
            IsDomestic = isDomestic;
        }

        public string Name 
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public int Age { get; }
        
        public DateTime DateOfPurchase { get; set; }

        public bool IsDomestic { get; }

        public bool IsAgressive { get; set; }
    }
}
