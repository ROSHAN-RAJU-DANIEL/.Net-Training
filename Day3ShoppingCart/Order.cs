
public class Order
{
    List<ShoppingCartEntry> orderList = new List<ShoppingCartEntry>
    {
    };
    public double _tax ;
    public Order(List<ShoppingCartEntry> list)
    {
        this.orderList = list;
    }
    public void TotalPrice()
    {
        double total = 0;
        foreach (var item in orderList)
        {

            total += (item.Price * item.Quantity);
            _tax = total / 20;
        }
        Console.WriteLine($"Total price of your orders is : {_tax + total}");


    }


}