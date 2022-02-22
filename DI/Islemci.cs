using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class Islemci
    {
        DersRepository _repository;
        public Islemci(DersRepository repository)
        {
            _repository = repository;
        }
        public void Kayit()
        {
            _repository.dersKaydet();
        }
    }
}
