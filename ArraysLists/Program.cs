// intialize a fixed size array

int[] marks = new int[5];

//iterate an array
for(int i=0;i<marks.Length;i++)
{
    Console.WriteLine("enter marks");
    marks[i]= Convert.ToInt32(Console.ReadLine());
}

// PRINT AN ARRAY OF ELEMENTS
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}

// intialize array if the values are known
string[] names = new string[] { "roshan", "raju", "daniel" };


//Lists
List<string> devs = new List<string>();
string dev = string.Empty;

while (!dev.Equals("-1"))
    {
    Console.WriteLine("Enter the name of dev:");
    dev = Console.ReadLine();
    if(dev != string.Empty && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}

foreach (string name in devs)
{
    Console.WriteLine(name);
}