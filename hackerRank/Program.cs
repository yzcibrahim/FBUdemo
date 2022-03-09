using System;
using System.Collections.Generic;
using System.Linq;

namespace hackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eleman sayısı gir");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> ar = new List<int>();

            for(int i=0;i<n;i++)
            {
                ar.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int max = ar.Max();

            int[] a = new int[max+1];

            foreach(var item in ar)
            {
                a[item]++;
            }


            int ciftler = 0;

            for(int i=0;i<a.Length;i++)
            {
                ciftler += a[i] / 2;
            }
            Console.WriteLine(ciftler);

        }
        
        static void myMethod(List<int> liste, int haric, int odenene)
        {
           
        }
    }
}
