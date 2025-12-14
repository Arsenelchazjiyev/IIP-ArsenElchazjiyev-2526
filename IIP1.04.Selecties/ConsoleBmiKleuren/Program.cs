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
      }
   }
}