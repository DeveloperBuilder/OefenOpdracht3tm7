using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefenOpdracht3tm7
{/*
- Vraag de gebruiker om een getal van 3 tot en met 7 (= 3,4,5,6,7).

- Zet input in een numerieke variabele “ingegevenNummer”.

- Controleer de gebruikersingave en indien deze incorrect is geef je een foutmelding waarna het programma afsluit. 
  Gebruik een if-constructie.

- Print een “enter”. Print de waarden 0 t/m “ingegevenNummer” op het scherm, gescheiden door een liggend streepje. 
  Gebruik een while-constructie.

- Print een “enter”  en voer middels een for-constructie de nummers uit stap 4 in omgekeerde volgorde. 
  Print daarna nogmaals een “enter”. */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer een getal in van 3 tot en met 7: ");
            int ingegevenNummer = Int32.Parse(Console.ReadLine());
            if((ingegevenNummer >= 3) && (ingegevenNummer <= 7))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Het ingegevenNummer {ingegevenNummer} is correct");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Het ingegevenNummer {ingegevenNummer} is incorrect");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();

            Console.WriteLine($"De waarden 0 t/m {ingegevenNummer}:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("0");
            int waarde = 1;

            while (waarde <= ingegevenNummer)
            {
                Console.Write($"_{waarde}");
                waarde++;
            }

            Console.WriteLine("\n");


            Console.WriteLine($"De waarden {ingegevenNummer} t/m 0:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write($"{ingegevenNummer}");
            for (int i = ingegevenNummer - 1; i >= 0; i--)
            {
                Console.Write($"_{i}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
