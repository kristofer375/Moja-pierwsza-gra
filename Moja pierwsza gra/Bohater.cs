using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moja_pierwsza_gra
{
    public class Bohater
    {
        public string Imie { get; set; }
        public int MaksymalneZycie { get; set; }
        public int PosiadaneZycie { get; set; }
        public int Obrazenia { get; set; }
        public int Level { get; set; }
        public int PunktyDoswiadczenia { get; set; }

        public Bohater(string imie)
        {
            Imie = imie;
            MaksymalneZycie = 10;
            PosiadaneZycie = MaksymalneZycie;
            Level = 1;
            PunktyDoswiadczenia = 0;
        }
        public void Przegrana()
        {
            if(PosiadaneZycie <= 0)
            {
                PosiadaneZycie = 1;
                Console.WriteLine("Przegrałeś...");
            }
        }
        public void ZobaczPostac()
        {
            Console.Clear();
            Console.WriteLine(Imie + " lvl: " + Level);
            Console.WriteLine("Życie: " + PosiadaneZycie + "/" + MaksymalneZycie);
        }
        public void Odpocznij()
        {
            Console.WriteLine("Przysiadasz aby odpocząć");
            PosiadaneZycie++;
            if (MaksymalneZycie < PosiadaneZycie)
                PosiadaneZycie = MaksymalneZycie;
        }
    }
}
