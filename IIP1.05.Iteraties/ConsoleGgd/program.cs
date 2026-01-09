using System;
namespace ConsoleGgd
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(@"BEREKEN GROOTST GEMENE DELER
============================");
			Console.Write("Getal 1: ");
			int A = Convert.ToInt32(Console.ReadLine());
			Console.Write("Getal 2: ");
			int B = Convert.ToInt32(Console.ReadLine());
			
			while (A != B)
			{
				if (A > B)
				{
					A = A - B;
				}
				if (B > A)
				{
					B = B - A;
				}
			}
			Console.WriteLine($"De grootste gemene deler is: {A}");
		}
	}
}
