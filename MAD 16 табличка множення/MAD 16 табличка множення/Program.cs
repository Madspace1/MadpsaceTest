Console.WriteLine("Write the number");
int number = int.Parse(Console.ReadLine());

for (int a = 1; a <= number; a++)
{
    Console.WriteLine();
    for (int b = 1; b < 10; b++)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }
}

   