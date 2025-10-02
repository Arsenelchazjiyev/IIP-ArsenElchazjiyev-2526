using System;

namespace ConsoleLeeftijd
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.Write("Wat is je voornaam? ");
		 string voornaam = Console.ReadLine();
		 Console.Write("Wat is je leeftijd? ");
		 int leeftijd = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Geef je lievelingskleur ");
		 string kleur = Console.ReadLine();
		 Console.Write($"Hallo, {voornaam}! Jij bent {leeftijd} jaar. Volgend jaar ben je {leeftijd + 1} jouw lievelingskleur is {kleur} ");
      }
   }
}
