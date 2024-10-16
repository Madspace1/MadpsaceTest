using System;

Console.WriteLine("Please enter your first name");
string firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name");
string lastName = Console.ReadLine();

Console.WriteLine("Please enter your age");
string ageString = Console.ReadLine();
int age = int.Parse(ageString);

//Console.WriteLine("Hello, " + firstName + " " + lastName + ", " + "you are " + age + " years old!");
Console.WriteLine($"Hello, {firstName} {lastName}, you are {age} years old!");
