using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Yazar { get; set; }
        public string YayinEvi { get; set; }
        public int Fiyat { get; set; }
    }
}
