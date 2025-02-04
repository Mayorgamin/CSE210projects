using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Products
        Product product1 = new Product("Beeksteak tomatoes", "BT001", 1.95, 3);
        Product product2 = new Product("Frozen buttermil pancakes", "BP001", 3.74, 2);
        Product product3 = new Product("Fish Market Chilean Atlantic salmon skin on fillets portions", "FMCAS002", 10.49, 4);
        Product product4 = new Product("Hickory smoked bacon", "HSB002", 3.99, 4);

        
        //Order 1
        Address address1 = new Address("2772 Cinnamon Lane", "San Antonio", "Texas", "USA");
        Customer customer1 = new Customer("George Andrews", address1);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        
        Console.WriteLine("Order 1: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total price: ${order1.GetTotalPrice():F2}"); // Total price should be: $18.33
       
        // Order 2 
        Address address2 = new Address("1209 George Avenue", "Mobile", "Alabama", "USA");
        Customer customer2 = new Customer("Andrew Wall", address2);
        
        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("\nOrder 2: ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total price: ${order2.GetTotalPrice():F2}"); // Total price should be: $68.77

        // Order 3
        Address address3 = new Address("4 Shore Court", "Shore Lane", "Manchester", "England");
        Customer customer3 = new Customer("Soila Sorda", address3);
        
        Order order3 = new Order(customer3);
        order3.AddProduct(product2);
        order3.AddProduct(product3);
        order3.AddProduct(product4);

        Console.WriteLine("\nOrder 3: ");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total price: ${order3.GetTotalPrice():F2}"); // Total price should be: $100.40
    }
}



