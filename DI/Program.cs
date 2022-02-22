using System;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DersRepository dr = new DersRepository();

            Islemci i = new Islemci(dr);
            i.Kayit();

            Duzeltme d = new Duzeltme(dr);
            d.Duzelt();

            //X x = new X();

            //B bobjesi = new B(x);
            //bobjesi.b1();
            //bobjesi.b2();

            //C cobjesi = new C(x);
            //cobjesi.c1();
        }
    }

    public class X
    {
        public void method1()
        {
            Console.WriteLine("insert yapıldı");
        }
        public void method21()
        {
            Console.WriteLine("update yapıldı");
        }
    }

    public class B
    {
        X _x;
        public B(X x)
        {
            _x = x;
        }
        public void b1()
        {
            _x.method1();
        }

        public void b2()
        {
            _x.method21();
        }
    }

    public class C
    {
        X _x;
        public C(X x)
        {
            _x = x;
        }

        public void c1()
        {
            _x.method21();
        }
    }



}
