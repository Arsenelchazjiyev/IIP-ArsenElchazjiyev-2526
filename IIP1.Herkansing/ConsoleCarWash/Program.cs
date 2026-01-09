using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
		const double basisProgramma = 10.00;
		const double deluxeProgramma = 15.00;
		int saldo = 0;
		string saldo1 = saldo.ToString();
		string programma1 = "Basis";
		string programma2 = "Deluxe:";
		char keuze;
		char keuzeProgramma;
		do
        {
            Console.WriteLine("--- 🧼 CARWASH ODISEE 🧼 --- ");
            Console.WriteLine("(a) Wasprogramma kiezen");
            Console.WriteLine("(b) Saldo opladen");
            Console.WriteLine("(q) Betalen en starten");
            Console.WriteLine("(s) volledig stoppen (geld terug)");
            Console.WriteLine();
			Console.WriteLine($"Huidig Saldo: {saldo:C2} ");
			Console.WriteLine("----------------------------------------------");
			Console.WriteLine($"Gekozen Programma = ");
			Console.WriteLine("----------------------------------------------");
			Console.Write("Maak u keuze: ");
            keuze = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (keuze)
            {
				case 'a':
					Console.WriteLine("--- Kies u programma ---");
					Console.WriteLine($"1) {programma1} (€ 10,00)");
					Console.WriteLine($"2) {programma1} (€ 15,00)");
					Console.Write("");
					Console.Write("keuze: ");
					keuzeProgramma = Console.ReadKey().KeyChar;
					Console.Write("");
					Console.Write("Keuze Verwerkt. Druk op Enter:");
					if (keuzeProgramma == 1)
					{
						Console.Write("Gekozen Programma: Basic");
						Console.Write("Hoeveel geld werpt u in? ");
						saldo = Convert.ToInt32(Console.ReadLine());
					}
					else
					{
						Console.WriteLine("Gekozen Programma: Deluxe");
						Console.Write("Hoeveel geld werpt u in? ");
						saldo = Convert.ToInt32(Console.ReadLine());
					}
				break;
				case 'b':
				Console.Write("Hoeveel geld werpt u in?: ");
				saldo = Convert.ToInt32(Console.ReadLine());
				if (saldo / 0.50 == 0)
				{
					Console.Write("Druk op enter");
				}
				else
				{
					Console.WriteLine("Fout: Alleen veelvouden van € 0.50 toegelaten");
					Console.Write("");
					Console.Write("Druk op enter");
				}
				break;
				case 'q':
				if (keuze == '1' && saldo >= 10 || keuze == '2' && saldo >= 15)
				{
					Console.WriteLine("--- Afrekening ---");
					Console.WriteLine($"Wasbeurt:  ");
					Console.Write($"{basisProgramma:C2}");
				}
				else 
				{
					Console.WriteLine("Fout: kies eerst een wasprogramma");
				}
				break;
			}
        } while (keuze != 's');
		Console.WriteLine();
		Console.WriteLine($"U krijgt {saldo} terug");
		saldo = 0;
		Console.WriteLine("Bedankt & tot ziens");
	}
}

		
		
			
				
