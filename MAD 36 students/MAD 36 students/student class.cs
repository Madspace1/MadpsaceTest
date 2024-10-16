using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MAD_36_students
{
    internal class student_class
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public int Age { get; set; }
        public List<int> Grades { get; set;}

        public student_class(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Grades = new List<int>();
        }
        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
                return 0;

            return Grades.Average();
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + ", " + Age + " years old";
        }
       
    }
} 
