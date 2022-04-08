// Autor: Florian Fabian
// Datum: 31.08.2020
//
//

#include <iostream>
using namespace std;
float rechner(float temparatur, int entscheidung); //platzhalter für rechner variable

int main()
{
    int entscheidung; // Variable für die Wahl zwischen Fahrenheit/Celsius
    float temparatur; // Variable für die gemessene Temparatur
    cout << "Guten Tag!\n";
    cout << "Mit diesem Programm koennen Sie ganz einfach Fahrenheit in Celsius oder umgekehrt rechnen.\n";
    system("pause"); // Befehl zum warten des Programms
    cout << "Bitte geben Sie dazu erst an, in welchem Messsystem Sie die Temparatur gemessen haben.\n";
    cout << "Druecken Sie (1) für Fahrenheit oder (2) für Celsius: \n"; 
    cin >> entscheidung; //Einlesen der Entscheidung
//#if (entscheidung != 1)
 //       cout << "Ungueltige Eingabe! Bitte noch einmal eingeben.";            //Funktionierte nicht - aber für das Programm erstmal nicht nötig
//        int main();
//#endif
    cout << "Danke!\n";
    cout << "Bitte geben Sie jetzt Ihren gemessenen Wert ein: \n";
    cin >> temparatur;      //Einlesen der gemessenen Temparatur
    float rechner(float temparatur, int entscheidung); //Springen zur Rechnervariable
    if (entscheidung == 1) //Abfrage ob Fahrenheit gewählt wurde
        cout << "Ihre Temparatur betraegt umgerechnet " << rechner(temparatur, entscheidung) << " Grad Celsius."; //Ausgabe der Rechnervariable
    else // Fals Fahrenheit nicht gewählt wurde, passiert das nächste:
        cout << "Ihre Temparatur betraegt umgerechnet " << rechner(temparatur, entscheidung) << " Grad Fahrenheit"; //Ausgabe der Rechnervariable
    system("pause"); //Programm wird pausiert
    return(0); //Programm gibt 0 zurück



}

float rechner(float temparatur, int entscheidung)
{
    float rechnen; //Extravariable zum Rechnen (um das ganze cleaner zu machen)
    rechnen = temparatur; //Rechnen wird Temparatur gleichgesetzt
    if (entscheidung == 1) //if abfrage, welche entscheidung getroffen wurde
    {
        rechnen = (rechnen - 32) / 1.8; //Umrechnen mit offizieller Formel
        temparatur = temparatur * 0 + rechnen; //Temparatur wird zurückgesetzt und danach der Variable "rechnen" gleichgesetzt
        return temparatur; //Programm gibt den Wert der Variable "temparatur" zurück
    }

    else
    {
        rechnen = rechnen * 1.8 + 32; //Umrechnen mit offizieller Formel
        temparatur = temparatur * 0 + rechnen; //Temparatur wird zurückgesetzt und danach der Variable "rechnen" gleichgesetzt
        return temparatur; //Programm gibt den Wert der Variable "temparatur" zurück
    }


}
