using System;

namespace ArraysAlgorithms1
{
    class Program
    {
        static void Main(string[] args)
        {
            // diziTemel();
            // tahmin();
            sirala();
            Console.ReadLine();
        }

        private static void sirala()
        {
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                a[i] = GetFromConsole($"{i+1}.sayıyı girin");
            }
            int min = 0;
            for (int j = 0; j < a.Length - 1; j++)
            {
                min = a[j];
                int temp = 0;
                for (int i = j+1; i < a.Length; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];

                        temp = a[j];
                        a[j] = min;
                        a[i] = temp;
                    }
                }
            }

            #region manuel sıralama
            //int min = a[0];
            //int temp = 0;
            //for(int i=1;i<a.Length;i++)
            //{
            //    if (a[i] < min)
            //    {
            //        min = a[i];

            //        temp = a[0];
            //        a[0] = min;
            //        a[i] = temp;
            //    }
            //}

            //min = a[1];
            //for (int i = 2; i < a.Length; i++)
            //{
            //    if (a[i] < min)
            //    {
            //        min = a[i];

            //        temp = a[1];
            //        a[1] = min;
            //        a[i] = temp;
            //    }
            //}

            //min = a[2];
            //for (int i = 3; i < a.Length; i++)
            //{
            //    if(a[i]<min)
            //    {
            //        min = a[i];

            //        temp = a[2];
            //        a[2] = min;
            //        a[i] = temp;
            //    }
            //}

            //min = a[3];
            //for (int i = 4; i < a.Length; i++)
            //{
            //    if (a[i] < min)
            //    {
            //        min = a[i];

            //        temp = a[3];
            //        a[3] = min;
            //        a[i] = temp;
            //    }
            //}
            #endregion

            Console.WriteLine($"minimum deger={min}");

           
        }
        private static void tahmin()
        {
            int[] a = new int[5];
            Console.WriteLine("aralarda virgül olacak şekilde 5 sayı giriniz.");
            string deger = Console.ReadLine();

            var splited = deger.Split(",");
            int index = 0;
            foreach (var item in splited)
            {
                a[index] = Convert.ToInt32(item);
                index++;
            }

            while (true)
            {
                //  Console.WriteLine("tahmin girin:");
                //   int aranacakSayi = Convert.ToInt32(Console.ReadLine());
                int aranacakSayi = GetFromConsole("tahmin girin:");
                bool bildi = false;
                foreach(var item in a)
                {
                    if(item==aranacakSayi)
                    {
                        Console.WriteLine("Bildiniz");
                        bildi = true;
                        break;
                    }
                }
                if(!bildi)
                Console.WriteLine("Bilemediniz");
            }
        }

        private static void diziTemel()
        {
            int size = GetFromConsole("Eleman sayısı giriniz.");
            int[] a = new int[size];

            for (int i = 0; i < size; i++)
            {
                //   string message = string.Format("dizinin {0}. elemanını girin", i);
                string message = $"dizinin {i + 1}. elemanını girin";
                a[i] = GetFromConsole(message);
            }
            a = DiziCarp(a, 2);

            DiziYazdir(a);
        }

        public static int GetFromConsole(string message)
        {
            Console.WriteLine(message);
            int size = 0;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out size))
                {
                    Console.WriteLine("Girilen Değer hatalı");
                    Console.WriteLine(message);
                }
                else
                {
                    break;
                }
            }
            return size;

        }

        public static void DiziYazdir(int[] dizi)
        {
            string val = "";
            for(int i=0;i<dizi.Length;i++)
            {
                val += $"{dizi[i]},";
            }
            val=val.Substring(0, val.Length - 1);
            Console.WriteLine(val);
        }

        public static int[] DiziCarp(int[]dizi, int deger)
        {
            for(int i=0;i<dizi.Length;i++)
            {
                //dizi[i] = dizi[i] * deger;
                dizi[i] *= deger;
            }

            return dizi;
        }
    }
}
