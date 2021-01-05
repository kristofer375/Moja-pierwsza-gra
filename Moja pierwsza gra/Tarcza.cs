using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moja_pierwsza_gra
{
    public class Tarcza : Zbroja
    {
        public override int ModyfikujrObrazenia(int obrazenia)
        {
            Zuzycie();
            Random losuj = new Random();
            if(losuj.Next(0, 3) == 1)
                return 0;
            obrazenia -= Obrona;
            if(obrazenia < 0)
                return 0;
            return obrazenia;
        }
    }
}
