using System;

namespace FBUdemo
{
    public class Kopek: Hayvan
    {
        public string Isim { get; set; }
        public int Yas { get; set; }
        public Kopek(string name)
        {
            Isim = name;
        }

        public override  void Konus()
        {
            Console.WriteLine("Haw "+ Isim);
        }

        public override void Tanitim()
        {
            Console.WriteLine("Benim adım:" + Isim);
        }
    }
}
