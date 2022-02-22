using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class Duzeltme
    {
        DersRepository _repository;

        public Duzeltme(DersRepository dersRep)
        {
            _repository = dersRep;
        }
        public void Duzelt()
        {
            _repository.dersKaydet();
        }
    }
}
