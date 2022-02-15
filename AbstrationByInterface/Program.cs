using System;

namespace AbstrationByInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek1 = new Kopek("asd");
            Invoker.Invoke(kopek1);

            Kedi kedi1 = new Kedi("kedicik");
            Invoker.Invoke(kedi1);

            Console.WriteLine("Hello World!");
        }
    }
}
