using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++) // -- burada tanımlanan i = 0 sadece bu blok içerisinde geçerlidir.
            {
                Console.WriteLine(i);

            }
            Console.ReadLine(); // uygulamayı ekranda tutmak için bunu kullanmaktayız.
        }
    }
}
