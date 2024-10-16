using System.Diagnostics.Metrics;

List<char> chars = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y'};
Console.Write("Enter your word: " );
int counter = 0;
string word = Console.ReadLine();
int vowels = CountVowels($"{word}");
Console.WriteLine(vowels);
int CountVowels(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
     char letter = s[i];
        if (chars.Contains(letter))
        {
            counter++;
        }
    }
    return counter;
}




/*
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
*/