using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBUdemo
{
    public abstract class Hayvan
    {

        public abstract void Konus();

        public virtual void Tanitim()
        {
            Console.WriteLine("asdasd");
        }

    }

    public interface IHayvan
    {
        void Konus();
    }
}
