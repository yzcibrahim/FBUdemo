using System;

namespace arraysAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region dizi tanımlama 
            //int[] a = new int[2];
            //int[] b = new int[] { 3, 5 };
            #endregion

      //      Console.WriteLine("dizi eleman sayısını giriniz");

            //  int count = Convert.ToInt32(Console.ReadLine());
            #region tryCatch
            //int count = 0;

            //try
            //{
            //    count = int.Parse(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("Dönüştürme gerçekleştirilemedi");
            //} 
            #endregion

            // int count = int.TryParse()

            //  int a[]=new int[5]

            while (true)
            {
                string deger = Console.ReadLine();
                string bilmemneVal = "";
                string xVal = "";
                string pascalval = Method1(deger, out bilmemneVal, out xVal);
               
                Console.WriteLine("PAscal Case:"+pascalval);
                Console.WriteLine("bilmemne Case:" + bilmemneVal);
                Console.WriteLine("xval Case:" + xVal);
            }

        }
        public static string Method1(string prm, out string prm2, out string prm3)
        {
            string pascalVal = prm[0].ToString().ToUpper();
            string bilmemNeVal= prm[0].ToString().ToLower();
            string xVal = prm[0].ToString().ToUpper();
            for (int i = 1; i < prm.Length; i++)
            {
                pascalVal += prm[i].ToString().ToLower();
                bilmemNeVal+= prm[i].ToString().ToUpper();
            }
            prm2 = bilmemNeVal;


            for (int i = 1; i < prm.Length; i++)
            {
                if (i % 2 == 1)
                {
                    xVal += prm[i].ToString().ToLower();
                }
                else
                {
                    xVal += prm[i].ToString().ToUpper();
                }
            }

            prm3 = xVal;




            return pascalVal;
        }
    }
}
