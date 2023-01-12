string name = string.Empty;
int quantity = 0;
int price = 0;
ShoppingCart shoppingCart = new ShoppingCart();
{
    Console.WriteLine("Enter no of orders to be added");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        Console.Write("Please enter product name : ");
        name = Console.ReadLine();
        Console.Write("Please enter product quantity :  ");
        quantity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter product price :  ");
        price = Convert.ToInt32(Console.ReadLine());
        ShoppingCartEntry shoppingCartEntry = new ShoppingCartEntry(quantity, price, name);
        shoppingCart.ShoppingCartList(name, quantity, price);
    }
    Console.WriteLine("Your order list is");
    shoppingCart.OrderList();
}