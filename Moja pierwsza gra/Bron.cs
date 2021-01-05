using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moja_pierwsza_gra
{
    public class Bron
    {
        public string Nazwa { get; set; }
        public int Cena { get; set; }
        public int ModyfikatorObrazen { get; set; }

        public Bron(string nazwa, int cena, int modyfikatorObrazen)
        {
            Nazwa = nazwa;
            Cena = cena;
            ModyfikatorObrazen = modyfikatorObrazen;
        }
    }
}
