/* Implement a simple login system using if-else
  Create a console application that simulates a login process. The application should have 
a preset username and password (e.g., username: user, password: pass123).
The application should ask the user to enter a username and password.
If the username and password match the preset values, display "Login successful", 
otherwise display "Login failed". */
while (true)
{
    string login = "user";
    string password = "pass123";

    Console.Write("          Enter your login: ");
    string inputLogin = Console.ReadLine();

    if (inputLogin != login)
    {
        Console.WriteLine();
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("Login failed. Invalid login, please try again");
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine();
    }
    else
    {

        Console.Write("          Enter your password: ");
        string inputPassword = Console.ReadLine();

        if (inputPassword != password)
        {
            Console.WriteLine();
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Login failed. Invalid password, please try again");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine();
            Console.WriteLine("============Login successful============");
            Console.WriteLine();
            break;
        }
    }
}