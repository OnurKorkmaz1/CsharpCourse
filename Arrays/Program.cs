using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 25, 35 };

            for(int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine("element in index" + i + ":"+ numbers[i] );
            }

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            // -----------------------------------------------------------------

            // get the sum of all array elements
            float total = numbers.Sum();

            // get the total number of elements present in the array
            int sayı = numbers.Count();

            float average = total / sayı;

            Console.WriteLine("Average : " + average);

            // compute the average
            Console.WriteLine("Average using Average() : " + numbers.Average());

            Console.ReadLine();

            string[] students = new string[3];
            {
                students[0] = "Onur";
                students[1] = "Ahmet";
                students[2] = "Recep";

                foreach (var student in students) 
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine();
                Console.ReadLine();


            }
        }
    }
}
