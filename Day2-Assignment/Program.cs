
// ATM machine 

int amount = 10000;

bool access = Access();
if (access)
{
    int option;
    do
    {
        option = Options();
        switch (option)
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
    while (!option.Equals(4));


}
else
{
    Console.WriteLine("Invalid Credentials.!!!");
}


bool Access()
{
    bool credential = false;
    Console.WriteLine("Enter the cardNumber");
    int cardNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the pinNumber");
    int pinNum = Convert.ToInt32(Console.ReadLine());

    if (cardNum == 12345 && pinNum == 6789)
    {
        credential = true;
    }
    return credential;
}

int Options()
{
    Console.WriteLine("1.Check balance");
    Console.WriteLine("2.Withdraw the amount");
    Console.WriteLine("3.Deposit the amount");
    Console.WriteLine("4.Quit the program");
    Console.WriteLine("Enter your choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());
    return choice;
}
void Balance()
{
    Console.WriteLine($"current balance is: {amount}");
}

void Withdraw()
{
    Console.WriteLine("Enter the amount to withdraw");
    {
        int cash = Convert.ToInt32(Console.ReadLine());
        if (amount >= cash)
        {
            if (cash % 100 == 0)
            {
                Console.WriteLine("Please collect the cash");
                int current = amount - cash;
                Console.WriteLine($"Winthdraw Successfull,your current balance is: {current}");
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
    int cash = Convert.ToInt32(Console.ReadLine());
    if (cash % 100 == 0)
    {
        int current = amount + cash;
        Console.WriteLine($"Deposit Successfull,your current balance is: {current}");
    }
    else
    {
        Console.WriteLine("Enter the amount in multiples of 100");

    }

}
