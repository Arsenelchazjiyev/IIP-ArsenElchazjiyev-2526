using System;

namespace ConsoleKlinkersSpaties
{
    internal class Program
    {
        private static int AantalSpaties(string tekst)
        {
            int aantal = 0;
            foreach (char c in tekst)
            {
                if (c == ' ')
                {
                    aantal++;
                }
            }
            return aantal;
        }
        private static int AantalKlinkers(string tekst)
        {
            int aantal = 0;
            foreach (char c in tekst)
            {
                char lower = char.ToLower(c);
                if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u' || lower == 'y')
                {
                    aantal++;
                }
            }
            return aantal;
        }
        private static string NaarGeheimschrift(string tekst)
        {
            string resultaat = "";
            foreach (char c in tekst)
            {
                if (c == ' ')
                {
                    resultaat += ' ';
                }
                else
                {
                    int verschuiving = 1;
                    char nieuw = (char)(c + verschuiving);
                    resultaat += nieuw;
                }
            }
            return resultaat;
        }

        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();     
            int klinkers = AantalKlinkers(tekst);
            int spaties = AantalSpaties(tekst);
            string geheim = NaarGeheimschrift(tekst);
            Console.WriteLine($"deze tekst bevat {klinkers} klinkers en {spaties} spaties");
            Console.WriteLine($"in geheimschrift: {geheim}");
        }
    }
}