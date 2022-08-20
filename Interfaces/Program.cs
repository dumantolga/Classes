using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            Customermanager customermanager = new Customermanager();
            //SqlServerCustomerDal sql = new SqlServerCustomerDal();
            //OracleCustomerDal oracle = new OracleCustomerDal();
            customermanager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Tolga", LastName = "Duman", Adress = "Antakya" });
            //Customer customer = new Customer();
            //customer.Id = 1;
            //customer.FirstName = "A";
            //customer.LastName = "B";
            //customer.Adress = "aa";
            //PersonManager personManager = new PersonManager();
            //personManager.Add(customer);
            Student student = new Student
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Sa",
                Departmant = "Computer Sciences",
            };
            manager.Add(student);
            manager.Add(new Worker { FirstName = "Engin" });
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
