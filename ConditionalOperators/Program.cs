//  Conditional
// if else(==,>,<,<=,>=,!=)

Console.Write("enter number of Apples");
int numberOfApples = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number of Oranges");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

if(numberOfApples > numberOfOranges)
{
    Console.WriteLine("There are more apples");
}
else if (numberOfApples < numberOfOranges)
{
    Console.WriteLine("There are more Oranges");
}
else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("Apples and Oranges are Equal");
}
else
{
    Console.WriteLine("invalid");
}

// switch
Console.Write("enter your mark(0-100):");
int marks = Convert.ToInt32(Console.ReadLine());

switch(marks)
{
    case int n when (n < 50):
        Console.WriteLine("you are failed");
        break;
    case int n when (n >= 50 && n<= 100):
        Console.WriteLine("you are Passed");
        break;
    default:
        Console.WriteLine("invalid inputs");
        break;
}

// ternary
var message = numberOfApples > numberOfOranges ? "we have more apples" : "we have less apples";
Console.WriteLine(message);