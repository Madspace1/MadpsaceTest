/*Implement a discount system based on purchase amount.
Description: Create an application that calculates the final price based on the initial price
and the amount spent. The discounts work as follows:

No discount if the amount is below $100.
10% discount if the amount is between $100 and $500.
15% discount if the amount is between $500 and $1000.
20% discount if the amount is $1000 or more.

A user enters the purchase amount and the application should print the discount and the final price.

*/

while (true)
{
    Console.Write("Enter the amount to calculate the discount: ");
    string input = Console.ReadLine();
    double amount;

    while (!double.TryParse(input, out amount))
    {
        Console.WriteLine("You entered the wrong amount. Please try again");

        Console.Write("Enter the amount to calculate the discount: ");
        input = Console.ReadLine();
    }

    double discount = 0;
    if (0 <= amount & amount <= 99)
    {
        discount = 1;
    }
    if (100 <= amount & amount <= 499)
    {
        discount = 0.9;
    }
    if (500 <= amount & amount <= 999)
    {
        discount = 0.85;
    }
    if (1000 <= amount)
    {
        discount = 0.80;
    }
    
    double total = amount * discount;
    if(discount == 1)
    {
        Console.WriteLine($"You have no discount. Total you have to pay is {total}$ ");
    }
    else
    {
        Console.WriteLine($"Your discount is {(1 - discount) * 100}%. Total you have to pay is {total}$ ");
    }
    

    if (amount < 0)
    {
        Console.WriteLine("You entered the wrong amount. Please try again");
    }
    if (input.Equals("EXIT", StringComparison.CurrentCultureIgnoreCase))
    {
        Console.WriteLine("Good bye ;)");
        break;
    }
}
