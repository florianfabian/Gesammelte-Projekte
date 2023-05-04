// Autor: Florian Fabian
// Datum: 09.11.2020
// Funktion: Lottospiel 6 aus 49

#include <iostream>
using namespace std;
//long ueberpruefung(int, int); zu umständlich, habe alles mit einem vergleich in main() gemacht.

int main()
{
    int lotto[6];                                                               //Deklariert Array für Lottoeingaben
    int Zaehler, Zaehler2, Zaehler3;                                            //Zähler für die Schleifen
    int arrayzwei[6];                                                           //Zweites Array für die Vergleiche
    cout << "Wilkommen beim Lottospiel 6 aus 49! \n";
    for (Zaehler = 0, Zaehler2 = 1; Zaehler < 6; Zaehler++, Zaehler2++)
    {
        cout << "Geben Sie bitte Ihre  " << Zaehler2 << ". Zahl ein: \n";        //Schleife der den Benutzer 6 mal nach Lottozahlen abfragt
        cin >> lotto[Zaehler];                                                  //Die Dann im lotto-array gespeichert werden

    };
    for (Zaehler = 0; Zaehler < 6; Zaehler++)                                     //Schleife in der die Lottozahlen errechnet werden
    {
        int ergebnis = rand() % 49 + 1;
        arrayzwei[Zaehler] = ergebnis;

        for (; ergebnis != arrayzwei[Zaehler];)                                  //Schleife zum Abgleich der Zahlen, bis die Zahl nicht mehr übereinstimmt
        {
            if (ergebnis = arrayzwei[Zaehler])                                      //Wenn Ergebnis mit einer gezogenen Zahl übereinstimmt...
            {
                int ergebnis = rand() % 49 + 1;
                arrayzwei[Zaehler] = ergebnis;                                      //Wird nochmal neu gezogen
                continue;

            };
        };


    };



    cout << "Ihr Gewinn wird berechnet...";                             //Kurzer input für den User

    
    system("pause");                                                    //Kurzes System Pause für bedienlichkeit

    for (Zaehler = 1, Zaehler2 = 0, Zaehler3 = 0; Zaehler < 7; Zaehler++, Zaehler2++)                 //Schleife zum Abgleich mit den Ergebnissen
    {
        cout << "Lottozahl Nummer " << Zaehler << ": " << arrayzwei[Zaehler2]<< "\n";
        if (arrayzwei[Zaehler2] == lotto[Zaehler2])                         //Wenn Ergenis mit gewählter Zahl übereinstimmt, dann...
        {
            cout << "Richtige Zahl! \n";                                    //Gewinnmeldung!
            Zaehler3++;                                                     //Und Zaehler3 +1 für Anzahl richtiger Zahlen
        }
        else
        {


            cout << "Leider nicht richtig! \n";                             //Ansonsten nicht.
        };
     


    };


    cout << "Sie hatten " << Zaehler3 << " richtige Zahlen!\n";             //Ausgabe Zahler 3 für richtige Zahlen
    cout << "Danke fuers mitspielen :)\n";                                   //Grüße an Benutzer
    system("pause");

    
}


//prüft, ob zahlen in der schleife doppelt sind
//falsch gedacht
/*
long ueberpruefung(int Zaehlungsarray[6], int lotto[6])

{
    int ueberpruefung;

    for (ueberpruefung = 0; ueberpruefung < 6; ueberpruefung++)
    {
        if (Zaehlungsarray[ueberpruefung] == lotto[ueberpruefung])
        {
            return 1;

    }
        else
        {

            return 0;
        }

    }
    


}
*/

