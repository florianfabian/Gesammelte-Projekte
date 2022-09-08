using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
/// Autor:      Florian Fabian
/// Datum:      29.08.2022
/// Funktion:   Digitalisierung Patientenkartei, Objektorientiert mit Get/Set
///

namespace Uebung53_Patientenkartei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient p1 = new Patient("Meier", "Hans", 55, 'm', 1.80, 90);

            Console.WriteLine("Test Konstruktor: ");
            Console.WriteLine(p1.ToString());

            Console.WriteLine("Test Get, Set: ");
            Console.WriteLine("Get p1 : " + p1.Name);
            p1.Name = "Test";
            Console.WriteLine("Set p1.Name = Test ");
            Console.WriteLine("Ergebnis Set : " + p1.Name);

            Console.WriteLine("Test BMI: ");
            Console.WriteLine($"Ergebnis :  {p1.BerechneBMI():N2}");
            /* HIER ARRAY!!! KEINE EINZELAUSGABE .... habe ich nicht hinbekommen.
             Wie speichert man ein ganzes Objekt in einem einzigen Array? 
            Vielleicht sehe ich die (einfache?) Lösung gerade nicht.*/
            Patient p2 = new Patient("Meier2", "Hans2", 56, 'm', 1.81, 91);
            Patient p3 = new Patient("Meier3", "Hans3", 57, 'w', 1.82, 92);
            Patient p4 = new Patient("Meier4", "Hans4", 58, 'm', 1.83, 93);
            Patient p5 = new Patient("Meier5", "Hans5", 59, 'w', 1.84, 94);
            Patient p6 = new Patient("Meier6", "Hans6", 60, 'm', 1.85, 95);
            Patient p7 = new Patient("Meier7", "Hans7", 61, 'w', 1.86, 96);
            Patient p8 = new Patient("Meier8", "Hans8", 62, 'm', 1.87, 97);
            Patient p9 = new Patient("Meier9", "Hans9", 63, 'w', 1.88, 98);
            Patient p10 = new Patient("Meier10", "Hans10", 64, 'm', 1.89, 99);
            Patient p11 = new Patient("Meier11", "Hans11", 65, 'w', 1.90, 100);

            
            string[] patienten = new string[10];
            /*
            for (int i = 0; i < patienten.Length; i++) {
                patienten[i] = p2;
            }
            */


            

            Console.WriteLine("Ausgabe der anderen 10 Patienten + BMI :");
            Console.WriteLine($"2. Patient : {p2.Name}, {p2.Vorname}        BMI   =   {p2.BerechneBMI():N2}");
            Console.WriteLine($"3. Patient : {p3.Name}, {p3.Vorname}        BMI  =    {p3.BerechneBMI():N2}");
            Console.WriteLine($"4. Patient : {p4.Name}, {p4.Vorname}        BMI   =   {p4.BerechneBMI():N2}");
            Console.WriteLine($"5. Patient : {p5.Name}, {p5.Vorname}        BMI   =   {p5.BerechneBMI():N2}");
            Console.WriteLine($"6. Patient : {p6.Name}, {p6.Vorname}        BMI   =   {p6.BerechneBMI():N2}");
            Console.WriteLine($"7. Patient : {p7.Name}, {p7.Vorname}        BMI   =   {p7.BerechneBMI():N2}");
            Console.WriteLine($"8. Patient : {p8.Name}, {p8.Vorname}        BMI   =   {p8.BerechneBMI():N2}");
            Console.WriteLine($"9. Patient : {p9.Name}, {p9.Vorname}        BMI   =   {p9.BerechneBMI():N2}");
            Console.WriteLine($"10. Patient : {p10.Name}, {p10.Vorname}     BMI   =   {p10.BerechneBMI():N2}");
            Console.WriteLine($"11. Patient : {p11.Name}, {p11.Vorname}     BMI   =   {p11.BerechneBMI():N2}");




        }
        
    }
}
