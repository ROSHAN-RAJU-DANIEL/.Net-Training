using System.Globalization;

DateTime date = new DateTime();
DateTime dateofBirth = new DateTime(1980, 1, 35);
// create dateTime from date

DateTime parsedDate = DateTime.Parse("3/31/2000",CultureInfo.InvariantCulture);
Console.WriteLine($"parsed date is {parsedDate}");  

// create dateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"current time is {now}");

// Add hours to Datetime
Console.WriteLine($" 2 hous from now is {now.AddHours(2)}");

//DateOnly
DateOnly dob = DateOnly.FromDateTime(dateofBirth);
Console.WriteLine(dob);

//Timeonly
TimeOnly tob = TimeOnly.FromDateTime(dateofBirth);
Console.WriteLine(tob);


//////////////

// Exception handling

Console.Write("enter number1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("enter number2");
int num2 = Convert.ToInt32(Console.ReadLine());

try
{
    double quotient = num1 / num2;
    Console.WriteLine($"result is {quotient}");
}
catch(DivideByZeroException e) 
{
    Console.WriteLine($"{e.Message}");
}
catch(Exception e)
{
    throw e;
}
finally
{
    Console.WriteLine("exited program");
}