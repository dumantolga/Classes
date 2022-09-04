using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManger();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1997, 3, 31), FirstName = "Tolga", LastName = "Duman", NationalityId = "12345678910" });
            Console.ReadLine();
        }
    }
}
