
while (true)
{
    int trycounter = 0;
    Random rnd = new Random();

    int value = rnd.Next(0, 100);
    Console.WriteLine("Попробуй отгадать число от 1 до 100 ;)");
    while (true)
    {
        int number = int.Parse(Console.ReadLine());

        trycounter++;
        if (number > value)
        {
            Console.WriteLine("Хорошая попытка! Но твоё число слишком БОЛЬШОЕ! Попробуй еще ;)");
        }
        else if (number < value)
        {
            Console.WriteLine("Хорошая попытка! Но твоё число слишком МАЛЕНЬКОЕ! Попробуй еще ;)");
        }
        else if (number == value)
        {
            Console.WriteLine("");
            Console.WriteLine("================");
            Console.WriteLine("");
            Console.WriteLine($"ПОЗДРАВЛЯЮ!!. Ты угадал(а) и это число {value}!  Твоё количество попыток: {trycounter} раз");
            Console.WriteLine("");
            Console.WriteLine("================");
            Console.WriteLine("");
            break;
        }
    }
}