using System;

namespace ConsoleConsoleGangsterName
{
   class Program
   {
      static void Main(string[] args)
      {
		  Console.WriteLine(@"************************
| GANGSTA NAME BUILDER |
************************ ");

		  Console.Write("Give the first name of any Disney Characters: "); 
		  string naam = Console.ReadLine();
		  Console.Write("Give any workbench tool: ");
		  string tool = Console.ReadLine();
		  Console.Write("What is your last name: ");
		  string lastname = Console.ReadLine();
		  string gangstername = naam + " 'the " + tool + "' " + lastname;
		  Console.Write("Your gangsta name: ");
		  Console.ForegroundColor = ConsoleColor.Green;
		  Console.Write(gangstername);
		  Console.ResetColor();
		  }
   }
}
