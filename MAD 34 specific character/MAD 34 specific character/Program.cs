/* Write a function that counts the frequency of a specific character in a string.

Instructions:

Create a function int CountCharacter(string s, char c) that returns the frequency of the character c in the string s.

Example: For input "hello" and l, the program should print 2.
*/

Console.Write("Enter the word: ");
string word = Console.ReadLine();
word = word.ToLower();

Console.Write("Enter the character: ");
char character = Console.ReadKey().KeyChar;
character = char.ToLower(character);
int counter = CountCharacter(word, character);
if (counter > 0)
{
    Console.WriteLine();
    Console.WriteLine($"Character '{character}' was founded {counter} time's.");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Character '{character}' was not founded.");
}
int CountCharacter(string s, char c)
   
{
    int count = 0;
    for (int i = 0; i < word.Length; i++)
    { 
    char c2 = word[i];
        if (c == c2)
        {
            count++;
        }
    }
   

    
    return count;
}
Console.ReadLine();