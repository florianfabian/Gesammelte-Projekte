using System;
using System.Collections.Generic;
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
    internal class Highscore
    {
        private string player;
        private int score;
        private DateTime timestamp;

        public Highscore(string player, int score, DateTime timestamp)
        {
            this.player = player;
            this.score = score;
            this.timestamp = timestamp;
        }

        public string Player { get => player; set => player = value; }
        public int Score { get => score; set => score = value; }
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }

        public override string ToString()
        {
            return $"[Player = {Player}, Score = {Score}, TimeStamp = {Timestamp}";
        }
    }
}
