using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///
///
///Autor:       Florian Fabian
///Datum:       13.10.2022
///Funktion:    Highscorewerte aus Datei auslesen
///
///

namespace Uebung62_Highscoreliste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Highscore> highscorelist = HighScoreFileManager.ReadHighscoreData();

            Console.WriteLine(string.Join("\n",highscorelist));

            highscorelist.Sort(CompareScores);

            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(string.Join("\n", highscorelist));



            Console.WriteLine();
            Console.WriteLine(AverageScore(highscorelist));

        }

        private static int CompareScores(Highscore x, Highscore y)
        {
            return -x.Score.CompareTo(y.Score);
        }

        public static int ScoreValueForPlayer(List<Highscore> list, string player)
        {
            int maxScore = 0;
            for (int i= 0; i < list.Count; i++)
            { 
                if (list[i].Player == player && list[i].Score > maxScore)
                {
                   maxScore = list[i].Score;      
                }
            }
            return maxScore;
        }

        public static int AverageScore(List<Highscore> list)
        {
            int avgscore = 0;
            for (int i = 0; i < list.Count; i++)
            {
                avgscore += list[i].Score;
            }
            avgscore = avgscore / list.Count;
            return avgscore;
        }
    }
}
