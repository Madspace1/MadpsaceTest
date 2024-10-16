
int number = ReadInteger("Enter the number:  ");
List<int> primes = FindPrimesUpTo(number);

foreach (int prime in primes)
{
    Console.WriteLine(prime);
}

List<int> FindPrimesUpTo(int num)
{
    List<int> primes = new List<int>();
    for (int i = 0; i <= num; i++)
    {
        if(IsPrime(i) == true)
        {
            primes.Add(i);
        }
    }

    return primes;
}

bool IsPrime(int number)
{
    if(number <= 1)
    {
        return false;
    }

    for(int i = 2; i < number - 1; i++)
    {
        if(number % i == 0)
        {
            return false;
        }
    }

    return true;
}

int ReadInteger(string message)
{
    Console.Write(message);
    int s = int.Parse(Console.ReadLine());

    return s;
}