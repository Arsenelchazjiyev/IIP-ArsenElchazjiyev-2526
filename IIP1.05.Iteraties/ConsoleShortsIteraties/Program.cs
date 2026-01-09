/* --- Tips & Stijlregels ---
 * Welkom! Hieronder vind je een reeks oefeningen over iteraties.
 * De oefeningen zijn gebaseerd op de lessen over de 'while', 'do-while', 'for' en 'foreach' lussen.
 *
 * Let op de volgende regels wanneer je aan de slag gaat:
 *
 * 1. Variabelenamen: gebruik de camelCase-conventie.
 * 2. Constantenamen: gebruik de PascalCase-conventie.
 * 3. Gebruik altijd accolades {} bij je lus-blokken.
 * 4. Declareer variabelen die de lus beïnvloeden buiten de lus zelf.
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        /* --- Oefening 1: Eenvoudige FOR-lus ---
         * Context: Je wilt de getallen van 1 tot 5 afdrukken.
         *
         * Opdracht:
         * 1. Gebruik een `for`-lus om te tellen van 1 tot en met 5.
         * 2. Druk binnen de lus elk getal af op een nieuwe regel.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 1
         * 2
         * 3
         * 4
         * 5
         */

        Console.WriteLine("Oefening 1: Eenvoudige FOR-lus");
		Console.WriteLine("---------------------------");
		// start van jouw code
		
		for (int i = 1; i <= 5; i++)
		{
			Console.WriteLine(i);
		}

		// einde van jouw code
		Console.WriteLine("---------------------------");

        /* --- Oefening 2: FOR-lus met stappen ---
         * Context: Je wilt alleen de even getallen van 2 tot 10 afdrukken.
         *
         * Opdracht:
         * 1. Gebruik een `for`-lus om van 2 tot en met 10 te tellen.
         * 2. Zorg ervoor dat de teller telkens met 2 wordt verhoogd.
         * 3. Druk elk getal af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 2
         * 4
         * 6
         * 8
         * 10
         */

        Console.WriteLine("Oefening 2: FOR-lus met stappen");
		Console.WriteLine("---------------------------");
		// start van jouw code
		
		for (int i = 2; i <= 11; i+=2)
		{
			Console.WriteLine(i);
		}

		// einde van jouw code
		Console.WriteLine("---------------------------");
		
		

        /* --- Oefening 3: FOR-lus achterwaarts ---
         * Context: Je telt af voor een raketlancering.
         *
         * Opdracht:
         * 1. Gebruik een `for`-lus om van 10 naar 1 af te tellen.
         * 2. Druk elk getal af op een nieuwe regel.
         * 3. Print na de lus "Lancering!".
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 10
         * 9
         * ...
         * 1
         * Lancering!
         */
		
        Console.WriteLine("Oefening 3: FOR-lus achterwaarts");
		Console.WriteLine("---------------------------");
		// start van jouw code
		
		for (int i = 10; i >= 1; i--)
		{
			Console.WriteLine(i);
		}

		// einde van jouw code
		Console.WriteLine("---------------------------");

        /* --- Oefening 4: WHILE-lus met een teller ---
         * Context: Je wilt de getallen van 1 tot 3 afdrukken met een `while`-lus.
         *
         * Opdracht:
         * 1. Declareer een `int` variabele `teller` en initialiseer deze met 1.
         * 2. Gebruik een `while`-lus die doorgaat zolang `teller` kleiner is dan of gelijk is aan 3.
         * 3. Druk de `teller` af binnen de lus en verhoog de waarde in elke iteratie.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 1
         * 2
         * 3
         */

        Console.WriteLine("Oefening 4: WHILE-lus met een teller");
		Console.WriteLine("---------------------------");
		// start van jouw code
		
		int teller = 1;
		while (teller < 4)
		{
			Console.WriteLine(teller++);
		}

		// einde van jouw code
		Console.WriteLine("---------------------------");
		
		

        /* --- Oefening 5: DO-WHILE voor gebruikersinvoer ---
         * Context: Je wilt een menu tonen en de gebruiker vragen om een geldige optie in te voeren.
         *
         * Opdracht:
         * 1. Gebruik een `do-while`-lus.
         * 2. Vraag de gebruiker binnen de lus om "j" of "n" in te voeren.
         * 3. De lus moet doorgaan zolang de invoer niet "j" of "n" is.
         * 4. Sla de invoer op in een `string` variabele.
         *
         * Testvoorbeeld:
         * Input:
         * k (herhaal)
         * p (herhaal)
         * j (stop)
         *
         * Verwachte output:
         * Voer 'j' of 'n' in: k
         * Voer 'j' of 'n' in: p
         * Voer 'j' of 'n' in: j
         */
        
        Console.WriteLine("Oefening 5: DO-WHILE voor gebruikersinvoer");
		Console.WriteLine("---------------------------");
		// start van jouw code
		
		

		// einde van jouw code
		Console.WriteLine("---------------------------");

        /* --- Oefening 6: FOREACH-lus over een string ---
         * Context: Je wilt elk karakter van een gegeven string afdrukken.
         *
         * Opdracht:
         * 1. Declareer een `string` variabele `woord` met de waarde "hello".
         * 2. Gebruik een `foreach`-lus om over elk `char` in de string te itereren.
         * 3. Druk elk karakter af op een nieuwe regel.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * h
         * e
         * l
         * l
         * o
         */


        Console.WriteLine("Oefening 6: FOREACH-lus over een string");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");




        /* --- Oefening 7: FOREACH en telling van karakters ---
         * Context: Je wilt tellen hoe vaak de letter 'a' in een zin voorkomt.
         *
         * Opdracht:
         * 1. Declareer een `string` variabele 'zin' met de waarde "Ik hou van programmeren in C#".
         * 2. Declareer een `int` variabele `aantalA` en initialiseer deze met 0.
         * 3. Gebruik een `foreach`-lus om over elk karakter te itereren.
         * 4. Gebruik een `if`-statement om te controleren of het karakter gelijk is aan 'a' (kleine letter).
         * 5. Als de voorwaarde waar is, verhoog dan `aantalA` met 1.
         * 6. Print het totale aantal af na de lus.
         *
         * Testvoorbeeld:
         * Verwachte output: Het aantal 'a's is 3.
         */

        Console.WriteLine("Oefening 7: FOREACH en telling van karakters");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");



        /* --- Oefening 8: WHILE-lus en conversie ---
         * Context: Je wilt een programma maken dat het kwadraat van een ingevoerd getal afdrukt totdat de gebruiker 0 invoert.
         *
         * Opdracht:
         * 1. Declareer een `int` variabele 'getal' buiten de lus en geef het een startwaarde die niet 0 is (bijv. 1).
         * 2. Gebruik een `while`-lus die doorgaat zolang 'getal' niet gelijk is aan 0.
         * 3. Vraag binnen de lus om een getal in te voeren en converteer de invoer met `Convert.ToInt32()`.
         * 4. Sla de geconverteerde waarde op in 'getal'.
         * 5. Druk het kwadraat van het getal af.
         *
         * Testvoorbeeld:
         * Input:
         * 2
         * 5
         * 0
         * Verwachte output:
         * Het kwadraat is 4
         * Het kwadraat is 25
         * (programma stopt)
         */

        Console.WriteLine("Oefening 8: WHILE-lus en conversie");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");
		
		

        /* --- Oefening 9: FOR-lus voor vermenigvuldigingstabel ---
         * Context: Je wilt de tafel van 7 afdrukken (van 1 tot 10).
         *
         * Opdracht:
         * 1. Declareer een `const int` `TafelVan` met de waarde 7.
         * 2. Gebruik een `for`-lus om van 1 tot en met 10 te tellen.
         * 3. Bereken binnen de lus het product en druk de hele berekening af, bijvoorbeeld: "7 * 1 = 7".
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 7 * 1 = 7
         * 7 * 2 = 14
         * ...
         * 7 * 10 = 70
         */

        Console.WriteLine("Oefening 9: FOR-lus voor vermenigvuldigingstabel");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");
		
		

        /* --- Oefening 10: DO-WHILE voor wachtwoord ---
         * Context: Een gebruiker moet het juiste wachtwoord invoeren om toegang te krijgen.
         *
         * Opdracht:
         * 1. Declareer een `const string` `GeheimWachtwoord` met de waarde "geheim".
         * 2. Declareer een `string` variabele `invoer` buiten de lus.
         * 3. Gebruik een `do-while`-lus. Vraag de gebruiker binnen de lus om het wachtwoord in te voeren.
         * 4. De lus moet doorgaan zolang de ingevoerde waarde niet gelijk is aan het geheime wachtwoord.
         * 5. Druk na de lus een welkomstboodschap af.
         *
         * Testvoorbeeld:
         * Input:
         * fout
         * 123
         * geheim
         *
         * Verwachte output:
         * Voer wachtwoord in: fout
         * Voer wachtwoord in: 123
         * Voer wachtwoord in: geheim
         * Toegang verleend!
         */

        Console.WriteLine("Oefening 10: DO-WHILE voor wachtwoord");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");
		

        /* --- Oefening 11: FOR-lus met sommatie ---
         * Context: Je wilt de som van alle getallen van 1 tot 5 berekenen.
         *
         * Opdracht:
         * 1. Declareer een `int` variabele `totaal` en initialiseer deze met 0.
         * 2. Gebruik een `for`-lus om van 1 tot en met 5 te tellen.
         * 3. Tel binnen de lus het huidige getal bij `totaal` op.
         * 4. Druk de uiteindelijke waarde van `totaal` af na de lus.
         *
         * Testvoorbeeld:
         * Verwachte output: De som is 15.
         */

        Console.WriteLine("Oefening 11: FOR-lus met sommatie");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");


        /* --- Oefening 12: Geneste lussen (FOR) ---
         * Context: Je wilt een simpele rechthoek van sterren (asterisks) afdrukken.
         *
         * Opdracht:
         * 1. Gebruik een buitenste `for`-lus om 3 rijen af te drukken.
         * 2. Gebruik een geneste `for`-lus om 5 sterren per rij af te drukken.
         * 3. Gebruik `Console.Write("*")` voor de sterren en `Console.WriteLine()` om naar een nieuwe regel te gaan na elke rij.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * *****
         * *****
         * *****
         */

        Console.WriteLine("Oefening 12: Geneste lussen (FOR)");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");




        /* --- Oefening 13: FOR-lus met IF-statement ---
         * Context: Je wilt de oneven getallen van 1 tot 10 afdrukken.
         *
         * Opdracht:
         * 1. Gebruik een `for`-lus om van 1 tot en met 10 te tellen.
         * 2. Gebruik een `if`-statement en de modulo-operator (`%`) om te controleren of het getal oneven is.
         * 3. Druk alleen de oneven getallen af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 1
         * 3
         * 5
         * 7
         * 9
         */

        Console.WriteLine("Oefening 13: FOR-lus met IF-statement");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");


        /* --- Oefening 14: FOREACH en string-methodes ---
         * Context: Je wilt tellen hoeveel woorden in een zin een 'e' bevatten.
         *
         * Opdracht:
         * 1. Declareer een `string` variabele `zin` met de waarde "Een wereld van woorden".
         * 2. Gebruik `zin.Split(' ')` om de zin op te splitsen in woorden.
         * 3. Gebruik een `foreach`-lus over de woorden.
         * 4. Gebruik een `if`-statement en de `Contains()`-methode om te controleren of een woord een 'e' bevat.
         * 5. Druk het aantal woorden af dat een 'e' bevat.
         *
         * Testvoorbeeld:
         * Verwachte output: Er zijn 3 woorden met een 'e'.
         */

        Console.WriteLine("Oefening 14: FOREACH en string-methodes");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");
		
		

        /* --- Oefening 15: FOR-lus voor een piramide ---
         * Context: Je wilt een halve piramide van sterren afdrukken.
         *
         * Opdracht:
         * 1. Gebruik een buitenste `for`-lus om te tellen van 1 tot en met 5 (voor de rijen).
         * 2. Gebruik een geneste `for`-lus om het aantal sterren in elke rij te bepalen (gelijk aan het nummer van de rij).
         * 3. Gebruik `Console.Write("*")` voor de sterren en `Console.WriteLine()` om naar een nieuwe regel te gaan.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * *
         * **
         * ***
         * ****
         * *****
         */

        Console.WriteLine("Oefening 15: FOR-lus voor een piramide");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");
		
		

        /* --- Oefening 16: DO-WHILE en conversie ---
         * Context: Je vraagt om een getal totdat een negatief getal wordt ingevoerd.
         *
         * Opdracht:
         * 1. Declareer een `int` variabele `getal` buiten de lus.
         * 2. Gebruik een `do-while`-lus.
         * 3. Vraag binnen de lus de gebruiker om een getal in te voeren en converteer het naar een `int` met `Convert.ToInt32()`.
         * 4. De lus moet doorgaan zolang 'getal' niet negatief is.
         *
         * Testvoorbeeld:
         * Input:
         * 5
         * 10
         * -1
         * Verwachte output:
         * Voer een getal in: 5
         * Voer een getal in: 10
         * Voer een getal in: -1
         */

        Console.WriteLine("Oefening 16: DO-WHILE en conversie");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");
		

        /* --- Oefening 17: WHILE-lus met `bool` vlag ---
         * Context: Een spel duurt zolang een speler niet de vlag heeft om te stoppen.
         *
         * Opdracht:
         * 1. Declareer een `bool` variabele 'isGestopt' en initialiseer deze met `false`.
         * 2. Gebruik een `while`-lus die doorgaat zolang 'isGestopt' `false` is.
         * 3. Vraag binnen de lus om invoer en verander 'isGestopt' naar `true` als de gebruiker "stop" typt.
         *
         * Testvoorbeeld:
         * Input:
         * Doorgaan
         * stop
         * Verwachte output:
         * Typ "stop" om te stoppen: Doorgaan
         * Typ "stop" om te stoppen: stop
         */

        Console.WriteLine("Oefening 17: WHILE-lus met `bool` vlag");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");
		

        /* --- Oefening 18: FOR-lus voor aftellen met voorwaarde ---
         * Context: Je wilt aftellen, maar de telling stoppen als je een getal onder 5 bereikt.
         *
         * Opdracht:
         * 1. Gebruik een `for`-lus om van 10 naar 1 af te tellen.
         * 2. Gebruik een `if`-statement binnen de lus om te controleren of het huidige getal kleiner is dan 5.
         * 3. Als dat het geval is, print dan "Einde van aftelling." en gebruik `break` om de lus te beëindigen.
         * 4. Anders, druk het getal af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 10
         * 9
         * 8
         * 7
         * 6
         * 5
         * Einde van aftelling.
         */

        Console.WriteLine("Oefening 18: FOR-lus voor aftellen met voorwaarde");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");

        /* --- Oefening 19: FOREACH met een `char` array ---
         * Context: Je telt het aantal hoofdletters in een zin.
         *
         * Opdracht:
         * 1. Declareer een `string` variabele 'zin' met de waarde "Hallo Wereld".
         * 2. Converteer de string naar een `char`-array met `zin.ToCharArray()`.
         * 3. Gebruik een `foreach`-lus over de array.
         * 4. Gebruik een `if`-statement om te controleren of het karakter een hoofdletter is (tussen 'A' en 'Z').
         * 5. Druk het aantal hoofdletters af.
         *
         * Testvoorbeeld:
         * Verwachte output: Het aantal hoofdletters is 2.
         */

        Console.WriteLine("Oefening 19: FOREACH met een `char` array");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");



        /* --- Oefening 20: FOR-lus met `continue` ---
         * Context: Je print de getallen van 1 tot 10, maar slaat de 5 over.
         *
         * Opdracht:
         * 1. Gebruik een `for`-lus van 1 tot 10.
         * 2. Gebruik een `if`-statement om te controleren of het huidige getal 5 is.
         * 3. Als dat het geval is, gebruik dan `continue` om naar de volgende iteratie te springen.
         * 4. Druk anders het getal af.
         *
         * Testvoorbeeld:
         * Verwachte output:
         * 1
         * 2
         * 3
         * 4
         * 6
         * 7
         * 8
         * 9
         * 10
         */

        Console.WriteLine("Oefening 20: FOR-lus met `continue`");
		Console.WriteLine("---------------------------");
		// start van jouw code


		// einde van jouw code
		Console.WriteLine("---------------------------");


    }
}
