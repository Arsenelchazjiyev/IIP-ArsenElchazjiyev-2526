using System;

namespace ConsoleAtm
{
   class Program
   {
      static void Main(string[] args)
      {
		Console.WriteLine(@"Bankautomaat
============");
		int saldo = 500;
		Console.WriteLine($"Huidige saldo: {saldo:C2}");
		Console.WriteLine();
		Console.WriteLine("(a) afhaling");
		Console.WriteLine("(b) storting");
		Console.WriteLine("(c) stoppen");
		Console.WriteLine();
		char keuze = Console.ReadKey(true).KeyChar;
		Console.WriteLine($"Je keuze: {keuze}");
		
		switch (keuze)
		{
			case 'a':
				Console.Write("Welke bedrag wil je afhalen? ");
				int afhaalBedrag = Convert.ToInt32(Console.ReadLine());
				const int maximumAfhaalBedrag = 600;
				if (afhaalBedrag < 0)
				{
					Console.WriteLine("fout: bedrag moet positief zijn!");
				}
				else if ((saldo - afhaalBedrag) < 0)
				{
					Console.WriteLine("Het saldo mag niet onder 0 staan");
				}
				else if (afhaalBedrag > maximumAfhaalBedrag)
				{ 
					Console.WriteLine($"Fout: Je kan maximaal {maximumAfhaalBedrag} afhalen");
				}
				else if ((afhaalBedrag % 10 != 0) || (afhaalBedrag == 10 || afhaalBedrag == 30))
				{
					Console.WriteLine("Fout: Enkel briefjes van 20 50 zijn mogelijk");
				}
				else 
				{
					saldo = saldo - afhaalBedrag;
					Console.WriteLine($"Afhaling OK - het nieuwe saldo is {saldo} ");
				}
				break;
			case 'b':
				Console.Write("Welke bedrag wil je storten? ");
				int stortbedrag = Convert.ToInt32(Console.ReadLine());
				if (stortbedrag < 0)
				{
					Console.WriteLine("fout: bedrag moet positief zijn!");
				}
				else 
				{
					saldo = saldo + stortbedrag;
					Console.WriteLine($"Storting OK - Het nieuwe saldo is: {saldo:C2}");
				}
				break;
			case 'c':
				Console.Write("Bedankt en tot ziens!");
				break;
			default:
				Console.WriteLine("Ongeldige keuze!");
				break;
		}

	  }
   }
}