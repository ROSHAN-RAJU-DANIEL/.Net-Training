
String firstName = string.Empty;
String lastName = string.Empty;
String middleName = string.Empty;
int age = 0;
double salary = 0.0;


Console.Write("Please enter your  first name:");
firstName = Console.ReadLine();

Console.Write("Please enter your lastName:");
lastName = Console.ReadLine();

Console.Write("Please enter your middleName:");
middleName = Console.ReadLine();

Console.Write("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary:");
salary = Convert.ToInt32(Console.ReadLine());

Person person = new Person(firstName,lastName,age,salary);
//person.FirstName = firstName;
//person.LastName = lastName;
//erson.Age = age;
//person.SetSalary(salary);

if(string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"name entered is {person.GetFullName()}");
}
else
{
    Console.WriteLine($"name entered is {person.GetFullName(middleName)}");
}

Console.WriteLine($"entered fullName  is : {person.FirstName + " " + person.LastName}");
Console.WriteLine($"entered age is {person.Age}");
Console.WriteLine("3.Deposit the amount");