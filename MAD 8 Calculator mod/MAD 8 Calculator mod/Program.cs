
while (true)
{
    Console.WriteLine("====================");
    Console.Write("           Please enter first number:  ");
    string a = Console.ReadLine();
    double firstNumber;
    Console.WriteLine();
    while (!double.TryParse(a, out firstNumber))
    {
        Console.WriteLine("You entered incorrect first number. Please try again");
        a = Console.ReadLine();
    }

    Console.Write("           Please enter second number: ");
    string b = Console.ReadLine();
    double secondNumber;
    Console.WriteLine();
    while (!double.TryParse(b, out secondNumber))
    {
        Console.WriteLine("You entered incorrect second number. Please try again");
        b = Console.ReadLine();
    }


    Console.Write("Please enter operation +, -, *, or / : ");
    string sign = "";

    while(sign != "+" && sign != "-" && sign != "*" &&  sign != "/")
    {
        Console.WriteLine($"The sing {sign} in incorect. Pls, enter the correc one.");
        sign = Console.ReadLine();
    }
   
    double result = 0;
    if (sign == "+")
    {
        result = firstNumber + secondNumber;
    }
    if (sign == "-")
    {
        result = firstNumber - secondNumber;
    }
    if (sign == "*")
    {
        result = firstNumber * secondNumber;
        
    }
    if (sign == "/")
    {
        if (secondNumber == 0)
        {
            Console.WriteLine("it is impossible to divide by 0");
            continue;
        }
        else
        {
            result = firstNumber / secondNumber;

        }
    }

    Console.WriteLine($"{a} {sign} {b} = {result}");
}