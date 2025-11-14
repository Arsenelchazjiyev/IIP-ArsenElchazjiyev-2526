using System;
namespace ConsoleBuffet
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(@"WELOM IN HET BUFFETRESTAURANT
=============================");
			Console.WriteLine("");
			Console.WriteLine("Alles is à volonté en dranken zijn inbegrepen!");
			Console.WriteLine("!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!");
			Console.ResetColor();
			Console.WriteLine("");
			Console.Write($"Aantal seizoensbuffets (€18.5): ");
			int seizoensbuffets = Convert.ToInt32(Console.ReadLine());
			Console.Write($"Aantal dessertenbuffets (€7.95): ");
			int dessertbuffets = Convert.ToInt32(Console.ReadLine());
			Console.Write($"Aantal kid menus (€8.95): ");
			int kidsmenus = Convert.ToInt32(Console.ReadLine());
			Console.Write($"Fooi (0 indien geen): ");
			int fooi = Convert.ToInt32(Console.ReadLine());	
			const double seizoensbuffetsPrijs = 18.5;
			const double dessertbuffetsPrijs = 7.95;
			const double kidsmenusPrijs = 8.95;
			double prijs1 = seizoensbuffets * seizoensbuffetsPrijs;
			double prijs2 = dessertbuffets * dessertbuffetsPrijs;
			double prijs3 = kidsmenus * kidsmenusPrijs;
			double totaalprijs = prijs1 + prijs2 + prijs3 + fooi;
			Console.WriteLine($"Totaal te betalen: € {totaalprijs:F2}");
			int afgerondTotaal = (int)Math.Floor(totaalprijs);
			Console.WriteLine($"Afgerond naar beneden: € {afgerondTotaal}");
			Console.Write("Cash betaald: € ");
			int cash = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("U krijgt terug:");
			int wisselgeld j
			

			
			
			
			
		}
	}
}