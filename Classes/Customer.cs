using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }   // müşterilerin verilerini tutmak için kullanabileceğimiz kısım.
        public string FirstName { get; set; }  // buna property tanımlamak deniyor.
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
