//This program uses encapsulation to create a simple online ordering system.
// It includes classes for Address, Customer, Product, and Order.
// Creates at least 2 orders with 2-3 products each, calls the methods to get and display the order details including packing label, shipping label, and total order price.
// It has no user input; all values are hard-coded in the Main method.
using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("1236 Main St", "London", "England", "UK");
        Address address2 = new Address("456 Elm St", "Shelbyville", "IL", "USA");

        // Create customers
        Customer customer1 = new Customer("Anthony Walter", address1);
        Customer customer2 = new Customer("Jennifer Sousa", address2);

        // Create products
        Product product1 = new Product("Laptop", "A high-performance laptop.", 999.99, 2);
        Product product2 = new Product("Mouse", "Wireless mouse.", 25.50, 1);
        Product product3 = new Product("Keyboard", "Mechanical keyboard.", 75.00, 1);
        Product product4 = new Product("Monitor", "24-inch monitor.", 150.00, 1);

        // Create orders and add products
        Order order1 = new Order(customer1.GetName(), customer1.GetAddress().GetFullAddress());
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2.GetName(), customer2.GetAddress().GetFullAddress());
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        Console.WriteLine("Order 1 Details:");
        order1.DisplayOrderDetails();
        Console.WriteLine();

        Console.WriteLine("Order 2 Details:");
        order2.DisplayOrderDetails();
    }
}