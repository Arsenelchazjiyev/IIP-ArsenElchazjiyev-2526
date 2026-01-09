using System;
namespace ConsoleLancering
{
	class Program
	{
		static void Main(string[] args)
		{
				Console.WriteLine("Hoeveel seconden tot lancering? 5");
				Console.WriteLine();
				Console.WriteLine("for versie:");
				for (int i = 5; i >= 1 ; i--)
				{
					Console.WriteLine(i);
					Console.ReadKey();
				}
				Console.WriteLine("Lift off!");
				Console.WriteLine();
				Console.WriteLine("do-while versie:");
				int getal = 5;
				do
				{
					Console.WriteLine(getal);
					getal--;
				}
				while (getal >= 1);
				Console.WriteLine("Lift off!");
				Console.WriteLine();
				Console.WriteLine("while versie:");
				int getal1 = 5;
				while (getal1 >= 1)
				{
					Console.WriteLine(getal1);
					getal1--;
				}
				Console.WriteLine("Lift off!");
				
			
			
			
			
		}
	}
}
