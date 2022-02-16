﻿using System;

namespace DiziAsalSayiOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            // soru1AsalSAyi();
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
                if(iceriyorMu(a,sayi))
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