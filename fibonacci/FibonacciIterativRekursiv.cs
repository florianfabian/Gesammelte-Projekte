using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:              Florian Fabian
/// Datum:              08.04.2022
/// Funktion:           Fibonacci-Zahlenfolge in zwei zusätzlichen Methoden
/// </summary>

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eingabe = 0;
            long iterativ = 0;
            long rekursiv = 0;
            Console.WriteLine("Programm zur Berechnung von Fibonacci Zahl bis Zahl n\n");
            Console.WriteLine("Bitte Zahl n eingeben: \n");
            eingabe = Convert.ToInt32(Console.ReadLine());
            iterativ = FibIterativ(eingabe);
            Console.WriteLine("\nFibonacci Iterativ, Fib("+eingabe+"): \n\n" + iterativ);
            rekursiv = FibRekursiv(eingabe);
            Console.WriteLine("\nFibonacci über eine rekursive Methode weitergegeben, Fib(" + eingabe + "): \n\n" + rekursiv);
            Console.WriteLine("\n\n\nErste 50 Stellen der Fibonacci Folge: \n");

            long x = 0;
            long y = 1;
            long z = 0;
            for (int i = 0; i < 50; i++)
            {
                z = x;
                x = y;
                y = z + y;
                Console.Write(x + "\t");
            }

        }
        public static long FibIterativ(int n)
        {
            long a = 0;
            long b = 1;
            long c = 0;
            for(int i = 0; i<n; i++)
            {
                c = a;
                a = b;
                b = c + b;
            }
            return a;
        }
        public static long FibRekursiv(int n)
        {
            long rechner = FibIterativ(n);
            return rechner;
        }
    }
}
