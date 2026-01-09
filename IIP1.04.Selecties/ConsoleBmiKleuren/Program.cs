using System;

namespace ConsoleBmiKleuren
{
   class Program
   {
      static void Main(string[] args)
      {
        Console.WriteLine("BMI Calculactor");
		Console.WriteLine("===============");
		Console.Write("Lengte (in cm): ");
		int lengte = Convert.ToInt32(Console.ReadLine());
		Console.Write("Gewicht (in kg): ");
		int gewicht = Convert.ToInt32(Console.ReadLine());
		double lengteInMeters = lengte / 100.0;
		double BMI = gewicht / (lengteInMeters * lengteInMeters);
		double afgerondBMI = Math.Round(BMI, 1);
		Console.WriteLine($"je BMI bedraagt: {afgerondBMI}");
		if (afgerondBMI < 18.5)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("Je hebt Ondergewicht");
			Console.ResetColor();
		}
		else if (afgerondBMI >= 18.5 && afgerondBMI < 25.00)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Je gewicht is normaal");
			Console.ResetColor();
		}
		else if (afgerondBMI >= 25.0 && afgerondBMI < 30.0)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("Je hebt overgewicht");
			Console.ResetColor();
		}
		else if (afgerondBMI > 30.0)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Je hebt obesitas");
			Console.ResetColor();
		}
	
      }
   }
}