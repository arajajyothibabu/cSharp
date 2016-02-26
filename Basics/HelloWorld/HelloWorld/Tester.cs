using System;
using HelloWorld;

namespace HelloWorld
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.Write("Araja Jyothi Babu testing this...");
            Customer customer = new Customer(56, "Araja Jyothi Babu", new DateTime(1994,10,23), "9533162006");
            Console.Write("Customer Details: \n");
            Console.Write(customer.CustomerId + "\n" + customer.Name + "\n" + customer.Age + "\n" + customer.Phone);
            Console.Write("\nAge of Customer: " + customer.Age/365.0 + " years");
            Console.ReadLine();
        }
    }
}
