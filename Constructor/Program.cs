using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            new Ornek();
            new Ornek();
            new Ornek();
            new Ornek();


            Console.Read();
        }
        
    }

    class Ornek
    {
        #region Constructor

        // Constructor method public olmalıdır. Private olursa nesne oluşturmayı engeller.
        // constructor methodun geri dönüş değeri olmaz
        // constructer metodun ismi sınıf ismi ile aynı olmak zorundadır.
        // Normal oluşturduğumuz sınıflar methodlar ile aynı isimde olamazlar !!!
        public int x { get; set;}
        public Ornek() 
        {
            //x = 15;
            Console.WriteLine("Nesne Oluşturuldu.");

        }

        #endregion

        #region  Static Constructor

        // normal constructor dan önce çalışan metoddur.
        // ilgili sınıftan yapılan taleplerinden ilkinde tetiklenir sonrakilerde tetiklenmez.

        static Ornek()
        {
            Console.WriteLine("Constructer dan önce çalıştı. Ama sadece 1 kez");
        }

        #endregion

    }
}
