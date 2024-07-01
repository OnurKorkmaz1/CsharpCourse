using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();

            customer.Address = "Ankara";
            customer.FirstName = "Onur";
            customer.LastName = "Korkmaz";
            customer.Id = 1;

            Customer customer2 = new Customer();
            {
                
            }

            Console.WriteLine(customer2.Address);
            Console.WriteLine();
        }
    }
    class CustomerManager                                        // Class
    {
        public void Add()                                        // Method
        {
            Console.WriteLine("Customer Added");
        }
        public void Update()                                    // Method
        {
            Console.WriteLine("Customer Updated");      
        }
        
    }
}
