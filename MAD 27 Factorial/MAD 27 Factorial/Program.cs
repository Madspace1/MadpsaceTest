
int number = ReadInteger("Enter the number:  ");

int FactorialCalculate = Factorial(number);
Console.WriteLine(FactorialCalculate);

int Factorial(int n)
{
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}
int ReadInteger(string message)
{
    Console.Write(message);
    int value;
    string s = Console.ReadLine();
    while (int.TryParse(s, out value) == false)
    {
        Console.Write("Try one more time: ");
        s = Console.ReadLine();
    }

    return value;
}