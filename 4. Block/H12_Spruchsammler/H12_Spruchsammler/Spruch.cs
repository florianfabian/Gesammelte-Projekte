using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///<summary>
///Autor:       Florian Fabian
///Datum:       09.03.2023
///</summary>



namespace H12_Spruchsammler
{
    public class Spruch
    {
        public string text = "";
        public string autor = "";

        public string Text { get => text; set => text = value; }
        public string Autor { get => autor; set => autor = value; }

        public Spruch(string text, string autor)
        {
            Text = text;
            Autor = autor;
        }

        public void Schreiben(string spruchsammlung)
        {
            string[] zeilen = new string[] { spruchsammlung + ","};
            File.WriteAllLines("Sprüche.txt", zeilen);
        }

        public void Auslesen()
        {
            string[] eintraege = File.ReadAllLines("Sprüche.txt");

            foreach (string eintrag in eintraege)
            {
                MainWindow.speicherung(eintrag);
            }
        }

    public override string ToString()
        {
            return $"{text} + {autor}";
        }
    }
}
