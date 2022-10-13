using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///
///
///Autor:       Florian Fabian
///Datum:       13.10.2022
///Funktion:    Highscorewerte aus Datei auslesen, Methoden zum Manipulieren implementieren
///
///

namespace Uebung62_Highscoreliste
{
    internal class HighScoreFileManager
    {
        public static List<Highscore> ReadHighscoreData()
        {
            List<Highscore> highscore = new List<Highscore>();
            string[] lines = File.ReadAllLines(@"Daten\highscore.csv");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(';');

                string player = data[0];
                int score = Convert.ToInt32(data[1]);
                DateTime timestamp = Convert.ToDateTime(data[2]);

                highscore.Add(new Highscore(player, score, timestamp));
            }
            return highscore;
        }

        internal static void AppendNewHighscore(Highscore neu)
        {
            string line = $"{neu.Player};{neu.Score};{neu.Timestamp}\n";
            File.AppendAllText(@"C:\Users\fabflo\Desktop\Gesammelte-Projekte\3. Block\Uebung62_Highscoreliste\Uebung62_Highscoreliste\Daten\highscore.csv", line);
        }
    }
}
