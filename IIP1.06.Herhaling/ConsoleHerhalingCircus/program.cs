using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int totaalVolwassenen = 0;
        int totaalKinderen = 0;
        char keuze;
		const decimal PRIJS_VOLWASSENE = 19.90m;
		const decimal PRIJS_KIND = 12.50m;
        do
        {
            Console.Clear();
            Console.WriteLine("Welkom bij de ticketshop voor \"Circus Stromboli\"");
            Console.WriteLine();
            Console.WriteLine("(a) Tickets toevoegen");
            Console.WriteLine("(b) Winkelmandje tonen");
            Console.WriteLine("(c) Winkelmandje wissen");
            Console.WriteLine("(q) Bestelling afronden");
            Console.WriteLine();
            Console.Write("Je keuze: ");

            keuze = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (char.ToLower(keuze))
            {
                case 'a':
                    Console.Write("Volwassenen: ");
                    int vol = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kinderen: ");
                    int kin = Convert.ToInt32(Console.ReadLine());

                    totaalVolwassenen += vol;
                    totaalKinderen += kin;

                    Console.WriteLine(
                        $"Er zijn tickets voor {vol} volwassenen en {kin} kinderen toegevoegd aan je winkelmandje.");
                    break;

                case 'b':
                    if (totaalVolwassenen == 0 && totaalKinderen == 0)
                    {
                        Console.WriteLine("Je winkelmandje is leeg.");
                    }
                    else
                    {
                        Console.WriteLine($"Volwassenen: {totaalVolwassenen}");
                        Console.WriteLine($"Kinderen: {totaalKinderen}");
                    }
                    break;

                case 'c':
                    totaalVolwassenen = 0;
                    totaalKinderen = 0;
                    Console.WriteLine("Winkelmandje is gewist.");
                    break;

                case 'q':
                    decimal totaalPrijs = totaalVolwassenen * PRIJS_VOLWASSENE + totaalKinderen * PRIJS_KIND;

                    Console.WriteLine($"Totaalprijs: € {totaalPrijs.ToString("0.00")}");

                    Console.Write("Ben je jarig vandaag (j/n)? ");
                    char antwoord = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    bool jarig = (char.ToLower(antwoord) == 'j');
                    decimal kortingPercentage = 0m;

                    if (jarig)
                    {
                        kortingPercentage = 0.10m;
                        Console.WriteLine("Gefeliciteerd! Je krijgt 10% korting op je totaalprijs.");
                    }

                    decimal teBetalen = totaalPrijs * (1 - kortingPercentage);
                    Console.WriteLine($"Te betalen bedrag: € {teBetalen.ToString("0.00")}");

                    int bonuspunten = (int)(teBetalen / 10);
                    Console.WriteLine();
                    Console.WriteLine($"Je hebt {bonuspunten} bonuspunten verzameld.");
                    Console.WriteLine("Tot ziens!");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Onbekende keuze.");
                    break;
            }

            if (char.ToLower(keuze) != 'q')
            {
                Console.WriteLine();
                Console.Write("...druk een toets om verder te gaan.");
                Console.ReadKey();
            }

        } while (char.ToLower(keuze) != 'q');
    }
}
