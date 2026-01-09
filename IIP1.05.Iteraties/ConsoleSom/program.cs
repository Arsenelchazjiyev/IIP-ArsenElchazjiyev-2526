using System;
namespace ConsoleSom
{
	class Program
	{
		static void Main(string[] args)
		{
			int som = 0;
			string input;

			do
			{
				Console.Write("Voer een getal in (q om te stoppen): ");
				input = Console.ReadLine();
			}
				if (input != "q")
			{
				int getal = Convert.ToInt32(input);
			} 
				while (input != "q");
				Console.WriteLine($"De som is {som}");
		}
	}
				
					
		
		
		
		
		}
	}
