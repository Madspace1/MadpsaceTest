/* Create a console application that classifies student grades.
The application should ask the user to enter a grade 0-100. 
Based on the grade, the application should display:

"A" for grades 90 and above.

"B" for grades between 80 and 89.

"C" for grades between 70 and 79.

"D" for grades between 60 and 69.

"F" for grades below 60.

Details: The application should prompt for a grade, check the entered value using if-else statements,
and then print the corresponding letter grade to the console. */

while (true)
{
    Console.Write("Please, enter your grade. If you want to stop this program, just enter 'stop': ");
    string grade = Console.ReadLine();

    if (grade.ToLower() == "stop")
    {
        Console.WriteLine("Good bye!");
        break;
    }

    if(!int.TryParse(grade, out int gradeNumber))
    {
        gradeNumber = -1;
    }

    Console.WriteLine();
    string sentence = "Your grade is ";
    if (0 <= gradeNumber & gradeNumber <= 59)
    {
        sentence += "'F' (Fail)";
    }
    else if (60 <= gradeNumber & gradeNumber <= 69)
    {
        sentence = sentence + "'D' (Sufficient)";
    }
    else if (70 <= gradeNumber & gradeNumber <= 79)
    {
        sentence += "'C' (Satisfactory)";
    }
    else if (80 <= gradeNumber & gradeNumber <= 89)
    {
        sentence += "'B' (Good)";
    }
    else if (90 <= gradeNumber & gradeNumber <= 100)
    {
        sentence += "'A' (Very Good)";
    }
    else
    {
        sentence = "You entered an incorrect grade. Please enter a grade from 0 to 100";
    }
    Console.WriteLine(sentence);
    Console.WriteLine();
}