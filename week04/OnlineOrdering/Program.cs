using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Richmond", "VA", "USA");
        Customer customer1 = new Customer("Norlin Montenegro", address1);

        Product product1 = new Product("Laptop", "P100", 799.99, 1);
        Product product2 = new Product("Mouse", "P101", 25.50, 2);
        Product product3 = new Product("Keyboard", "P102", 45.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("456 Maple Road", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Maria Lopez", address2);

        Product product4 = new Product("Monitor", "P200", 199.99, 2);
        Product product5 = new Product("HDMI Cable", "P201", 15.99, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");

        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine();

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}