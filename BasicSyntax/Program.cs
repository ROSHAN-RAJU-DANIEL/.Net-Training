// Data Types (String,int,float,double,char)

// Type Conversion

// we can intialize a string as this
String fullName = string.Empty;


int age = 0;
double salary = 0.0;
char gender = char.MinValue;
bool working = false;



Console.Write("Please enter your name:");
fullName = Console.ReadLine();

// we have to convert the reading value to int.basically readline returns string type
Console.Write("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary:");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your gender (M/F):");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working(true/false)");
working = Convert.ToBoolean(Console.ReadLine());

Console.Write("Entered Name is:" + fullName);


