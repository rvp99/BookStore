using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class KitapManager
    {
        private List<Kitap> kitaplar;

        public KitapManager()
        {
            kitaplar = new List<Kitap>()
            {
                new Kitap {Id = 1,Name = "Semerkant",Yazar = "Amin Moulouf",YayinEvi = "Doğuş",Fiyat = 150},
                new Kitap {Id = 2,Name = "Aşk",Yazar = "Elif Şafak",YayinEvi = "Remzi",Fiyat = 165}
            };

            while (true)
            {
                string secim;
                Console.Clear();
                Console.WriteLine("Kitaplar Sayfasına Hoşgeldiniz.");
                Console.WriteLine("");
                Console.WriteLine("1- Kitap Ekle");
                Console.WriteLine("2- Kitap Sil");
                Console.WriteLine("3- Kitap Update");
                Console.WriteLine("4- Tümünü Görüntüle");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Ekle();
                        break;
                    case "4":
                        TumunuGoruntule();
                        break;
                }
            }
        }

        public void Ekle()
        {
            int Id, Fiyat;
            string Name, Yazar, YayinEvi;
            
            Console.Clear();
            Console.Write("Kitap Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Kitap Adı: ");
            Name = Console.ReadLine();
            Console.Write("Kitap Yazarı: ");
            Yazar = Console.ReadLine();
            Console.Write("Kitap Yayınevi: ");
            YayinEvi = Console.ReadLine();
            Console.Write("Kitap Fiyatı: ");
            Fiyat = int.Parse(Console.ReadLine());

            Kitap eklenenKitap = new Kitap()
            {
                Id = Id,
                Name = Name,
                Yazar = Yazar,
                YayinEvi = YayinEvi,
                Fiyat = Fiyat
            };

            kitaplar.Add(eklenenKitap);

        }

        public void TumunuGoruntule()
        {
            Console.Clear();
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine("{0} {1,-20} {2}",kitap.Id,kitap.Name,kitap.Yazar);
            }

            Console.ReadLine();
        }
    }
}
