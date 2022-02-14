using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBUdemo
{
    public class Factory
    {
        public Hayvan Uret(hayvanTip tip, string name)
        {
            // Kedi retVal = new Kedi("asd");
            // return retVal;
            if (tip == hayvanTip.kedi)
            {
                int index = Kedi.ToplamAdet;
                return new Kedi(name + index);
            }
            else 
            {
                return new Kopek(name);
            }

        }
    }

    public enum hayvanTip
    {
        kedi,
        kopek,
        hayvan
    }
}
