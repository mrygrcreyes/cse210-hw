using System;

class Program
{
    static void Main(string[] args)
    {
        Product prod1 = new Product("Pants", "1234", 27.99, 3);
        Product prod2 = new Product("Dress", "5678", 74.95, 2);
        Product prod3 = new Product("Shoes", "9637", 259.99, 1);

        Order order1 = new Order();
        Address address1 = new Address("42-A Bonifacio Street", "Tuguegarao City", "Cagayan", "Philippines");
        Customer cust1 = new Customer("Maria Valdez", address1);
        order1.AddItem(prod1);
        order1.AddItem(prod3);
        
        order1.PrintTotalCost(address1);
        order1.PrintPackingLabel();
        order1.PrintShippingLabel(address1, cust1);
        Console.WriteLine();

        Order order2 = new Order();
        Address address2 = new Address("1 Viceroy", "Quezon City", "Metro Manila", "Philippines");
        Customer cust2 = new Customer("Julia Mateo", address2);
        order2.AddItem(prod1);
        order2.AddItem(prod2);
        order2.AddItem(prod3);
        
        order2.PrintTotalCost(address2);
        order2.PrintPackingLabel();
        order2.PrintShippingLabel(address2, cust2);

    }
}