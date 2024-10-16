
Console.WriteLine("Enter the length of array:");
int len = int.Parse(Console.ReadLine());

int[] firstARR = new int[len];
int[] evenARR = new int[len];
int[] oddARR = new int[len];
int number=0;

int evenCounter = 0;
int oddCounter = 0;
for (int i = 0; i < len; i++)
{
    Console.WriteLine($"Enter the number #{i+1}");
    number = int.Parse(Console.ReadLine());
    firstARR[i] = number;
    if (number % 2 == 0)
    {
        //even
        evenARR[evenCounter] = firstARR[i];
        evenCounter = evenCounter + 1;
    }
    else
    {
        //odd
        oddARR[oddCounter] = firstARR[i];
        oddCounter = oddCounter + 1;
    }

}

for (int i = 0; i < oddCounter; i++)
{
     Console.WriteLine($"odd array: {oddARR[i]}");
}

for (int i = 0; i < evenCounter; i++)
{
    Console.WriteLine($"Even array: {evenARR[i]}");
}
