using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Record Added:  " + " " + "Name: " + customer.CustomerName + " " + "CustomerNumber: " + customer.CustomerNo + " " + "CustomerGender: " + customer.Gender);

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Record Deleted:  " + " " + "Name: " + customer.CustomerName + " " + "CustomerNumber: " + customer.CustomerNo + " " + "CustomerGender: " + customer.Gender);

        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Record Updated:  " + " " + "Name: " + customer.CustomerName + " " + "CustomerNumber: " + customer.CustomerNo + " " + "CustomerGender: " + customer.Gender);

        }
    }
}
