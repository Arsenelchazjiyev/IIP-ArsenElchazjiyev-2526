/*
 * Auteur: Rogier van der Linde
 * Datum: 2025-11-27
 * Onderwerp: programma herschrijven met methodes
 */
using System;
using System.Text;
namespace Visitekaartjes
{
    internal class Program
    {
        private static string LeesNaam()
        {
            string naam;
            do
            {
                Console.Write("Geef een naam (of ENTER om te stoppen): ");
                naam = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(naam) && naam.Length < 2)
                {
                    Console.WriteLine("Ongeldige naam. Probeer opnieuw.");
                }
            }
            while (!string.IsNullOrWhiteSpace(naam) && naam.Length < 2);    
            return naam;
        }
        private static DateTime LeesGeboortedatum()
        {
            DateTime geboortedatum, nu = DateTime.Today;
            bool geboortedatumOk = false;    
            do
            {
                Console.Write("Geboortedatum (yyyy-mm-dd): ");
                string input = Console.ReadLine();
                geboortedatum = Convert.ToDateTime(input);
                geboortedatumOk = geboortedatum <= nu && geboortedatum >= nu.AddYears(-120);
                if (!geboortedatumOk)
                {
                    Console.WriteLine("Ongeldige geboortedatum. Probeer opnieuw.");
                }
            }
            while (!geboortedatumOk);         
            return geboortedatum;
        }
        private static int BepaalLeeftijd(DateTime geboortedatum)
        {
            int leeftijd = DateTime.Today.Year - geboortedatum.Year;
            if (geboortedatum > DateTime.Today.AddYears(-leeftijd)) leeftijd--;
            return leeftijd;
        }
        private static char LeesGeslacht()
        {
            char geslacht;
            bool geslachtOk = false;         
            do
            {
                Console.Write("Geslacht (m/v): ");
                geslacht = Console.ReadKey().KeyChar;
                geslachtOk = geslacht == 'm' || geslacht == 'v';
                if (!geslachtOk)
                {
                    Console.WriteLine("\nOngeldig geslacht. Tik 'm' of 'v'.");
                }
            }
            while (!geslachtOk);      
            return geslacht;
        }
        private static string GeefEmoji(char geslacht, int leeftijd)
        {
            string emoji = "";
            
            if (geslacht == 'm')
            {
                if (leeftijd < 3) emoji = "👶🏻";
                else if (leeftijd < 12) emoji = "🧒🏻";
                else if (leeftijd < 18) emoji = "👦🏻";
                else if (leeftijd < 60) emoji = "👨🏻";
                else emoji = "👨🏻‍🦳";
            }
            else
            {
                if (leeftijd < 3) emoji = "👶🏼";
                else if (leeftijd < 12) emoji = "🧒🏼";
                else if (leeftijd < 18) emoji = "👧🏼";
                else if (leeftijd < 60) emoji = "👩🏻";
                else emoji = "👩🏻‍🦳";
            }        
            return emoji;
        }
        private static string MaakVisitekaartje(string naam, int leeftijd, char geslacht, int stijl)
        {
            string emoji = GeefEmoji(geslacht, leeftijd);
            string kaartje = "";     
            if (stijl == 1)
            {
                kaartje = $@"┌─────────────── ────────────┐
│                            │
│      {naam} {emoji}      
│                            │
└────────────────────────────┘";
            }
            else
            {
                kaartje = $"✦ {naam} {emoji} ✦";
            }         
            return kaartje;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string naam = LeesNaam();
            while (!string.IsNullOrWhiteSpace(naam))
            {
                DateTime geboortedatum = LeesGeboortedatum();
                int leeftijd = BepaalLeeftijd(geboortedatum);
                char geslacht = LeesGeslacht();
                Console.Write("\nStijl (1 of 2): ");
                int stijl = Convert.ToInt32(Console.ReadKey().KeyChar);
                string kaartje = MaakVisitekaartje(naam, leeftijd, geslacht, stijl);
                Console.WriteLine($"\n\n{kaartje}\n");
                naam = LeesNaam();
            }
            Console.WriteLine("Programma beëindigd.");
        }
    }
}