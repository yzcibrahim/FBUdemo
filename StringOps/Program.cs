using System;

namespace StringOps
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 4;

            int temp = a;

            a = b;
            b = temp;

            string deger = "hello world";

            string yenideger = deger.Substring(0, 3);

            string sonDort = deger.Substring(deger.Length-4, 4);

            string strToSplit = "1-2-3-4";

            var asd=strToSplit.Split("-");



        }
    }
}
