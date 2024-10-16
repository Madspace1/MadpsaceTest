using System.Collections.Generic;
using MAD_36_students;

student_class student1 = new student_class("Bogdan", "Pavuk", 66);
student1.Grades.Add(25);
student1.Grades.Add(32);
student1.Grades.Add(45);

student_class student2 = new student_class("Roman", "Kochalo", 32);
student2.Grades.Add(70);
student2.Grades.Add(84);
student2.Grades.Add(88);

student_class student3 = new student_class("Eduard", "Uskov", 32);
student3.Grades.Add(55);
student3.Grades.Add(75);
student3.Grades.Add(80);
//1 info
Console.WriteLine($"Student: {student1.FirstName} {student1.LastName}, Age: {student1.Age}");
Console.WriteLine("Grades: " + string.Join(", ", student1.Grades));
Console.WriteLine($"The avarage grade is {Math.Round(student1.CalculateAverageGrade(),2)}");
Console.WriteLine();

//2 info
Console.WriteLine($"Student: {student2.FirstName} {student2.LastName}, Age: {student2.Age}");
Console.WriteLine("Grades: " + string.Join(", ", student2.Grades));
Console.WriteLine($"The avarage grade is {Math.Round(student2.CalculateAverageGrade(), 2)}");
Console.WriteLine();

//3 info
Console.WriteLine($"Student: {student3.FirstName} {student3.LastName}, Age: {student3.Age}");
Console.WriteLine("Grades: " + string.Join(", ", student3.Grades));
Console.WriteLine($"The avarage grade is {Math.Round(student3.CalculateAverageGrade(),2)}");
Console.WriteLine();
