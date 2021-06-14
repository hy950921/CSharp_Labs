using System;

namespace Exercise1
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int CustomerID { get; private set; }     //read-only
        public override string ToString()
        {
            return Name + "\t" + City + "\t" + CustomerID;
        }

        public Customer(int customerID)
        {
            CustomerID = customerID;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(1);   //set the id by constructor
            c.Name = "Joe Baiden";
            c.City = "DC";
            Console.WriteLine(c);
        }
    }
}
