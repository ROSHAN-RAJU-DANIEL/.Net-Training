// ATM machine 

int amount = 10000, cash, current, pinNumber = 6789, cardNumber = 12345;

Console.WriteLine("Enter the cardNumber");
int cardNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the pinNumber");
int pinNum = Convert.ToInt32(Console.ReadLine());

if(pinNum==pinNumber && cardNum == cardNumber)
{
    Console.WriteLine("1.Check balance");
    Console.WriteLine("2.Withdraw the amount");
    Console.WriteLine("3.Deposit the amount");
    Console.WriteLine("4.Quit the program");
    Console.WriteLine("Enter your choice: ");

    int choice= Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Balance();
            break;
        case 2:
            Withdraw();
            break;
        case 3:
            Deposit();
            break;
        case 4:
            Console.WriteLine("Thank you for using ATM. Goodbye.");
            break;
        default:
            Console.WriteLine("Please select correct option");
            break;
    }
}
else
{
    Console.WriteLine("Invalid Credentials");
}

void Balance()
{
    Console.WriteLine($"current balance is: {amount}");
}

void Withdraw()
{
    Console.WriteLine("Enter the amount to withdraw");
    {
        cash = Convert.ToInt32(Console.ReadLine());
        if (amount >= cash)
        {
            if (cash % 100 == 0)
            {
                Console.WriteLine("Please collect the cash");
                current = amount - cash;
                Console.WriteLine($"Deposit Successfull,your current balance is: {current}" );
            }
            else
                Console.WriteLine("Enter the amount in multiples of 100");
        }
        else
            Console.WriteLine("No sufficient balance");
    }

}

void Deposit()
{
    Console.WriteLine("Enter the amount to deposit");
    cash = Convert.ToInt32(Console.ReadLine());
    current = amount + cash;
    Console.WriteLine($"your current balance is: {current}");
}
