using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Sayilar = new int[25]; // Dizi
                                         // Eleman sayısını önceden belirlemek gerekiyor.
                                         // Elemanları atmasak dahi bellekte yerleri ayrılıyor.
                                         // Performans açısından zayıf
                                         // eleman atarken kod maliyetli

            #region Arraylist
            // değer atarken add methodunu kullamıyoruz
            // değer çağırırken liste mantığında kullanıyoruz
            // istediğimiz tipte veri girebiliriz. Bu yüzden arraylist kullanımı artık yoktur !!!!
            ArrayList liste = new ArrayList();
            liste.Add(1);
            liste.Add(2);

            
            #endregion
            foreach (var item in liste)
            {
                if (item is int)
                {
                    Console.WriteLine((int)item+120);
                }
            }
            #region List
            // Sadece belirledğimiz tipleri kullanacaktır.

            List<int> liste1 = new List<int>();
            liste.Add((int)1);


            #endregion
            Console.ReadLine();
        }
    }
}
