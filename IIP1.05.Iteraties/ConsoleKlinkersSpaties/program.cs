using System;
namespace ConsoleKlinkerSpaties
{
	class program
	{
	static void Main(string[] args)
	{
		Console.Write("Geef een tekst: ");
		string tekst = Console.ReadLine();

		int aantalKlinkers = 0;
		int aantalSpaties = 0;
		string geheimschrift = "";

	foreach (char letter in tekst)
	{	
		if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
			letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
		{
        aantalKlinkers++;
		}

		if (aantalSpaties == ' ')
		{
			aantalSpaties++;
		}
    
		if (((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z')))
		{
			int ascii = (int)letter;
			ascii = ascii + 1;
			geheimschrift = geheimschrift + (char)ascii;
		}
		else
		{
			geheimschrift = geheimschrift + letter;
		}
	}
	Console.WriteLine($"deze tekst bevat {aantalKlinkers} klinkers en {aantalSpaties} spaties");
	Console.WriteLine($"in geheimschrift: {geheimschrift}");
		}
	}
}
