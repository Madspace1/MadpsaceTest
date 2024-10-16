

int result = 1;
for (int i = 1; i <= 10; i++)
{
    result *= i; // result = result * i;
}

Console.WriteLine(result);

//int[] numbers = new int[5] { 1,5,7,3,7 };

//int min = numbers[0];
//for (int i = 1; i < numbers.Length; i++)
//{
//    int currentGrade = numbers[i];
//    if(currentGrade < min)
//    {
//        min = currentGrade;
//    }
//}

//Console.WriteLine(min);

int[] fibonaci = new int[7];
fibonaci[0] = 1;
fibonaci[1] = 1;
//[2] = [1] + [0]

int[] fibonaci2 = new int[17];
for (int i = 0; i < fibonaci.Length; i++)
{
    fibonaci2[i] = fibonaci[i];
}

for (int i = 2; i <= 10; i++)
{
    fibonaci[i] = fibonaci[i - 1] + fibonaci[i - 2];
}

// 0 0 0 0 0 0 0 0 0 0 [1 1 35 8 13 0] "hi" 0 0 0 0 0 [1 1 2 0 0 0 0 0 0 0 0 0 0 0 0] 0 0 0 0 0
