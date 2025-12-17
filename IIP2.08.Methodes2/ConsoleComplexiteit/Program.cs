using System;

namespace ConsoleComplexiteit
{
    internal class Program
    {
        private static bool IsKlinker(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y';
        }
        private static int AantalLettergrepen(string woord)
        {
            int aantalGroepen = 0;
            bool vorigeWasKlinker = false;
            for (int i = 0; i < woord.Length; i++)
            {
                char c = woord[i];
                bool isKlinker = IsKlinker(c);
                if (isKlinker && !vorigeWasKlinker)
                {
                    aantalGroepen++;
                }

                vorigeWasKlinker = isKlinker;
            }

            return aantalGroepen;
        }

        private static double Complexiteit(string woord)
        {
            double aantalLetters = woord.Length;
            double aantalGroepen = AantalLettergrepen(woord);
            double complexiteit = aantalLetters / 3.0 + aantalGroepen;
            if (woord.Contains("q")) complexiteit += 1;
            if (woord.Contains("x")) complexiteit += 1;
            if (woord.Contains("y")) complexiteit += 1;
            return Math.Round(complexiteit, 1);
        }

        static void Main(string[] args)
        {
            string woord;
            do
            {
                Console.Write("Geef een woord (enter om te stoppen): ");
                woord = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(woord))
                {
                    int aantalKarakters = woord.Length;
                    int aantalGroepen = AantalLettergrepen(woord);
                    double complexiteit = Complexiteit(woord);
                    Console.WriteLine($"aantal karakters: {aantalKarakters}");
                    Console.WriteLine($"aantal lettergrepen: {aantalGroepen}");
                    Console.WriteLine($"compliexteit: {complexiteit}");
                    Console.WriteLine();
                }
            }
            while (!string.IsNullOrWhiteSpace(woord));
            
            Console.WriteLine("Bedankt en tot ziens.");
        }
    }
}