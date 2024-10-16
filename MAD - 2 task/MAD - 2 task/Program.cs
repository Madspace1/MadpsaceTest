
while (true) // зробив з перевіркою корректного вводу числа, в разі якщо користувач напише текст
{
    Console.Write("Please, enter temperature in Celsius: ");
    string text = Console.ReadLine();

    if (double.TryParse(text, out double celsius))
    {
        double fahrenheit = celsius * 1.8 + 32;

        Console.WriteLine("Your temperature in fahrenheit is " + fahrenheit);
        break;
    }
    Console.WriteLine("Could not recognize the number, try again."); 
}