using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Product p1 = new Product();
        p1.name = "Laptop";
        p1.id = "P001";
        p1.price = 800;
        p1.quantity = 1;

        Product p2 = new Product();
        p2.name = "Mouse";
        p2.id = "P002";
        p2.price = 25;
        p2.quantity = 2;

        Address a1 = new Address();
        a1.street = "123 Main St";
        a1.city = "New York";
        a1.state = "NY";
        a1.country = "USA";

        Customer c1 = new Customer();
        c1.name = "John Smith";
        c1.address = a1;

        Order o1 = new Order();
        o1.customer = c1;
        o1.products.Add(p1);
        o1.products.Add(p2);

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing:");
        Console.WriteLine(o1.GetPacking());
        Console.WriteLine("Shipping:");
        Console.WriteLine(o1.GetShipping());
        Console.WriteLine("Total: $" + o1.GetTotal());
        Console.WriteLine();

        // Order 2
        Product p3 = new Product();
        p3.name = "Book";
        p3.id = "P003";
        p3.price = 15;
        p3.quantity = 3;

        Product p4 = new Product();
        p4.name = "Pen";
        p4.id = "P004";
        p4.price = 2;
        p4.quantity = 10;

        Address a2 = new Address();
        a2.street = "456 Oak Ave";
        a2.city = "Toronto";
        a2.state = "Ontario";
        a2.country = "Canada";

        Customer c2 = new Customer();
        c2.name = "Maria Garcia";
        c2.address = a2;

        Order o2 = new Order();
        o2.customer = c2;
        o2.products.Add(p3);
        o2.products.Add(p4);

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing:");
        Console.WriteLine(o2.GetPacking());
        Console.WriteLine("Shipping:");
        Console.WriteLine(o2.GetShipping());
        Console.WriteLine("Total: $" + o2.GetTotal());
    }
}