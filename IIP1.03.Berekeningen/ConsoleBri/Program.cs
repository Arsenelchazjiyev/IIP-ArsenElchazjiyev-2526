using System;

namespace ConsoleBri
{
   class Program
   {
      static void Main(string[] args)
      {
		  Console.WriteLine(@"BRI CALCULATOR 🏋
=================");
		  Console.Write("Taille (in cm): ");
		  int taille = Convert.ToInt32(Console.ReadLine());
		  Console.Write("Lengte (in cm): ");
		  int lengte = Convert.ToInt32(Console.ReadLine());
		  const double basis = 364.2;
		  const double factor = 365.5;
		  double PiLengte = Math.PI * lengte;
		  double gedeeld = taille / PiLengte;
		  double kwadraat1 = gedeeld * gedeeld;
		  double kwadraat2 = 1 - kwadraat1;
		  double vierkantswortel = Math.Sqrt(kwadraat2);
		  double BRI = basis - (factor * vierkantswortel);
		  Console.ForegroundColor = ConsoleColor.Green;
		  Console.WriteLine($"Je BRI bedraagt: {BRI:F1}");
		  Console.ResetColor();
		  Console.Write("Een BRI tussen 3,14 en 4,44 is normaal");
	  }
   }
}
