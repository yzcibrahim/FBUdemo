using System;

namespace AbstrationByInterface
{
    public class Kopek:IHayvan
    {
        public string Isim { get; set; }
        public int Yas { get; set; }
        public Kopek(string name)
        {
            Isim = name;
        }

        public void Konus()
        {
            Console.WriteLine("Haw " + Isim);
        }

        //public void Tanitim()
        //{
        //    Console.WriteLine("Benim adım:" + Isim);
        //}
    }
}
