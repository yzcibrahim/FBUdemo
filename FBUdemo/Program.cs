using System;

namespace FBUdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    string deger = Console.ReadLine();
            //    if (deger.ToLower().Contains("asd".ToLower()))
            //    {
            //        Console.WriteLine("içeriyor");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NOOO!1");
            //    }
            //}
            // Console.WriteLine("Hello World!");
            Factory fc = new Factory();

            Kedi k = (Kedi)fc.Uret(hayvanTip.kedi, "boncuk");

            Kedi k2 = (Kedi)fc.Uret(hayvanTip.kedi, "duman");

            Kopek kopek1 = (Kopek)fc.Uret(hayvanTip.kopek, "tom");

         //   Hayvan h = new Hayvan();

           
            // kopek1.Konus();
            Invoker.Invoke(kopek1);

            k2.Tanitim();
            kopek1.Tanitim();

            Kopek kopek2= (Kopek)fc.Uret(hayvanTip.kopek, "karabaş");

            Invoker.Invoke(kopek2);

            Invoker.Invoke(k);

            Kus ks = new Kus();
            Invoker.Invoke(ks);

        }

    }



   
}
