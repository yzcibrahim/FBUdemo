using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrationByInterface
{
    public class Invoker
    {
        public static void Invoke(IHayvan k)
        {
            k.Konus();
           // k.Konus();
        }
    }
}
