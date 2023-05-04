using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


///
/// Autor:      Florian Fabian
/// Datum:      15.02.2023
/// Funktion:   Hangman Spiel
/// Edit:       16.02.2023
/// Edit:       In der Aufgabe wurden explizit Dinge erwähnt (Nicht erweitern, Fehlversuche zählen bei mehrmaliger
///             falscher Eingabe, etc.)
///             Zusätzlich Code verschönert/kommentiert und Rechtschreibfehler beseitigt
///

namespace HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Code entfernt, Edit 16.02.
             * 
            bool loop = false;
            while (loop == false)
            {
            */
                // Wörter aus der Wortliste lesen
                string[] words = File.ReadAllLines(@"C:\Desktop_Dump\Gesammelte-Projekte\Textdateien\Wortliste.txt");

                // Zufälliges Wort auswählen
                Random random = new Random();
                string word = words[random.Next(words.Length)].ToUpper();

                // Initialisieren des Rateworts
                char[] guessed = new char[word.Length];
                for (int i = 0; i < guessed.Length; i++)
                {
                    guessed[i] = '_';
                }

                // Fehlversuche initialisieren
                int wrongGuesses = 0;

                // Spielbeginn
                Console.WriteLine("Wilkommen beim Spiel Hangman!");
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

                        // Prüfen, ob Buchstabe schon (richtig!) geraten wurde
                        if (new string(guessed).IndexOf(letter) >= 0)
                        {
                            Console.WriteLine("Buchstabe '{0}' wurde bereits ausgewählt!", letter);
                        }
                        else
                        {
                            // Prüfen, ob der Buchstabe im Wort vorkommt
                            bool foundLetter = false;
                            for (int i = 0; i < word.Length; i++)
                            {
                                if (word[i] == letter)
                                {
                                    guessed[i] = letter;
                                    foundLetter = true;
                                }
                            }

                            // Prüfen, ob obige Schleife nicht erfolgreich war, iterieren wrongGuesses falls nicht
                            if (!foundLetter)
                            {
                                wrongGuesses++;
                                Console.WriteLine("Buchstabe {0} ist nicht im Wort enthalten! Fehlversuch Nr. {1} von 6", letter, wrongGuesses);

                            }
                        }
                    }
                    // Fehlerausgabe, wenn obige Bedingungen nicht erfüllt wurden
                    else
                    {
                        Console.WriteLine("Bitte geben Sie einen einzelnen Buchstaben ein!");
                    }
                }

                // Ausgabe des Ergebnisses
                if (new string(guessed) == word)
                {
                    Console.WriteLine("Herzlichen Glückwunsch! Sie haben das Wort {0} gefunden!", word);
                }
                else
                {
                    Console.WriteLine("Leider verloren! Das gesuchte Wort war {0}!", word);
                }


                /*
                 * Code entfernt, da in der Aufgabe explizit gesagt worden ist, dass man den Code nicht erweitern soll
                 * 
                // Spiel wird beendet + Frage, ob nochmal gestartet werden soll
                Console.WriteLine("Die Runde ist beendet. Möchten Sie noch einmal?");
                Console.WriteLine("Bitte geben Sie entweder 'Y' für Ja (Neustart Runde) oder eine beliebige andere Taste für Nein (Programm wird beendet) ein:");
                char loopinput = Convert.ToChar(Console.ReadLine().ToUpper());


                if (loopinput != 'Y')
                {
                    loop = true;
                }
                
            }*/
        }
    }
}
