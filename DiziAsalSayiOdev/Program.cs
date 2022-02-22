using System;

namespace DiziAsalSayiOdev
{
    public class aClass
    {
        public const int deger1=5;
        public readonly int degerRead = 6;
        public aClass()
        {
            degerRead = 15;
        }
    }
    class Program
    {
        

        const int constVar= 5;
        readonly int readonlyVar;
        static void Main(string[] args)
        {

            aClass myObject = new aClass();
            
            //  diziYazdir();

            int X = 6;
            string ifade  = "";

            #region if vs inline if
            if (X>5)
            {
                ifade = "büyük";
            }
            else
            {
                ifade = "küçük";           
            }
            Console.WriteLine(ifade);

            ifade = X > 5 ? "büyük" : "küçük";
            Console.WriteLine(ifade);
            #endregion

            int? nullablaA;
            
            // soru1AsalSAyi();
            // odev2EksikBulma();
            int size = Convert.ToInt32(Console.ReadLine());
            //  KareCizme(size);
            // Ucgen(size);
            Baklava(size);

            

        }

        private static void diziYazdir()
        {

            int[] a = new int[] { 1, 2, 3, 4, 5, 6 };

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine($"{i}.eleman {a[i]}");
            //}


            //for (int i = a.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //int i = a.Length - 1;
            //while (i >= 0)
            //{
            //    Console.WriteLine(a[i]);
            //    i--;
            //}

            for (int i = 0; i < a.Length; i++)
            {
                int index = a.Length - 1 - i;
                Console.WriteLine(a[index]);
            }

        }

        private static void Baklava(int size)
        {

            for(int i=0;i<= size; i++)
            {
                Console.Write(i);
                for(int j=0;j< size - i;j++)
                {
                    Console.Write(" ");
                }
                
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (int i = size-1; i >=0; i--)
            {
                Console.Write(i);
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }



            //for(int i=0;i<=size;i++)
            //{
            //    Console.Write(i);
            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j=0;j<2*size-(2*i+1);j++)
            //    Console.Write("*");
            //    Console.WriteLine("");
            //}



        }

        private static void Ucgen(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }
        }

        private static void KareCizme(int size)
        {
            for(int i=0;i<size;i++)
            {
                for(int k=0;k<size;k++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
             //   Console.Write("\n");
               // Console.WriteLine("*****");
            }
        }

        private static void odev2EksikBulma()
        {
            int[] a = new int[10];
            for (int j = 0; j < 10; j++)
                a[j] = -1;
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("0 - 10 arası bir sayı giriniz");
                int sayi = 0;

                if (!int.TryParse(Console.ReadLine(), out sayi))
                {
                    Console.WriteLine("girilen değer hatalı.");
                    continue;
                }
                if (sayi > 10)
                {
                    Console.WriteLine("SAyı 10 dan küçük olmalıdır.");
                    continue;
                }
                if (iceriyorMu(a, sayi))
                {
                    Console.WriteLine("SAyı daha önce girilmiş");
                    continue;
                }

                a[i] = sayi;
                i++;

            }
            eksikBul(a);
        }

        private static void eksikBul(int[] a)
        {
            #region
            //int toplam = 10 * 11 / 2;
            //int diziToplam = 0;
            //for(int i=0;i<10;i++)
            //{
            //    diziToplam += a[i];
            //}
            #endregion

            for(int i=1;i<=10;i++)
            {
                if(!iceriyorMu(a,i))
                {
                    Console.WriteLine($"eksik SAyı {i}");
                    return;
                }
            }
            Console.WriteLine("eksikSaiYok");

        }

        private static bool iceriyorMu(int[] a, int sayi)
        {
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] == sayi)
                    return true;
            }
            return false;
        }

        private static void soru1AsalSAyi()
        {
            int[] dizi = new int[10];
            int index = 0;

            for (int i = 2; ; i++)
            {
                if (index >= 10)
                    break;
                if (asalMi(i))
                {
                    dizi[index] = i;
                    index++;
                }
            }
        }

        private static bool asalMi(int a)
        {
            if (a < 2)
                return false;

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
    }
}
