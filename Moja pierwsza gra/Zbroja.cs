using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moja_pierwsza_gra
{
    public abstract class Zbroja
    {
        public string Nazwa { get; set; }
        public int Obrona { get; set; }
        public int PoziomZuzycia { get; set; }

        public abstract int ModyfikujrObrazenia(int obrazenia);

        public void Zuzycie()
        {
            PoziomZuzycia++;
            if(PoziomZuzycia >= 100 && Obrona > 1)
                Obrona--;
        }

    }
}
