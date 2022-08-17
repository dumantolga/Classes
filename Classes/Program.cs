using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Antakya";
            customer.Id = 1;
            customer.FirstName = "Tolga";
            customer.LastName = "Duman";

            Customer customer1 = new Customer
            {
                City = "İstanbul",
                Id = 2,
                FirstName = "Engin",
                LastName = "Demir"
            };

            Console.WriteLine(customer.FirstName);

            Console.ReadLine();
        }

    }

}
