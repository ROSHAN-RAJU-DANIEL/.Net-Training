// Methods
// returnType MethodName(paramType paramName,..){}

// With no return types
// with return types

using System.Text;

Console.Write("enter number1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number2");
int num2 = Convert.ToInt32(Console.ReadLine());

void Add(int a, int b)
{
    Console.WriteLine($"Addition: {a +b}");
}
Add(num1,num2);
Add(1, 3);

int GreaterThan(int a, int b,int c)
{
    int largest = a;
    if(b > largest)
    { largest = b; }
    if(c > largest)
    {
        largest = c;
    }
    return largest;
}

int largest = GreaterThan(1, 2, 3);
Console.WriteLine($"greater is {largest}");

////////////////////////////////

// Strings & Manipulation

string firstName = "Roshan";
string lastName = "raju";

// Replace string

string newFirstName = firstName.Replace("an", "in");
Console.WriteLine($"NEW FIRST NAME IS {newFirstName}");

//compare two strings equal
if(firstName.CompareTo(lastName) == 0)
{
    Console.WriteLine("firstName and lastName are equal");
}
if(string.Equals(firstName, lastName))
{
    Console.WriteLine("firstName and lastName are equal");
}

// null,empty,...

if(string.IsNullOrEmpty(firstName))
{
    Console.WriteLine("string is empty or null");
}
if(string.IsNullOrWhiteSpace(lastName))
{
    Console.WriteLine("string is whitespace or null");
}


