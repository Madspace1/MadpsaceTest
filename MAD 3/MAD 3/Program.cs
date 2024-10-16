/*Create a console application that prompts the user to input two numbers 
 * (as strings) and an arithmetic operation symbol (+, -, *, /). 
 * The application should then perform the operation on these numbers and display the result.
 * Assume the user will always input valid numbers and symbols. */

/* while (true) // зробив з перевіркою корректного вводу числа, в разі якщо користувач напише текст
{
    Console.Write("Please, enter temperature in Celsius: ");
    string text = Console.ReadLine();

    if (double.TryParse(text, out double number))
    {
       
        double celsius = double.Parse(text); 
        double fahrenheit = celsius * 1.8 + 32;

        Console.WriteLine("Your temperature in fahrenheit is " + fahrenheit);
        break;
    }
    Console.WriteLine("Could not recognize the number, try again."); */



Console.WriteLine("Please enter first number");
string firstNumberTEXT = Console.ReadLine();
double firstNumber;

while (!double.TryParse(firstNumberTEXT, out firstNumber))
{
    Console.WriteLine("Could not recognize the number, try again.");
}

Console.WriteLine("Please enter second number");
string secondNumberTEXT = Console.ReadLine();
double secondNumber;
do
{

    if (double.TryParse(secondNumberTEXT, out secondNumber))
    {

        break;
    }
    Console.WriteLine("Could not recognize the number, try again.");
} while (true);

double plus = firstNumber + secondNumber;
double minus = firstNumber - secondNumber;
double multiply = firstNumber * secondNumber;
double division = firstNumber / secondNumber;

Console.WriteLine (firstNumber + " + " + secondNumber + " = " + plus);
Console.WriteLine (firstNumber + " - " + secondNumber + " = " + minus);
Console.WriteLine (firstNumber + " * " + secondNumber + " = " + multiply);
Console.WriteLine ($"{firstNumber} / {secondNumber} = {division.ToString("#.##")}");

