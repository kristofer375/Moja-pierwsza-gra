using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moja_pierwsza_gra
{
    class Program
    {
        private static string nazwaPostaci;
        private static int maksymalneZycie;
        private static int pozostaleZycie;
        static void Main(string[] args)
        {
            nazwaPostaci = " ";
            int liczba = DajWieksza(5, 7);
            Console.WriteLine(liczba);
            ObsługaMenu();
            Console.ReadLine();
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
            MenuGry();
        }

        static void MenuGry()
        {
            Console.Clear();
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
            nazwaPostaci = Console.ReadLine();
        }

        static void idzNaWyprawe()
        {
            Console.Clear();
            Console.WriteLine("Wyruszyłeś na wyprawę");
            if(Walka())
            {
                BonusZaZwyciestwo();
            }
        }
        static bool Walka()
        {
            if(pozostaleZycie <= 0)
            {
                return false;
            }
            return true;
        }
        static void BonusZaZwyciestwo()
        {

        }
        static void Przegrana()
        {
            pozostaleZycie = 1;
        }
    }
}
