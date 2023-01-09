//for (counter controlled)
for (int i=0; i<10;i++)
{
    Console.WriteLine($"Inside loop {i}");
}
Console.WriteLine("for loop exited");


//while (condition controlled)
int n = 0;
while (n< 4)
{
    Console.Write("Enter the value for n: ");
    n= Convert.ToInt32( Console.ReadLine() );
    Console.WriteLine($"iNSIDE while loop {n}");
}
Console.WriteLine("while loop exited");


//do while(condition ,post check)
int j = 10;
do
{
    Console.Write("Enter the value for j: ");
    j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"iNSIDE do while loop {j}");
} while (j < 5);
Console.WriteLine();
Console.WriteLine("do while loop exited");