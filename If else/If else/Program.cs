
Console.WriteLine(23);
Console.WriteLine(true);
Console.WriteLine(!true);
Console.WriteLine(false);
Console.WriteLine(!false);
Console.WriteLine(12 == 17);
Console.WriteLine(true == false);


while (true)
{

    Console.WriteLine("Enter temperatre");
    string numberStr = Console.ReadLine();

    Console.WriteLine("Convert to");
    string input = Console.ReadLine();

    if(input.ToLower() == "exit")
    {
        Console.WriteLine("Exit!!!!!");
        break;
    }

    if (input == "Farenhait")
    {
        double celsius = Convert.ToDouble(numberStr);
        var farenhait = celsius * 1.8 + 32;
        Console.WriteLine($"Celsius {celsius} = Farenhait {farenhait}");
    }
    else if (input == "Celsius")
    {
        double farenhait = Convert.ToDouble(numberStr);
        double celsius = (farenhait - 32) / 1.8;
        Console.WriteLine($"Farenhait {farenhait} = Celsius {celsius}");
    }
    else if (input == "Kelvin")
    {
        Console.WriteLine("Some value in kelvins");
    }
    else
    {
        Console.WriteLine("Incorrect convert to value");
    }
}