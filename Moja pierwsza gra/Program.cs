﻿using System;
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
        private static int lvl;
        static void Main(string[] args)
        {
            nazwaPostaci = " ";
            int liczba = DajWieksza(5, 7);
            PetlaFor();
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
            while (opcja != "5")
            {
                MenuGry();
                opcja = Console.ReadLine();
                if (opcja == "0")
                    ZobaczPostac();
                else if (opcja == "1")
                    IdzNaWyprawe();
                else if (opcja == "2")
                    Odpocznij();
                else if (opcja == "3")
                    Console.WriteLine("Chwilowo niedostępne");
                else if (opcja == "4")
                    Console.WriteLine("Chwilowo niedostępne");
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
            nazwaPostaci = Console.ReadLine();
            lvl = 1;
            maksymalneZycie = pozostaleZycie = 10;
        }
        static void ZobaczPostac()
        {
            Console.Clear();
            Console.WriteLine(nazwaPostaci + " lvl: " + lvl);
            Console.WriteLine("Życie: " + pozostaleZycie + "/" + maksymalneZycie);
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
            Przegrana();

        }
        static bool Walka()
        {
            Random losuj = new Random();
            int zyciePrzeciwnika = losuj.Next(8,12);

            while (pozostaleZycie > 0)
            {
                int obrazeniaZadane = losuj.Next(2, 3);
                zyciePrzeciwnika -= obrazeniaZadane;
                if (zyciePrzeciwnika <= 0)
                    return true;
                int obrazeniaOtrzymane = losuj.Next(0, 4);
                pozostaleZycie -= obrazeniaOtrzymane;
            }
            return false;
        }
        static void BonusZaZwyciestwo()
        {

        }
        static void Przegrana()
        {
            pozostaleZycie = 1;
            Console.WriteLine("Przegrałeś, ale uciekłeś");
        }
        static void Odpocznij()
        {
            Console.WriteLine("Przysiadasz aby odpocząć");
            pozostaleZycie++;
            if (maksymalneZycie < pozostaleZycie)
                pozostaleZycie = maksymalneZycie;
        }
        static void PetlaFor()
        {
            for(int krok = 1; krok <= 10; krok++)
            {
                Console.WriteLine("krok " + krok);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
