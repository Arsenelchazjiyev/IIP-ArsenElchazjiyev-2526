using System;

namespace ConsoleContactCard
{
   class Program
   {
      static void Main(string[] args)
      {
         string naam = "Bobby Peru";
		 bool getrouwd = false;
		 string telefoon = "0486/33.22.19";
		 int leeftijd = 25;
		 decimal salaris = 2500.00m;	
		 char geslacht = 'm';
		 double lengte = 1.75; 
		 Console.WriteLine("-------------------------------");
		 Console.WriteLine("*");
		 Console.WriteLine($"* Naam: {naam}");
		 Console.WriteLine($"* Gehuwd: {getrouwd}");
		 Console.WriteLine($"* Telefoon: {telefoon}");
		 Console.WriteLine($"* Leeftijd: {leeftijd}");
		 Console.WriteLine($"* Salaris: {salaris.ToString("C2")} per maand");
		 Console.WriteLine($"* Geslacht: {geslacht}");
		 Console.WriteLine($"* Lengte: {lengte.ToString("F2")}m");
		 Console.WriteLine("*");
		 Console.WriteLine("-------------------------------");
		 Console.WriteLine("Druk op een toets om verder te gaan");
      }
   }
}
