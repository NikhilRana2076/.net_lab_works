using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program5
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> customers = new Dictionary<int, string>();

            customers.Add(191811, "Archana");
            customers.Add(191812, "Kritika");
            customers.Add(191813, "Nikhil");
            customers.Add(191814, "Prakash");
            customers.Add(191815, "Rochak");

            foreach (KeyValuePair<int, string> customer in customers)
            {
                Console.WriteLine("Customer ID: " + customer.Key + "  " + "Customer Name: " + customer.Value);
            }

            Console.ReadLine();
        }
    }

}