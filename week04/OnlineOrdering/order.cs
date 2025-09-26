using System.Collections.Generic;

public class Order
{
    public List<Product> products = new List<Product>();
    public Customer customer;

    public double GetTotal()
    {
        double total = 0;
        foreach (Product p in products)
        {
            total += p.GetCost();
        }

        if (customer.InUSA())
            total += 5;
        else
            total += 35;

        return total;
    }

    public string GetPacking()
    {
        string label = "";
        foreach (Product p in products)
        {
            label += p.name + " (" + p.id + ")\n";
        }
        return label;
    }

    public string GetShipping()
    {
        return customer.name + "\n" + customer.address.GetAddress();
    }
}