using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrationByInterface
{
    public class Kedi:IHayvan
    {

        public string Isim { get; set; }
        public string Renk { get; set; }

        public static int ToplamAdet { get; set; } = 0;
        public Kedi(string name)
        {
            ToplamAdet++;
            Isim = name;
        }

        public void Konus()
        {
            Console.WriteLine("Miyav");
        }
    }
}
