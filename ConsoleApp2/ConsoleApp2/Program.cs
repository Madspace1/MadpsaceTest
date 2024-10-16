


double a = 3.3;
int b = 5;

double c = a + b; // 8.3
string d = "Hello Ed";
char e = 'E';


Console.WriteLine("--------The lengths of data types------");
Console.WriteLine( short.MaxValue ); // 16
Console.WriteLine(short.MinValue);
Console.WriteLine(int.MaxValue); // 32
Console.WriteLine(int.MinValue);
Console.WriteLine(long.MaxValue); // 64
Console.WriteLine(long.MinValue);
Console.WriteLine(double.MinValue); // 64
Console.WriteLine(double.MinValue);
Console.WriteLine(float.MinValue); // 32
Console.WriteLine(float.MinValue);
Console.WriteLine("--------END------");

Console.WriteLine( d[0].Equals(1) );

Console.WriteLine("--------END- -----");

//-----------------

Console.WriteLine("Pls enter your first name");
string firstName = Console.ReadLine();

Console.WriteLine("Pls enter your last name");
string lastName = Console.ReadLine();

Console.WriteLine("Pls enter your age");
string ageStr = Console.ReadLine();
int age = int.Parse( ageStr );

Console.WriteLine(firstName + " " + lastName);
Console.WriteLine(ageStr + 23);
Console.WriteLine(age + 23);
