public class Product
{
    public string name;
    public string id;
    public double price;
    public int quantity;

    public double GetCost()
    {
        return price * quantity;
    }
}