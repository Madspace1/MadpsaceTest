
Console.WriteLine("Welcome to Ed ATM");
int balance = 1000;
while (true)
{
    Console.WriteLine($"Your balance is {balance}$");
    Console.WriteLine("Please, select operation:");
    Console.WriteLine(" '1' for DEPOSIT ");
    Console.WriteLine(" '2' for WITHDRAW ");
    Console.WriteLine(" '3' for Exit from ATM ");

    string operation = Console.ReadLine();

    if (operation == "1")
    {
        Console.WriteLine("Enter the deposit amount:");
        int amount = int.Parse(Console.ReadLine());
        balance = balance + amount;
        continue;
    }
    if (operation == "2")
    {
        Console.WriteLine("Enter the withdraw amount:");
        int amount = int.Parse(Console.ReadLine());
        balance -= amount;
        continue;
    }

    Console.WriteLine("Have a nice day, goodbye!");
    break;
}

