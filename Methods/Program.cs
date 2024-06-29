using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            
            int number1 = 20;
            int number2 = 100;
           

            var result2 = add3(number1, number2);
            var result = Add2(20, 10);
            Console.ReadLine();

        }
        static void Add()
        {
            Console.WriteLine("added!!!");

        }
        static int Add2(int number1, int number2)
        {
            var result =number1 + number2; 
            return result;

        }
        static int add3(int number1, int number2) 
        {
            number1 = 30;             // burada yazılan değer yukarıdaki number1 değerini bağlamaz. sadece add3 methodunu belirler.
                                      // Aksi bir şey olsun istiyorsak ref kullanmalıyız.
            return number1 + number2;
        }
    }
}
