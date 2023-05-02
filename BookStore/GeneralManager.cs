using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class GeneralManager
    {
        public GeneralManager()
        {
            Console.Clear();
            string secim;
            Console.WriteLine("Ürünler Sayfası.");
            Console.WriteLine("");
            Console.WriteLine("1- Kitaplar");
            Console.WriteLine("2- Kalemler");
            Console.WriteLine("3- Defterler");
            Console.Write("Lütfen İşleminizi Seçiniz: ");
            secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    KitapManager kitapManager = new KitapManager();
                    break;
                default:
                    Console.WriteLine("Böyle bir seçenek yoktur.");
                    break;
            }
        }
        
    }
}
