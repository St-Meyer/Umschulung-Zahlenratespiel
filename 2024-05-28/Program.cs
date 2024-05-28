using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Settings
            Console.OutputEncoding = Encoding.Unicode;

            // Declaration
            int hiddenNumber, input, counter, maxGuessCount;
            bool guessedCorrectly;

            // Initialisation
            hiddenNumber = new Random().Next(1, 99);
            guessedCorrectly = false;
            counter = 1;
            maxGuessCount = 10;

            // Opening Message
            Console.WriteLine("Willkommen beim Zahlen-Ratespiel! ");
            Console.WriteLine("Sie müssen eine Zahl erraten und es wird gesagt, " + 
                              "ob Sie höher oder tiefer tippen müssen");
            Console.WriteLine("Sie haben {0} Versuche!", maxGuessCount);

            // EVA
            while (guessedCorrectly == false && counter <= maxGuessCount)
            {        
                Console.Write("Dies ist Ihr {0}. Versuch. " +
                              "Bitte geben Sie Ihren Tipp: ", counter++);
                input = int.Parse(Console.ReadLine());

                if (input < hiddenNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Deine Zahl ist zu niedrig!");
                }
                else if (input > hiddenNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Deine Zahl ist zu hoch!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Herzlichen Glückwunsch! Deine Zahl ist korrekt! 😁🎉");
                    guessedCorrectly = true;
                }
                Console.ResetColor();
                if (counter > maxGuessCount)
                    Console.WriteLine("Die Zahl war {0}.", hiddenNumber);          
            }
        }
    }
}