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
        public int Sakwa { get; set; }
        public IBron NoszonaBron { get; private set; }
        public Napiersnik NoszonyNapiersnik { get; set; }
        public Tarcza NoszonaTarcza { get; set; }

        public Bohater(string imie)
        {
            Imie = imie;
            MaksymalneZycie = 10;
            PosiadaneZycie = MaksymalneZycie;
            Level = 1;
            PunktyDoswiadczenia = 0;
            Sakwa = 10;
            NoszonaBron = new Bron("Pięść", 0, 1);


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
            Console.WriteLine("Zawartość Sakwy: " + Sakwa);
            if(NoszonaBron != null)
                Console.WriteLine("Broń: " + NoszonaBron.Nazwa);
            if(NoszonaTarcza != null)
                Console.WriteLine("Tarcza: " + NoszonaTarcza.Nazwa);
            if (NoszonyNapiersnik != null)
                Console.WriteLine("Napierśnik: " + NoszonyNapiersnik.Nazwa);
        }
        public void Odpocznij()
        {
            Console.WriteLine("Przysiadasz aby odpocząć");
            PosiadaneZycie++;
            if (MaksymalneZycie < PosiadaneZycie)
                PosiadaneZycie = MaksymalneZycie;
        }
        public void KupBron(IBron bron)
        {
            if (bron.Cena <= Sakwa)
            {
                NoszonaBron = bron;
                Sakwa -= bron.Cena;
            }
            else
                Console.WriteLine("Nie stać Cię");
        }
    }
}
