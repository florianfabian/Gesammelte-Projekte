using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
///
/// Autor:      Florian Fabian
/// Datum:      15.02.2023
/// Funktion:   Hangman-Spiel
///

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)

        {
            // Wörter aus der Wortliste lesen
            string[] words = File.ReadAllLines(@"C:\Desktop_Dump\Gesammelte-Projekte\Textdateien\Wortliste.txt");

            // Zufälliges Wort auswählen
            Random random = new Random();
            string word = words[random.Next(words.Length)].ToUpper();

            // Initialisieren des Ratewortes
            char[] guessed = new char[word.Length];
            for (int i = 0; i < guessed.Length; i++)
            {
                guessed[i] = '_';
            }

            // Fehlversuche initialisieren
            int wrongGuesses = 0;

            // Spielbeginn
            Console.WriteLine("Willkommen beim Spiel Hangman!");
            Console.WriteLine("Das zu erratende Wort hat {0} Buchstaben", word.Length);

            while (wrongGuesses < 6 && new string(guessed) != word)
            {
                // Ausgabe des aktuellen Standes
                Console.WriteLine(new string(guessed));
                Console.WriteLine("Bitte geben Sie einen Buchstaben ein:");
                string input = Console.ReadLine().ToUpper();

                // Prüfen, ob Eingabe gültig ist
                if (input.Length == 1 && Char.IsLetter(input[0]))
                {
                    char letter = input[0];

                    // Prüfen, ob Buchstabe schon geraten wurde
                    if (new string(guessed).IndexOf(letter) >= 0)
                    {
                        Console.WriteLine("Buchstabe '{0}' wurde bereits geraten!", letter);
                    }
                    else
                    {
                        // Prüfen, ob Buchstabe im Wort vorkommt
                        bool foundLetter = false;
                        for (int i = 0; i < word.Length; i++)
                        {
                            if (word[i] == letter)
                            {
                                guessed[i] = letter;
                                foundLetter = true;
                            }
                        }

                        // Wenn Buchstabe nicht im Wort vorkommt, dann Fehlversuch mitzählen
                        if (!foundLetter)
                        {
                            wrongGuesses++;
                            Console.WriteLine("Buchstabe '{0}' ist nicht im Wort enthalten! Fehlversuch Nr. {1} von 6.", letter, wrongGuesses);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Bitte geben Sie einen einzelnen Buchstaben ein!");
                }
            }

            // Ausgabe des Ergebnisses
            if (new string(guessed) == word)
            {
                Console.WriteLine("Herzlichen Glückwunsch, Sie haben das Wort '{0}' gefunden!", word);
            }
            else
            {
                Console.WriteLine("Leider verloren! Das gesuchte Wort war '{0}'.", word);
            }

            Console.WriteLine("Das Spiel ist beendet. Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();
        }
    }
}
