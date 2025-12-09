/* Dit is een reeks korte oefeningen over berekeningen in C#. 
 * 
 * Doel van de oefeningen, zie https://rogiervdl.github.io/CS-course/02_variabelen.html#rekenkundige-operatoren:
 *  
 * 1. berekeningen 
 * 2. gehele deling
 * 3. verkorte notaties
 * 4. Math klasse
 * 5. DateTime en properties, zie https://rogiervdl.github.io/CS-course/A_dotnet.html#datetime
 * 6. Logische operatoren (dit hoort eigenlijk al bij les 04 - selecties), zie https://rogiervdl.github.io/CS-course/03_selecties.html#operatoren
 *
 * Tips en richtlijnen
 * - gebruik bij uitvoer zoveel mogelijk string interpolatie, dus Console.WriteLine($"Hallo, {naam}"); en niet  Console.WriteLine("Hallo, " + naam);
 * - lees goed de richtlijnen bij elke opgave
 * - controleer bij uitvoeren of je resultaat exact overeenkomt met voorbeelduitvoer.jpg
 * 
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        /* --- Oefening 1: Optellen en delen ---
         * Context: Je moet de gemiddelde score van twee examens berekenen.
         *
         * Opdracht:
         * 1. Declareer twee 'int' variabelen: 'score1' met een waarde van 80 en 'score2' met een waarde van 95.
         * 2. Bereken de som van de twee scores en sla het resultaat op in een 'int' variabele 'totaalScore'.
         * 3. Bereken de gemiddelde score met de '/' operator. Let op het datatype van het resultaat!
         * 4. Print het resultaat af.
         *
         * Testvoorbeeld:
         * Verwachte output: 87.5
         */
        // TODO: implementeer hier
		
		int score1 = 80;
		int score2 = 95;
		double gemiddelde = score1 + score2;
		double totaalScore = gemiddelde / 2;
		Console.WriteLine($" {totaalScore:F2} ");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 2: Modulo en Increment ---
         * Context: Je wilt de rest van een deling weten en daarna een teller verhogen.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'aantalItems' met een waarde van 15.
         * 2. Declareer een 'int' variabele 'itemsPerDoos' met een waarde van 4.
         * 3. Bereken de rest met de modulo operator (%) en sla het resultaat op in een 'int' variabele 'rest'.
         * 4. Verhoog de waarde van 'aantalItems' met 1 met de post-increment operator (aantalItems++).
         * 5. Print zowel de 'rest' als de nieuwe waarde van 'aantalItems' af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * De rest is: 3
         * Het nieuwe aantal is: 16
         */
        // TODO: implementeer hier
		
		int aantalItems = 15;
		int itemsPerDoos = 4;
		int rest = aantalItems % itemsPerDoos;
		aantalItems++;
		Console.WriteLine("De rest is: " + rest); 
		Console.WriteLine("Het nieuwe aantal is: " + aantalItems);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 3: Afronden met Math ---
         * Context: Je berekent het bedrag van een fooi. Het resultaat moet een geheel getal zijn.
         *
         * Opdracht:
         * 1. Declareer een 'double' variabele 'totaalbedrag' met een waarde van 45.75.
         * 2. Bereken 15% van het totaalbedrag.
         * 3. Rond het resultaat naar boven af met `Math.Ceiling()` en sla het op in een 'double' variabele 'fooi'.
         * 4. Print de 'fooi' af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 7
         */
        // TODO: implementeer hier
		
		double totaalbedrag = 45.75;
		double berekening = totaalbedrag / 100 * 15;
		double fooi = Math.Ceiling(berekening);
		Console.WriteLine($"Fooi: {fooi}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 4: Karakter en string concatenatie ---
         * Context: Je genereert een productcode door een letter en een getal te combineren.
         *
         * Opdracht:
         * 1. Declareer een 'char' variabele 'prefix' met de waarde 'P'.
         * 2. Declareer een 'int' variabele 'nummer' met de waarde 123.
         * 3. Combineer de twee variabelen tot een 'string' genaamd 'productCode' met de '+' operator.
         * 4. Print de 'productCode' af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * P123
         */
        // TODO: implementeer hier
		
		char prefix = ('P');
		int nummer = (123);
		string productCode = prefix.ToString() + nummer.ToString();
		
        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 5: Werken met strings ---
         * Context: Je controleert of een gebruikersnaam aan bepaalde eisen voldoet en formatteert deze.
         *
         * Opdracht:
         * 1. Declareer een 'string' variabele 'gebruikersNaam' en geef deze de waarde "  frank". Let op de extra spaties.
         * 2. Gebruik de `Trim()` methode om de spaties te verwijderen.
         * 3. Gebruik de `ToUpper()` methode om de naam om te zetten naar hoofdletters.
         * 4. Print de bewerkte naam af en daaronder het aantal karakters van de getrimde naam met de `Length` property.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * FRANK
         * 5
         */
        // TODO: implementeer hier
		
		string gebruikersNaam = "  Frank";
		string trimUpper = gebruikersNaam.Trim().ToUpper();
		int aantal = gebruikersNaam.Length;
		string Naam = trimUpper;
		Console.WriteLine($"{Naam}");
		Console.WriteLine($"{aantal}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 6: Logische AND-operator ---
         * Context: Je checkt of een student geslaagd is voor een examen. Een voldoende score en aanwezigheid zijn vereist.
         *
         * Opdracht:
         * 1. Declareer een 'bool' variabele 'isVoldoendeScore' en geef deze de waarde `true`.
         * 2. Declareer een 'bool' variabele 'heeftAanwezigheid' en geef deze de waarde `true`.
         * 3. Combineer deze twee variabelen met de logische operator `&&` om te bepalen of de student is geslaagd. Sla het resultaat op in een 'bool' variabele 'geslaagd'.
         * 4. Print de waarde van 'geslaagd' af.
         *
         * Testvoorbeeld:
         * Verwachte output: True
         */
        // TODO: implementeer hier
		
		bool isVoldoendeScore = true;
		bool heeftAanwezigheid = true;
		bool true1 = isVoldoendeScore && heeftAanwezigheid;
		Console.WriteLine(true1);

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 7: Typeconversie (string naar int) ---
         * Context: Je vraagt een getal van de gebruiker en zet het om naar een integer.
         *
         * Opdracht:
         * 1. Vraag de gebruiker om een getal in te voeren en sla de invoer op in een 'string' variabele 'invoerTekst'.
         * 2. Converteer 'invoerTekst' naar een 'int' met `Convert.ToInt32()` en sla het op in een 'int' variabele 'invoerGetal'.
         * 3. Print het ingevoerde getal op het scherm.
         *
         * Testvoorbeeld:
         * Input: 42
         * Verwachte output:
         * Het ingevoerde getal is: 42
         */
        // TODO: implementeer hier
		
		Console.Write("Voer een getal in: ");
		string invoerTekst = Console.ReadLine();
		int invoerGetal = Convert.ToInt32(invoerTekst);
		Console.WriteLine($"Het ingevoerde getal is {invoerGetal}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 8: Decimale conversie en ToString() ---
         * Context: Je hebt een prijs en wilt deze op een specifieke manier weergeven, afgerond op 2 cijfers.
         *
         * Opdracht:
         * 1. Declareer een 'double' variabele 'prijs' en geef deze een waarde van 9.995.
         * 2. Converteer de `prijs` naar een 'string' met `ToString("F2")` om de prijs af te ronden tot 2 cijfers na de komma.
         * 3. Sla het resultaat op in een 'string' variabele 'geformatteerdePrijs'.
         * 4. Print 'geformatteerdePrijs' af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 10.00
         */
        // TODO: implementeer hier
		
		double prijs = 9.995;
		string geformatteerdePrijs = prijs.ToString("F2");
		Console.WriteLine($"{geformatteerdePrijs}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 9: DateTime en Properties ---
         * Context: Je wilt de huidige datum en tijd weergeven.
         *
         * Opdracht:
         * 1. Declareer een 'DateTime' variabele 'huidigeDatum' en geef deze de huidige datum en tijd via `DateTime.Now`.
         * 2. Gebruik de `.Day` en `.Month` properties om de dag en maand af te drukken.
         *
         * Testvoorbeeld:
         * Als het vandaag 25 september is:
         * Verwachte output:
         * Vandaag is dag 25 in maand 9
         */
        // TODO: implementeer hier
		
		DateTime huidigeDatum = DateTime.Now;
		Console.WriteLine($"Vadaag is dag {huidigeDatum.Day} in maand {huidigeDatum.Month}");

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 10: Berekenen met DateTime ---
         * Context: Je wilt een evenement plannen dat 14 dagen in de toekomst ligt.
         *
         * Opdracht:
         * 1. Declareer een 'DateTime' variabele 'vandaag' en geef deze de huidige datum via `DateTime.Today`.
         * 2. Gebruik de `AddDays()` methode om 14 dagen toe te voegen aan 'vandaag' en sla het resultaat op in een 'DateTime' variabele 'toekomstDatum'.
         * 3. Print de 'toekomstDatum' af.
         *
         * Testvoorbeeld:
         * Als het vandaag 25 september 2024 is:
         * Verwachte output:
         * 09/10/2024 0:00:00
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 11: Delen van gehele getallen ---
         * Context: Je verdeelt 10 appels over 3 studenten. Je wilt weten hoeveel appels elke student krijgt (geen stukjes).
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'totaalAppels' met de waarde 10.
         * 2. Declareer een 'int' variabele 'aantalStudenten' met de waarde 3.
         * 3. Deel de appels door het aantal studenten. Sla de uitkomst op in een 'int' variabele 'appelsPerStudent'.
         * 4. Print het resultaat af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 3
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 12: Verkorte toewijzing ---
         * Context: Je wilt de score van een student verhogen met 10 punten.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'score' met de waarde 85.
         * 2. Verhoog de score met 10 punten met behulp van de verkorte toewijzingsoperator `+=`.
         * 3. Print de nieuwe score af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 95
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 13: Logische NOT-operator ---
         * Context: Je wilt de tegenovergestelde waarde van een booleanvariabele bepalen.
         *
         * Opdracht:
         * 1. Declareer een 'bool' variabele 'isActief' en geef deze de waarde `true`.
         * 2. Gebruik de logische operator `!` om de waarde van 'isActief' om te keren. Sla het resultaat op in een 'bool' variabele 'isInactief'.
         * 3. Print 'isInactief' af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * False
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 14: Logische OR-operator ---
         * Context: Een gebruiker kan inloggen als het wachtwoord of het e-mailadres juist is.
         *
         * Opdracht:
         * 1. Declareer een 'bool' variabele 'isWachtwoordCorrect' met de waarde `false`.
         * 2. Declareer een 'bool' variabele 'isEmailCorrect' met de waarde `true`.
         * 3. Combineer deze twee variabelen met de logische operator `||` om te bepalen of inloggen mogelijk is. Sla het resultaat op in een 'bool' variabele 'inloggenMogelijk'.
         * 4. Print 'inloggenMogelijk' af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * True
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 15: String vergelijking ---
         * Context: Je checkt of een ingevoerde gebruikersnaam overeenkomt met een vaste naam.
         *
         * Opdracht:
         * 1. Declareer een 'const string' 'AdminNaam' met de waarde "admin".
         * 2. Vraag de gebruiker om hun naam en sla de invoer op in een 'string' variabele 'ingevoerdeNaam'.
         * 3. Vergelijk de twee strings en sla het resultaat op in een 'bool' variabele 'isGelijk'.
         * 4. Print de waarde van 'isGelijk' af.
         *
         * Testvoorbeeld:
         * Input: admin
         * Verwachte output:
         * True
         *
         * Input: Admin
         * Verwachte output:
         * False
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 16: Typeconversie (string naar char) ---
         * Context: Je wilt de eerste letter van een naam extraheren.
         *
         * Opdracht:
         * 1. Vraag de gebruiker om hun naam en sla deze op in een 'string' variabele 'naam'.
         * 2. Converteer de `naam` naar een `char` met `char.Parse()` en sla het op in een 'char' variabele 'eersteLetter'.
         * 3. Print 'eersteLetter' af.
         *
         * Testvoorbeeld:
         * Input: Karel
         * Verwachte output:
         * K
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 17: String met speciale tekens ---
         * Context: Je print een pad naar een bestand af.
         *
         * Opdracht:
         * 1. Declareer een 'string' variabele 'pad' met de waarde "C:\Users\documents\file.txt" met behulp van escape characters.
         * 2. Print het pad af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * C:\Users\documents\file.txt
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 18: Gebruik van Math.Round ---
         * Context: Je berekent de prijs inclusief btw, en rondt het resultaat af op twee decimalen.
         *
         * Opdracht:
         * 1. Declareer een 'double' variabele 'prijsExclBtw' met de waarde 24.99.
         * 2. Declareer een 'double' variabele 'btwTarief' met de waarde 0.21.
         * 3. Bereken de prijs inclusief btw.
         * 4. Rond het resultaat af tot twee decimalen met `Math.Round()` en sla het op in een 'double' variabele 'prijsInclBtw'.
         * 5. Print de 'prijsInclBtw' af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 30.24
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 19: String eigenschappen en methoden ---
         * Context: Je wilt de lengte van een wachtwoord bepalen en de eerste letter controleren.
         *
         * Opdracht:
         * 1. Vraag de gebruiker om een wachtwoord in te voeren en sla de invoer op in een 'string' variabele 'wachtwoord'.
         * 2. Print de lengte van het wachtwoord af met de `.Length` property.
         * 3. Print het eerste karakter van het wachtwoord af. Je kunt dit doen door de string te behandelen als een array (bv. `wachtwoord[0]`).
         *
         * Testvoorbeeld:
         * Input: Wachtwoord123
         * Verwachte output:
         * Lengte: 11
         * Eerste karakter: W
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 20: Complexere booleanse uitdrukking ---
         * Context: Een student moet slagen voor twee toetsen, óf een voldoende score halen voor één toets en een voldoende voor het project.
         *
         * Opdracht:
         * 1. Declareer 'bool' variabelen: 'toets1Geslaagd', 'toets2Geslaagd', en 'projectGeslaagd'. Geef ze zelf waarden.
         * 2. Schrijf een complexe logische uitdrukking met `&&` en `||` die bepaalt of de student is geslaagd.
         * 3. Sla het resultaat op in een 'bool' variabele 'geslaagdVoorSemester' en print deze af.
         *
         * Testvoorbeeld:
         * Input: toets1Geslaagd=true, toets2Geslaagd=true, projectGeslaagd=false
         * Verwachte output:
         * True
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 21: Datum weergeven in een specifiek formaat ---
         * Context: Je wilt de huidige datum weergeven in een leesbaar formaat voor een uitnodiging.
         *
         * Opdracht:
         * 1. Declareer een 'DateTime' variabele 'nu' met `DateTime.Now`.
         * 2. Converteer 'nu' naar een string in het formaat "dd MMMM yyyy" met de `ToString()` methode.
         * 3. Sla het resultaat op in een 'string' variabele 'geformatteerdeDatum' en print deze af.
         *
         * Testvoorbeeld:
         * Als het 25 september 2024 is:
         * Verwachte output: 25 september 2024
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 22: Berekening van leeftijd ---
         * Context: Je hebt de geboortedatum van een persoon en wilt hun leeftijd bepalen in jaren.
         *
         * Opdracht:
         * 1. Declareer een 'DateTime' variabele 'geboorteDatum' met de waarde van een willekeurige datum (bijv. 1990, 5, 15).
         * 2. Bereken het verschil tussen `DateTime.Today` en 'geboorteDatum' in dagen.
         * 3. Converteer het aantal dagen naar het aantal jaren.
         * 4. Sla de leeftijd op in een 'int' variabele 'leeftijd' en print deze af.
         *
         * Testvoorbeeld:
         * Geboortedatum: 15/05/1990
         * Verwachte output (voor 25/09/2024):
         * Leeftijd: 34
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 23: Gebruik van Math.PI ---
         * Context: Je moet de omtrek van een cirkel berekenen.
         *
         * Opdracht:
         * 1. Declareer een 'double' variabele 'straal' met de waarde 7.
         * 2. Gebruik `Math.PI` en de `*` operator om de omtrek te berekenen (Formule: 2 * straal * PI).
         * 3. Sla het resultaat op in een 'double' variabele 'omtrek' en print deze af.
         *
         * Testvoorbeeld:
         * Verwachte output: 43.98...
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 24: `char` naar `int` conversie ---
         * Context: Je hebt de ASCII-code van een karakter nodig.
         *
         * Opdracht:
         * 1. Declareer een 'char' variabele 'hoofdletter' met de waarde 'A'.
         * 2. Converteer het karakter naar zijn integerwaarde met `Convert.ToInt32()` en sla het op in een 'int' variabele 'asciiWaarde'.
         * 3. Print 'asciiWaarde' af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 65
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 25: `int` naar `char` conversie ---
         * Context: Je wilt een karakter weergeven op basis van de ASCII-waarde.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'getal' met de waarde 66.
         * 2. Converteer het getal naar een 'char' met `Convert.ToChar()` en sla het op in een 'char' variabele 'karakter'.
         * 3. Print 'karakter' af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * B
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 26: String naar int en optellen ---
         * Context: Je vraagt twee getallen aan de gebruiker en telt ze bij elkaar op.
         *
         * Opdracht:
         * 1. Vraag de gebruiker om het eerste getal en sla de invoer op in een 'string'.
         * 2. Vraag de gebruiker om het tweede getal en sla de invoer op in een 'string'.
         * 3. Converteer beide strings naar 'int' met `int.Parse()` en sla ze op in 'int' variabelen.
         * 4. Tel de twee 'int' variabelen bij elkaar op en print het resultaat af.
         *
         * Testvoorbeeld:
         * Input 1: 5
         * Input 2: 10
         * Verwachte output:
         * 15
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 27: Booleaanse waarden van strings ---
         * Context: Je leest de antwoorden van een enquête in.
         *
         * Opdracht:
         * 1. Vraag de gebruiker "Ben je tevreden? (true/false)" en sla de invoer op in een 'string'.
         * 2. Converteer de string naar een 'bool' met `bool.Parse()`.
         * 3. Sla het resultaat op in een 'bool' variabele 'isTevreden' en print deze af.
         *
         * Testvoorbeeld:
         * Input: true
         * Verwachte output:
         * True
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 28: Complexere string manipulatie ---
         * Context: Je genereert een gebruikersnaam op basis van voor- en achternaam, en checkt de geldigheid.
         *
         * Opdracht:
         * 1. Vraag de gebruiker om hun voornaam en achternaam.
         * 2. Sla de invoer op in 'string' variabelen.
         * 3. Combineer ze tot een gebruikersnaam in de vorm "voornaam.achternaam" (alles kleine letters).
         * 4. Check of de gegenereerde gebruikersnaam een '.' bevat met de `Contains()` methode.
         * 5. Print de gebruikersnaam en het resultaat van de check af.
         *
         * Testvoorbeeld:
         * Input: Jan, Janssen
         * Verwachte output:
         * gebruikersnaam: jan.janssen
         * Geldig: True
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 29: Typeconversie (`ToString`) ---
         * Context: Je hebt een getal en een boolean en wilt deze weergeven als tekst.
         *
         * Opdracht:
         * 1. Declareer een 'int' variabele 'aantal' met de waarde 10.
         * 2. Declareer een 'bool' variabele 'isKlaar' met de waarde `true`.
         * 3. Converteer beide variabelen naar een 'string' met de `ToString()` methode.
         * 4. Print de geconverteerde strings af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * Het aantal is: 10
         * De status is: True
         */
        // TODO: implementeer hier

        Console.WriteLine("\n---------------------\n");

        /* --- Oefening 30: `DateTime` operaties ---
         * Context: Je wilt de datum van een evenement dat over een maand plaatsvindt, weergeven.
         *
         * Opdracht:
         * 1. Declareer een 'DateTime' variabele 'vandaag' met `DateTime.Today`.
         * 2. Gebruik de `AddMonths()` methode om één maand toe te voegen.
         * 3. Sla het resultaat op in een 'DateTime' variabele 'volgendeMaand'.
         * 4. Print de 'volgendeMaand' af in het formaat "dd/MM/yyyy".
         *
         * Testvoorbeeld:
         * Als het vandaag 25 september 2024 is:
         * Verwachte output:
         * 25/10/2024
         */
        // TODO: implementeer hier
    }
}
