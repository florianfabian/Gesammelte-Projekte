// Autor: Florian Fabian
// Datum: 31.08.2020

#include <iostream>
using namespace std;
bool positiv(int zahl);
int main()//Einstiegspunkt
{   
    int zahl; //Eine Variable zur Aufnahme der Eingabe
    cout << "Bitte eine ganze Zahl eingeben: "; //Eingabeaufforderung
    cin >> zahl; //Einlesen von Tastatureingabe in die Variable
    if (positiv(zahl)) //Funktionsaufruf mit Auswertung der Rückgabe
        cout << "Die eingegebene Zahl ist positiv\n"; //Vergleich mit dem Wert von bool (hier wenn true, also positiv ist)
    else
        cout << "Die eingegebene Zahl ist negativ\n"; //Vergleich mit dem Wert von bool (hier wenn false, also negativ ist)
    
    system("pause"); //Fenster geöfnnet halten
    return 0;//Die Funktion gibt eine Null zurück
}

bool positiv(int zahl)
{
    if (zahl >= 0) //Abfrage ob die Zahl größer oder gleich null ist (null wird in diesem Beispiel als positiv gewertet)
        return true; //bool wird auf 1 gestellt, falls die Zahl größer oder gleich null ist
    else
        return false; //bool wird auf 0 gesetzt, falls die Zahl negativ ist

}


