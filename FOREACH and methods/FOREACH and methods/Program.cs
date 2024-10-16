string word = ReadInteger("Enter the word:  ");
string Reverse = ReverseString($"{word}");
Console.WriteLine(Reverse);

string ReverseString(string s)
{
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}
string ReadInteger(string message)
    {
        Console.Write(message);
        int value;
    string s = Console.ReadLine();

        while (int.TryParse(s, out value) == true)
        {
            Console.Write("Try one more time: ");
            s = Console.ReadLine();
            
        }

        return s;
    }

/*
// LIST ENTER and PRINT
int size = ReadInteger("Enter size");

List<int> ints = new List<int>();


Console.WriteLine("Enter numbers: ");
for (int i = 0; i < size; i++)
{
    int integer = ReadInteger($"{i+1}: ");
    ints.Add(integer);
}

Console.WriteLine("=========");
Print(ints);



void Print(List<int> numbers)
{
    foreach (int current in numbers)
    {
        Console.WriteLine(current);
    }
}

// EVEN in squared
bool result = PrintEven(12, out int test1);
Console.WriteLine(test1);

bool PrintEven(int number, out int squared)
{
    squared = number * number;
    if(number % 2 == 0)
    {
        Console.WriteLine(number);
        return true;
    }

    return false; 
}

// MINIMUM NUMBER
int min = GetMin(ints);
Console.WriteLine(min);

int GetMin(List<int> numbers)
{
    int min = numbers[0];
    foreach (int current in numbers)
    {
        if(min > current)
        {
            min = current;
        }
    }

    return min;
}
*/

/*Write a function that calculates the factorial of a given number.

Instructions:

Create a function int Factorial(int n) that returns the factorial of n.

Read an integer from the console, call the Factorial function, and print the result.

Example: For input 5, the program should print 120. (1 * 2 * 3 * 4 *5)  */