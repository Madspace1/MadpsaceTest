
bool Palindrome(string word, int start = 0, int end = -1)
{
    word = word.ToLower();
    
    if (end == -1)
    {
        end = word.Length - 1;
    }

    while (start < end && !char.IsLetter(word[start]))
        {
        start++;
        }

    while (start < end && !char.IsLetter(word[end]))
    {
        end--;
    }

    if (start >= end)
    {
        return true;
    }

    if (word[start] != word[end])
    {
        return false;
    }

    return Palindrome(word, start + 1, end - 1);
}

void CheckAndPrintPalindrome(string word)
{
    bool isPalindrome = Palindrome(word);
    Console.WriteLine($"{word} : {isPalindrome}");
}

CheckAndPrintPalindrome("waZaW");
CheckAndPrintPalindrome("step");
CheckAndPrintPalindrome("cleen");
CheckAndPrintPalindrome("pottop");
CheckAndPrintPalindrome("roman");
CheckAndPrintPalindrome("eduard");
CheckAndPrintPalindrome("Pottop");
CheckAndPrintPalindrome("Pottop123!");
CheckAndPrintPalindrome("I love you, uoy evol I");