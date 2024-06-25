using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            //if (number == 10)
            //{
            //    Console.WriteLine("number = 10");

            //}
            //else
            //{
            //    Console.WriteLine("number is not 10");
            //}
            //// Console.WriteLine(number == 10 ? "number = 10" : "number is not equal to 10");
            //Console.ReadLine();

            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                default:
                    Console.WriteLine("number 10 or 20");
                    break;

            }
            Console.ReadLine();

            if (number >=0 && number <= 100)
            {
                Console.WriteLine("number is between 0-100");
            }
            else if(number > 100 && number < 200)
            {
                Console.WriteLine("number is between 101-200");
            }
            else if(number >200 || number <0)
            {
                Console.WriteLine("number is less than 0 or greater than 200");

            }


            Console.ReadLine() ;
        }
    }
}
