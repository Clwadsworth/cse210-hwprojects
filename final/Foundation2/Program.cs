using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        // title of the system
        Console.WriteLine("----- Online Ordering System -----");

        // starting on order number 1 domestic
        // set up order one's address and assign it to an object
        Address address1 = new Address("123 Main St.", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Lyn Wadsworth", address1);

        // put a name to the order
        Order order1 = new Order(customer1);

        // create the items and load them into the order
        order1.AddProduct(new Product("Mechanical Keyboard", "K80-MECH", 75.00, 1));
        order1.AddProduct(new Product("Ergonomic Mouse", "M20-ERGO", 45.50, 2));

        // print the results of the classes
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        // Order number 2 with international, in this case Japan
        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine(new string('=', 40) + "\n");

        // set up the location information
        Address address2 = new Address("456 Tokyo Drift Lane", "Shibuya", "Tokyo", "Japan");
        Customer customer2  = new Customer("Hiro Tanaka", address2);
        Order order2 = new Order(customer2);

        // create and load items into the order
        order2.AddProduct(new Product("Ultra-Wide Monitor", "MON-34UW", 349.99, 1));
        order2.AddProduct(new Product("HDMI Cable 6ft", "CBL-HD6", 8.25, 3));

        // print the results
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine(new string('=', 40));

    }
}