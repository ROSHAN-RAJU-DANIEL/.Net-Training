// 1)print Sum and Product 

int num1,num2;
Console.WriteLine("Enter Two Numbers");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of Two Numbers is:{num1 + num2}");
Console.WriteLine($"Product of Two Numbers is:{num1 * num2}");


// 2) Equation

int a, b, c;
Console.WriteLine("Enter Three Numbers");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"the Result is :{(((a + b) / c) * a)}");


// 3) Game of 'Fortune'

int guess = 0, number;
Random rnd = new Random();
number = rnd.Next(0, 100);
for (int i = 1; i < 6; i++)
{
    Console.Write("Welcome! Enter a Number between 0-100: ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess > number)
    {
        Console.WriteLine("Guessed number is higher");
    }
    else if (guess < number)
    {
        Console.WriteLine("Guessed number is lesser ");
    }
    else
    {
        Console.WriteLine("You Won");
        break;
    }
    Console.WriteLine($"You have {5 - i} tries left");
    if (i == 5)
    {
        Console.WriteLine($"You Lost,the answer was {number}");
    }
}