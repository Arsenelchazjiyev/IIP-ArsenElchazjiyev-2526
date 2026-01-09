using System;

namespace ConsoleRadenGrenzen
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine(@" /$$$$$$$                  /$$                    
| $$__  $$                | $$                    
| $$  \ $$  /$$$$$$   /$$$$$$$  /$$$$$$  /$$$$$$$ 
| $$$$$$$/ |____  $$ /$$__  $$ /$$__  $$| $$__  $$
| $$__  $$  /$$$$$$$| $$  | $$| $$$$$$$$| $$  \ $$
| $$  \ $$ /$$__  $$| $$  | $$| $$_____/| $$  | $$
| $$  | $$|  $$$$$$$|  $$$$$$$|  $$$$$$$| $$  | $$
|__/  |__/ \_______/ \_______/ \_______/|__/  |__/");
		Console.WriteLine("Geef twee gehele getallen in");
		Console.Write("- getal 1: ");
		int getal1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("- getal 2: ");
		int getal2 = Convert.ToInt32(Console.ReadLine());
		Random random = new Random();
		int randomgetal = random.Next(getal1, getal2);
		Console.WriteLine($"Even denken... ja, ik heb een getal tussen {getal1} en {getal2} in mijn hoofd");
		Console.Write("Doe een Gok: ");
		int gegoktgetal = Convert.ToInt32(Console.ReadLine());
		if (randomgetal == gegoktgetal)
		{ 
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("CORRECT");
			Console.ResetColor();
		}
		else if (randomgetal != gegoktgetal && Math.Abs(randomgetal - gegoktgetal) <= 2)
		{
			Console.WriteLine("Je zat er nochtans niet ver af!");
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("FOUT");
			Console.ResetColor();
		}
		
		 
      }
   }
}
