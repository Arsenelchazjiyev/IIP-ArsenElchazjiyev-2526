using System;

namespace ConsoleHalloWereld
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Hallo Wereld");
		 Console.Write("Hoe Heet je? " );
		 string naam = Console.ReadLine();
		 Console.ForegroundColor = ConsoleColor.Yellow;
		 Console.WriteLine($"Aangename kennismaking, {naam}");
		 Console.ResetColor();
		 Console.WriteLine("Druk een toets om verder te gaan...");
		 Console.ReadKey(true);
		 
      }
   }
}
