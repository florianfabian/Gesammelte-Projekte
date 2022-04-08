using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///Autor: Florian Fabian
///Datum: 03.11.21
///Funktion des Programms: Codieren mit Datentypen, ein Gefühl als Programmierer dafür bekommen
namespace Übung5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 113, b2 = 145;
            sbyte sb1 = -113;
            short s1 = short.MaxValue, s2 = short.MinValue;
            int i1 = -123_456_789, i2 = 0xA2B4, i3 = 0b1001;
            long l1 = 9_876_543_210;

            Console.WriteLine("Werte der Byte Variablen:\n");
            Console.WriteLine("B1: "+ b1 + "\nB2: " + b2 + "\n");
            Console.WriteLine("Werte der Sbyte Variablen: \n");
            Console.WriteLine("SB1: " + sb1 + "\n");
            Console.WriteLine("Werte der short Variablen:\n");
            Console.WriteLine("S1: " + s1 + "\ns2: " + s2 + "\n");
            Console.WriteLine("Werte der int Variablen: \n");
            Console.WriteLine("I1: " + i1 + "\nI2 " + i2 + "\nI3 " + i3 + "\n");
            Console.WriteLine("Werte der long Variablen: \n");
            Console.WriteLine("l1: " + l1);

        }
    }
}
