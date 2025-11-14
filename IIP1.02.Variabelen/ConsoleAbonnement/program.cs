using System;

namespace ConsoleAbonnement
{
	class Program
	{
		static void Main(string[] args)
		{ 
		Console.WriteLine("Bestelgegevens");
		Console.WriteLine("==============");
		Console.Write(" - naam klant: ");
		string naam = Console.ReadLine();
		Console.Write(" - Aantal toegangsbeurten: ");
		int toegangsbeurten = int.Parse(Console.ReadLine());
		Console.Write(" - Prijs (b.v. 122,5): ");
		double prijs = double.Parse(Console.ReadLine());
		Console.Write(" - Badkledij inbegrepen (typ true of false): ");
		bool badkledij = bool.Parse(Console.ReadLine());
		Console.Write(" - geslacht (druk 'm' of 'v'): ");
		char geslacht = Console.ReadLine()[0]; 
		
		Random rnd = new Random();
		int getal1 = rnd.Next(1, 1000);
		int getal2 = rnd.Next(1, 10000);
		int getal3 = rnd.Next(1, 100);

		Console.Clear();
		
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine($@"Samenvatting
==========
- Houder: {naam}
- geslacht: {geslacht}
- prijs: €{prijs}
- aantal beurten: {toegangsbeurten}
- incl. badkledij: {badkledij}
- kaartnummer: {getal1}-{getal2}-{getal3} ");
		Console.ResetColor();
		}
	}
}
		
