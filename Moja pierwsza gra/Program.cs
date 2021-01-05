using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moja_pierwsza_gra
{
    class Program
    {
        private static Bohater _bohater;
        private static List<IBron> _bronie;
        private static List<Zbroja> _zbroje;
        static void Main(string[] args)
        {
            StworzBron();
            ObsługaMenu();
        }
        static void StworzBron()
        {
            _bronie = new List<IBron>();
            _zbroje = new List<Zbroja>();
            Bron bron = new Bron("Kij", 3, 4);
            _bronie.Add(bron);

            _bronie.Add(new Bron("Kamień", 1, 2));
            _bronie.Add(new Bron("Błogosławieństwo", 0, 999));
            _bronie.Add(new BronDwureczna("Szpony", 4, 3));

            _zbroje.Add(new Tarcza { Nazwa = "Tarcza Duranda", Obrona = 10, PoziomZuzycia = 0 });
            _zbroje.Add(new Napiersnik { Nazwa = "Kolczuga", Obrona = 20, PoziomZuzycia = 0 });
        }

        static void ObsługaMenu()
        {
            Console.WriteLine("1. Nowa gra");
            Console.WriteLine("2. Wczytaj grę");
            Console.WriteLine("3. Koniec");

            string opcja = Console.ReadLine();
            if (opcja == "1")
            {
                StworzPostac();
            }
            else if (opcja == "2")
            {

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dzięki za grę");
                return;
            }
            while (opcja != "5")
            {
                MenuGry();
                opcja = Console.ReadLine();
                if (opcja == "0")
                    _bohater.ZobaczPostac();
                else if (opcja == "1")
                    IdzNaWyprawe();
                else if (opcja == "2")
                    _bohater.Odpocznij();
                else if (opcja == "3")
                    Console.WriteLine("Chwilowo niedostępne");
                else if (opcja == "4")
                    Sklep();
                _bohater.Przegrana();
                Console.WriteLine();
                Console.Write("Naciśnij enter");
                Console.ReadLine();
            }
            
        }

        static void MenuGry()
        {
            Console.Clear();
            Console.WriteLine("0 Zobacz postac");
            Console.WriteLine("1 Idź na wyprawę");
            Console.WriteLine("2 Odpocznij");
            Console.WriteLine("3 Ekwipunek");
            Console.WriteLine("4 Sklep");
            Console.WriteLine("5 Koniec");
            
        }

        static int DajWieksza(int liczba1, int liczba2)
        {
            if (liczba1 < liczba2)
                return liczba2;
            return liczba1;
        }

        static void StworzPostac()
        {
            Console.Clear();
            Console.Write("Podaj imię postaci: ");
            _bohater = new Bohater(Console.ReadLine());
        }

        static void IdzNaWyprawe()
        {
            Console.Clear();
            Console.WriteLine("Wyruszyłeś na wyprawę");
            if(Walka())
            {
                BonusZaZwyciestwo();
                return;
            }
            

        }
        static bool Walka()
        {
            Random losuj = new Random();
            int zyciePrzeciwnika = losuj.Next(8,12);

            while (_bohater.PosiadaneZycie > 0)
            {
                int obrazenia = _bohater.NoszonaBron.ObliczObrazenia();
                int obrazeniaZadane = losuj.Next(obrazenia - 1, obrazenia + 1);
                zyciePrzeciwnika -= obrazeniaZadane;
                if (zyciePrzeciwnika <= 0)
                    return true;
                int obrazeniaOtrzymane = losuj.Next(0, 4);
                _bohater.PosiadaneZycie -= obrazeniaOtrzymane;
            }
            return false;
        }
        static void BonusZaZwyciestwo()
        {
            Random losuj = new Random();
            int temp = losuj.Next(0, 2);
            _bohater.Sakwa += temp;
            Console.WriteLine("Zdobyto " + temp + " złota");
        }
        static void Sklep()
        {
            Console.Clear();
            int licznik = 1;
            foreach(IBron bron in _bronie)
            {
                Console.WriteLine(licznik + " " + bron.Nazwa);
                licznik++;
            }
            foreach (Zbroja zbroja in _zbroje)
            {
                Console.WriteLine(licznik + " " + zbroja.Nazwa);
                licznik++;
            }
            Console.Write("Wybierz bron: ");
            string odczyt = Console.ReadLine();
            int opcja = int.Parse(odczyt);

            if(opcja <= _bronie.Count)
            {
                IBron wybranaBron = _bronie[opcja - 1];
                _bohater.KupBron(wybranaBron);
            }else
            {
                opcja -= _bronie.Count;
                Zbroja wybranaZbroja = _zbroje[opcja - 1];
                if(wybranaZbroja is Tarcza)
                {
                    _bohater.NoszonaTarcza = wybranaZbroja as Tarcza;
                }else
                {
                    _bohater.NoszonyNapiersnik = (Napiersnik)wybranaZbroja;
                }
            }

            
        }
        
    }
}
