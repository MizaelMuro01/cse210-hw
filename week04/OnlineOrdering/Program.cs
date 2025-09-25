using System;

class Program
{
    static void Main(string[] args)
    {
        // Primer pedido - Cliente en USA
        Product product1 = new Product("Laptop", "P001", 800, 1);
        Product product2 = new Product("Mouse", "P002", 25, 2);
        
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.CalculateTotal()}\n");

        // Segundo pedido - Cliente internacional
        Product product3 = new Product("Book", "P003", 15, 3);
        Product product4 = new Product("Pen", "P004", 2, 10);
        
        Address address2 = new Address("456 Oak Ave", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Maria Garcia", address2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.CalculateTotal()}");
    }
}