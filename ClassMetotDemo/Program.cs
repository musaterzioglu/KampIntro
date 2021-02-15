using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Ahmet";
            customer1.CustomerNo = 8;
            customer1.Gender = "Male";

            Customer customer2 = new Customer();
            customer2.CustomerId = 1;
            customer2.CustomerName = "Merve";
            customer2.CustomerNo = 12;
            customer2.Gender = "Female";

            Customer customer3 = new Customer();
            customer3.CustomerId = 1;
            customer3.CustomerName = "Melih";
            customer3.CustomerNo = 5;
            customer3.Gender = "Male";

            Customer[] customers = { customer1, customer2, customer3 };

            CustomerManager customer = new CustomerManager();
            customer.Add(customer3);
            customer.Delete(customer1);
            customer.Update(customer2);

        }
    }
}
