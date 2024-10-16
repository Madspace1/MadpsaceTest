Person tom = new Person();
Person bob = new Person("Bob");
Person jack = new Person("Jack", 25);

tom.Print();
bob.Print();
jack.Print();

class Person
{
    public string name;
    public int age;
    public Person() { name = "Unnamed"; age = 19; }
    public Person(string n) { name = n; age = 18; }
    public Person(string n, int a) { name = n; age = a; }

    public void Print()
    {
        Console.WriteLine($"Name: {name}, age: {age}");
    }
}
 /*   public Person()
    {
        Console.WriteLine("Creating of object Person");
        name = "Tom";
        age = 17;
    }
    public void Print()
    {
        Console.WriteLine($"Name: {name}, age: {age}");
    }
}

    */