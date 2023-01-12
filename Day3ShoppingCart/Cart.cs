

public class ShoppingCart
{
    List<ShoppingCartEntry> cartList = new List<ShoppingCartEntry>
    {
    };
    public void ShoppingCartList(string name, int quantity, int price)
    {
        cartList.Add(new ShoppingCartEntry(quantity, price, name));

    }
    public void OrderList()
    {
        Console.WriteLine("Order Details:");
        foreach (var shopping in cartList)
        {
            Console.WriteLine(shopping);
        }
        Order order = new Order(cartList);
        Console.WriteLine("Total Price");
        order.TotalPrice();

    }
}
