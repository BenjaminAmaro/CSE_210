using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product("Wedge squat", "D1203", 10.99, 2);
        Product product2 = new Product("Apron", "P506", 5.99, 3);
        Product product3 = new Product("lamp", "L1651", 9.99, 5);
        Product product4 = new Product("Brush", "B540", 7.99, 1);
        
        Address address1 = new Address("901 N Stuart St", "Arlington", "Vermont", "United States");
        Customer customer1 = new Customer("Gladys Ferry", address1);
        
        Address address2 = new Address("565 King St W", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Maximillian Lang", address2);
        
        Address address3 = new Address("chincocuya", "Tampico", "Tamaulipas", "Mexico");
        Customer customer3 = new Customer("Benjamin Amaro", address3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product4);
        
        Console.WriteLine("");
        Console.WriteLine("First Order:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.GetFinalPrice()}$");
        Console.WriteLine("");

        Console.WriteLine("");
        Console.WriteLine("Second Order:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price:  {order2.GetFinalPrice()}$");
        Console.WriteLine("");

        Console.WriteLine("");
        Console.WriteLine("Third Order:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: {order3.GetFinalPrice()}$" );
        Console.WriteLine("");
    }
}