using System;
using System.Text;

/* Welkom! 
 * Hieronder vind je een reeks basisoefeningen over de principes van C#.
 * Gebruik bij uitvoer overal string interpolatie, dus Console.WriteLine($"Hallo, {naam}"); en niet  Console.WriteLine("Hallo, " + naam);
 */

namespace ConsoleShorts01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DEEL A: uitvoer

            /* --- Oefening A.1: één tekstregel afdrukken --- 
             * 
             * Context: Je wilt een eenvoudige boodschap afdrukken.
             *
             * Opdracht:
             * 1. Gebruik `Console.WriteLine()` om "Welkom in de wereld van C#!" af te drukken.
             *
             * Verwachte uitvoer:
             * Welkom in de wereld van C#!
             */
            Console.WriteLine("\n\nOefening A.1: één tekstregel afdrukken\n------------\n");
            // TODO: implementeer hier.
            Console.Write("Dit is één tekstregel.");

            /* --- Oefening A.2: meerdere tekstregels afdrukken ---
             * Context: Je wilt de regels van een gedicht afdrukken, elke regel op een nieuwe lijn.
             *
             * Opdracht:
             * Gebruik meerdere `Console.WriteLine()` statements om het volgende gedicht af te drukken:
             * Fouten zijn rood,
             * Variabelen zijn blauw,
             * Ik werk aan de code,
             * Waar ik zo van hou.
             *
             * Verwachte uitvoer:
             * Fouten zijn rood,
             * Variabelen zijn blauw,
             * Ik werk aan de code,
             * Waar ik zo van hou.
             */
            Console.WriteLine("\n\nOefening A.2: meerdere tekstregels afdrukken\n------------\n");
            // TODO: implementeer hier.
            Console.WriteLine("Fouten zijn rood,");
			Console.WriteLine("Variabelen zijn blauw,");
			Console.WriteLine("Ik werk aan de code");
			Console.WriteLine("Waar ik zo van hou");
			

            /* --- Oefening A.3: multiline string ---
             * Context: Je wil een tekst van meerdere regels afdrukken in één regel.
             *
             * Opdracht:
             * 1. Gebruik `@""` om volgende tekst af te drukken in één regel:
             *      ___   
             *     (o o)  
             *    (  V  ) 
             * -----m-m----
             *
             * Verwachte uitvoer:
             *      ___   
             *     (o o)  
             *    (  V  ) 
             * -----m-m----
             */
            Console.WriteLine("\n\nOefening A.3: multiline string\n------------\n");
            // TODO: implementeer hier.
			Console.Write(@"___   
                  (o o)  
                 (  V  ) 
              -----m-m----");

            #endregion

            #region DEEL B: tekstinvoer

            /* --- Oefening B.1: tekst inlezen en afdrukken ---
             * 
             * Context: Vraag de gebruiker om hun naam en druk een welkomstboodschap af.
             *
             * Opdracht:
             * 1. Gebruik `Console.Write()` om de tekst "Voer je naam in: " af te drukken.
             * 2. Lees de invoer van de gebruiker in met `Console.ReadLine()` en sla deze op in een `string` variabele `invoerNaam`.
             * 3. Druk een welkomstboodschap af, bijv. "Hallo, Reda!".
             *
             * Invoer: Reda
             * Verwachte uitvoer:
             * Voer je naam in: Reda
             * Hallo, Reda!
             */
            Console.WriteLine("\n\nOefening B.1: tekst inlezen en afdrukken\n------------\n");
            // TODO: implementeer hier.
			Console.Write("Wat is je naam? ");
			string naam = Console.ReadLine();
			Console.Write($"Hallo, {naam} ");

            /* --- Oefening B.2: tekst inlezen en meermaals afdrukken ---
             * 
             * Context: Vraag de gebruiker om een tekst en druk het meermaals af.
             *
             * Opdracht:
             * 1. Druk de tekst "Welkom in de echoput" af
             * 1. Gebruik `Console.Write()` om de tekst "Zeg iets: " af te drukken.
             * 2. Lees de invoer van de gebruiker in met `Console.ReadLine()` en sla deze op in een `string` variabele `invoerTekst`.
             * 3. Druk de tekst drie keer naast elkaar af".
             *
             * Invoer: dag leo!
             * Verwachte uitvoer:
             * Zeg iets: dag leo!
             * dag leo! dag leo! dag leo!
             */
            Console.WriteLine("Welkom in de echoput");
			Console.Write("zeg iets: ");
			string echo = Console.ReadLine();
			Console.WriteLine($" {echo} {echo} {echo}");
            
            #endregion

            #region DEEL C: variabelen

            /* --- Oefening C.1: variabelen declareren ---
             * Context: Je wilt een profiel met verschillende datatypes afdrukken.
             *
             * Opdracht:
             * 1. Declareer een `string` `gebruikersnaam` met de waarde "Jan".
             * 2. Declareer een `int` `lengte` met de waarde 185.
             * 3. Declareer een `char` `geslacht` met de waarde 'M'.
             * 4. Druk alle variabelen af in een leesbaar formaat op aparte regels
             * -> uitdaging: combineer een multiline string met interpolatie om alles met één Console.Writeline($@"...") af te drukken
             *
             * Verwachte uitvoer:
             * Naam: Jan
             * Lengte: 185 cm
             * Geslacht: M
             */
            Console.WriteLine("\n\nOefening C.1: variabelen declareren\n------------\n");
			string gebruikersnaam = "Jan";
			int lengte = 185;
			char geslacht = 'M';
			Console.WriteLine($@"Naam: {gebruikersnaam} 
Lengte: {lengte} cm 
geslacht: {geslacht}");

            /* --- Oefening C.2: waarde veranderen --- 
             * 
             * Context: Je wilt de status van een taak bijhouden. De status kan veranderen.
             *
             * Opdracht:
             * 1. Declareer een `string` variabele `status` en geef deze de waarde "in behandeling".
             * 2. Druk de `status` af.
             * 3. Wijs een nieuwe waarde, "afgerond", toe aan dezelfde variabele.
             * 4. Druk de `status` opnieuw af.
             *
             * Verwachte uitvoer:
             * in behandeling
             * afgerond
             */
			string status = "in behandeling";
            Console.WriteLine(status);
			status = "afgerond";
			Console.WriteLine(status);

            /* --- Oefening C.3: waarde optellen ---
             * Context: De score van een speler kan veranderen tijdens een spel.
             *
             * Opdracht:
             * 1. Declareer een `int` variabele `resultaat` en geef deze de waarde 50.
             * 2. Druk de `resultaat` af.
             * 3. Tel 7 op bij deze variabele
             * 4. Druk de `resultaat` opnieuw af.
             *
             * Verwachte uitvoer:
             * 50
             * 57
             */
			int resultaat = 50;
            Console.WriteLine(resultaat);
			resultaat = resultaat + 7;
			Console.WriteLine(resultaat);

            /* --- Oefening C.4: variabele optellen bij andere variabele ---
             * Context: Voeg de waarde van één variabele toe aan een andere
             *
             * Opdracht:
             * 1. Declareer een `int` variabele `punten` met de waarde 40.
             * 2. Druk "Je punten: " en de punten af.
             * 3. Declareer een `int` variabele `bonus` met de waarde 7.
             * 4. Druk "Bonus: " en de bonus af.
             * 5. Tel `bonus` op bij `punten`.
             * 6. Druk "Je totale punten: " en de punten af.
             *
             * Verwachte uitvoer:
             * Je punten: 40
             * Bonus: 7
             * Je totale punten: 47
             */
            Console.WriteLine("\n\nOefening C.4: variabele optellen bij andere variabele\n------------\n");
            // TODO: implementeer hier.
            int punten = 40;
			Console.WriteLine($"je Punten: {punten}");
			int bonus = 7;
			Console.WriteLine($"Je Bonus: {bonus}");
			punten += bonus;
			Console.WriteLine($"Je totale punten: {punten}");
			

            #endregion

            #region DEEL D: escaping en speciale karakters

            /* --- Oefening D.1: escaping - aanhalingstekens ---
             * Context: Je wilt een beroemde quote afdrukken die zelf aanhalingstekens bevat.
             *
             * Opdracht:
             * 1. Declareer een tekstvariabele `quote`.
             * 2. Wijs de volgende tekst toe: Hij zei: "Hallo Wereld!". Zorg ervoor dat de aanhalingstekens correct worden weergegeven.
             * 3. Druk de variabele af.
             *
             * Verwachte uitvoer:
             * Hij zei: "Hallo Wereld!"
             */
            Console.WriteLine("\n\nOefening D.1: escaping - aanhalingstekens\n------------\n");
            // TODO: implementeer hier.
            // ...
			string quote = "Hij zei: \"Hallo Wereld\"";
			Console.WriteLine(quote);
			
            /* --- Oefening D.2: Escaping - tabs en newlines ---
             * Context: Je wilt een korte, gestructureerde lijst afdrukken met één enkel `Console.WriteLine` statement.
             *
             * Opdracht: 
             * 1. gebruik `\t` voor een tab en `\n` om de volgende lijst in één opdracht af te drukken:
             * Cursussen:
             *     C#
             *     HTML
             *     Javascript
             *
             * Verwachte uitvoer:
             * Cursussen:
             *     C#
             *     HTML
             *     Javascript
             */
			 
            Console.WriteLine("\n\nOefening D.2: Escaping - tabs en newlines\n------------\n");
            // TODO: implementeer hier.
            // ...
			Console.WriteLine($@"
			Cursussen:
			C#
			HTML
			Javascript");

            /* --- Oefening D.3: UTF-8 - Symbolen ---
             * Context: Je wilt speciale symbolen zoals het copyright- of euroteken correct weergeven in de console.
             *
             * Opdracht:
             * 1. Stel de `OutputEncoding` van de Console in op `UTF8` (let op: dit moet de allereerste opdrachtregel zijn, helemaal bovenaan deze oefeningen!).
             * 2. Druk de volgende twee regels af met één enkele Console.WriteLine();
             * Prijs: €25 
             * Copyright ©2024"
             *
             * Verwachte uitvoer:
             * Prijs: €25 
             * Copyright ©2024
             */
            Console.WriteLine("\n\nOefening D.3: UTF-8 - Symbolen\n------------\n");
            // TODO: implementeer hier.
            // ...
			Console.OutputEncoding = Encoding.UTF8;
			Console.Write("Prijs €25 \r\nCopyright ©2024");

            #endregion

            #region DEEL E: console kleuren

            /* --- Oefening E.1: Console Kleuren - Achtergrond ---
             * Context: Je wilt een belangrijke waarschuwing afdrukken die extra opvalt door een andere achtergrondkleur.
             *
             * Opdracht:
             * 1. Zet de tekstkleur van de console op groen.
             * 2. Druk de tekst "alle bestanden gekopieerd" af.
             * 3. Zet de achtergrondkleur op `DarkBlue`.
             * 4. Zet de tekstkleur op `Yellow`.
             * 5. Druk de tekst "systeem wordt over 5 minuten herstart." af.
             * 6. Reset de consolekleuren.
             * 7. Druk een lege regel af.
             * 8. Druk de tekst "druk een toets om nu te herstarten".
             *
             * Verwachte uitvoer (met de juiste voor- en achtergrondkleur):
			 
			 * alle bestanden gekopieerd
             * systeem wordt over 5 minuten herstart.
             * druk een toets om nu te herstarten
             */
            Console.WriteLine("\n\nOefening E.1: Console Kleuren - Achtergrond\n------------\n");
            // TODO: implementeer hier.
            // ...
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Alle bestanden gekopierd");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("Systeem word over 5 minuten herstart.");
			Console.Write("");
			Console.ResetColor();
			Console.WriteLine("");
			Console.WriteLine("Druk een toets om nu te herstarten");
            #endregion

        }
    }
}
