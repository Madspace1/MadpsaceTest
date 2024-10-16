Person roman = new Person();

string personName = roman.name;
int personAge = roman.age;
Console.WriteLine($"Name: {personName}, age: {personAge}");

roman.name = "Roman";
roman.age = 12;
roman.Print();

class Person
{
    public string name = "Undefined"; 
    public int age;
    public void Print()
    {
        Console.WriteLine($"Name: {name}, age: {age}");
    }
}