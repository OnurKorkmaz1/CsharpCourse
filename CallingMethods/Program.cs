using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello world!");  // Bu kısımda oluşturduğumuz kod blok kısmını yukarıda isimlendirerek çağırmamıza imkan sağlıyor.
        }
    }
}
