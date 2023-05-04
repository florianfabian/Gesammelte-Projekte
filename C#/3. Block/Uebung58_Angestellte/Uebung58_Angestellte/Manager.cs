using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///
///Autor:       Florian Fabian
///Datum:       12.09.22
///Funktion:    Vererbungen darstellen am Objekt der Angestellten
///Edit:        15.09.22 : Klasse Manager hinzugefügt, mit Override Klassenfremder Methoden
///
///

namespace Uebung58_Angestellte
{
    internal class Manager : Angestellter
    {
        private double zulage;
        private Angestellter[] personalverantwortung;
        private bool mitgliedDerGeschaeftsleitung;
        private int jahreFirmenzugehoerigkeit;



        public double Zulage { get => zulage; set => zulage = (base.BerechneMonatsgehalt() * Firmentreu()) + (base.BerechneMonatsgehalt() * MehrAls12())
                + (base.BerechneMonatsgehalt() * MitgliedGesch()) + base.BerechneMonatsgehalt();
        }
        public bool MitgliedDerGeschaeftsleitung { get => mitgliedDerGeschaeftsleitung; set => mitgliedDerGeschaeftsleitung = value; }
        public int JahreFirmenzugehoerigkeit { get => jahreFirmenzugehoerigkeit; set => jahreFirmenzugehoerigkeit = value; }
        internal Angestellter[] Personalverantwortung { get => personalverantwortung; set => personalverantwortung = value; }

        public Manager(double grundgehalt, bool mitgliedDerGeschaeftsleitung, int jahreFirmenzugehoerigkeit)
                                : base(grundgehalt)
        {
            Personalverantwortung = personalverantwortung;
            MitgliedDerGeschaeftsleitung = mitgliedDerGeschaeftsleitung;
            JahreFirmenzugehoerigkeit = jahreFirmenzugehoerigkeit;
        }

        private double MitgliedGesch()
        {
            if(MitgliedDerGeschaeftsleitung == true)
            {
                return 0.10;
            }
            else
            {
                return 0.00;
            }
        }
        private double MehrAls12()
        {
            if(Personalverantwortung.Length >= 12)
            {
                return 0.10;
            }
            else
            {
                return 0.00;
            }
        }

        private double Firmentreu()
        {
            if (JahreFirmenzugehoerigkeit >= 10)
            {
                return 0.10;
            }
            else
            {
                return 0.00;
            }
        }
        /*private double Zulagenberechnung()
        {
            double rechnung = (base.BerechneMonatsgehalt() * Firmentreu()) + (base.BerechneMonatsgehalt() * MehrAls12())
                + (base.BerechneMonatsgehalt() * MitgliedGesch()) + base.BerechneMonatsgehalt();
            return rechnung;
        }
        */
        public override double BerechneMonatsgehalt()
        {
            
            return base.Grundgehalt + Zulage;
        }

        public override string ToString()
        {
            return $"\nManager [grundgehalt = {Grundgehalt}, zulage = {Zulage}, personalverantwortung = {Personalverantwortung}, mitgliedDerGeschaeftsleitung = {MitgliedDerGeschaeftsleitung}, Jahre Firmenzugehörigkeit = {JahreFirmenzugehoerigkeit}]";
        }
    }
}