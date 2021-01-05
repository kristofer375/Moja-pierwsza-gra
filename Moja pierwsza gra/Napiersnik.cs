using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moja_pierwsza_gra
{
    public class Napiersnik : Zbroja
    {
        public override int ModyfikujrObrazenia(int obrazenia)
        {
            Zuzycie();
            obrazenia -= Obrona;
            if(obrazenia < 0)
                return 0;
            return obrazenia;
        }
    }
}
