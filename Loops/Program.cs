using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i == 0)
                {
                    result = false;
                    i = number;

                }        

            }
            return result;

        }





        static void Main(string[] args)
        {
            if (IsPrimeNumber(6)) 
            {
                Console.WriteLine("this is a prime number");
            }
            else
            {
                Console.WriteLine("this is not a prime number");
            }




            for (int i = 0; i < 100; i++) // -- burada tanımlanan i = 0 sadece bu blok içerisinde geçerlidir.
            {
                Console.WriteLine(i);

            }
            Console.ReadLine(); // uygulamayı ekranda tutmak için bunu kullanmaktayız.
        }
    }
}
