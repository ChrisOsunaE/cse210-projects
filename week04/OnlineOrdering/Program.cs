using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Address address2 = new Address("1700 La Goma", "Torreon", "Coahuila", "México");

        Customer customer1 = new Customer("Sarah Johnson", address1);
        Customer customer2 = new Customer("Juan Pérez", address2);

        Product product1 = new Product("01", "Laptop", 899.99m, 1);
        Product product2 = new Product("02", "Wireless Mouse", 25.50m, 2);
        Product product3 = new Product("03", "Keyboard", 45.00m, 1);
        Product product4 = new Product("04", "Monitor", 150.00m, 2);

        List<Product> order1Products = new List<Product> { product1, product2 };
        List<Product> order2Products = new List<Product> { product3, product4, product1 };

        Order order1 = new Order(customer1, order1Products);
        Order order2 = new Order(customer2, order2Products);

        Console.WriteLine("=========================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("=========================================");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalOrderCost()}");

        Console.WriteLine("\n=========================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("=========================================");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalOrderCost()}");


    }
}