using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secim;
            Console.WriteLine("Kırtasiye Kontrol Programı");
            Console.WriteLine("");
            Console.WriteLine("1- Ürünler");
            Console.WriteLine("2- Stok Kontrol");
            Console.WriteLine("3- Fiyat Kontrol");
            Console.Write("Lütfen Seçiminizi Yapınız: ");
            secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    GeneralManager generalManager = new GeneralManager();
                    break;
                case "2":
                    Console.WriteLine("Stok");
                    break;
                case "3":
                    Console.WriteLine("Fiyat");
                    break;
                default:
                    Console.WriteLine("Böyle bir seçenek bulunmamakda.");
                    break;
            }

            //if (secim == "1")
            //{
            //    Console.WriteLine("Ürünler");
            //}
            //else if (secim == "2")
            //{
            //    Console.WriteLine("Stok");
            //}
            //else if (secim == "3")
            //{
            //    Console.WriteLine("Fiyat");
            //}
            //else
            //{
            //    Console.WriteLine("Böyle bir seçenek bulunmamakda.");
            //}



            Console.ReadLine();
        }
    }
}
