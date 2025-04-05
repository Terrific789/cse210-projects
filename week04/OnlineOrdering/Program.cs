using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Agbado Road", "Lagos", "Lagos", "USA");
        Customer customer1 = new Customer("Chinedu Obi", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 750.00, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.00, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine("-----------------------------");

        Address address2 = new Address("10 Banana Street", "Accra", "Greater Accra", "Ghana");
        Customer customer2 = new Customer("Ama Kwabena", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P003", 500.00, 1));
        order2.AddProduct(new Product("Charger", "P004", 30.00, 1));
        order2.AddProduct(new Product("Headphones", "P005", 45.00, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}
