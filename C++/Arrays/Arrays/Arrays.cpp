//Autor: Florian Fabian 
//Datum: 05.11.2020
//Thema: Arrays

#include <iostream>
using namespace std;


int main()
{
    short arrayeins[] = { 120, 240, 360 };
    cout << "Aufgabe 1:";
    cout << "\nWert von Zahl eins: " << arrayeins[0];
    cout << "\nWert von Zahl zwei: " << arrayeins[1];
    cout << "\nWert von Zahl drei: " << arrayeins[2];
    int summe = arrayeins[0] + arrayeins[1] + arrayeins[2];
    cout << "\nSumme der drei Zahlen: " << summe;
    cout << "\n Wert von Zahl vier: " << arrayeins[3];

    system("pause");


    short arrayzwei[5];
    cout << "\nAufgabe 2:";
    cout << "\n Bitte geben Sie die erste Zahl ein: ";
    cin >> arrayzwei[0];
    cout << "\n Bitte geben Sie die zweite Zahl ein: ";
    cin >> arrayzwei[1];
    cout << "\n Bitte geben Sie die dritte Zahl ein: ";
    cin >> arrayzwei[2];
    cout << "\n Bitte geben Sie die vierte Zahl ein: ";
    cin >> arrayzwei[3];
    cout << "\n Bitte geben Sie die fünfte Zahl ein: ";
    cin >> arrayzwei[4];
    cout << "\nWert von Zahl 5: " << arrayzwei[4];
    cout << "\nWert von Zahl 4: " << arrayzwei[3];
    cout << "\nWert von Zahl 3: " << arrayzwei[2];
    cout << "\nWert von Zahl 2: " << arrayzwei[1];
    cout << "\nWert von Zahl 1: " << arrayzwei[0];

    system("pause");

    int Zaehler = 20;
    int arrayrechner = 0;
    short arrayinhalt = 0;
    short arraydrei[20];
    cout << "\n Aufgabe 3: ";
    do
    {

        arraydrei[arrayrechner] = { arrayinhalt };
        arrayrechner++;
        Zaehler--;
        cout << "\nInhalt der Arrayzeile " << arrayrechner << ": " << arrayinhalt;
        arrayinhalt = arrayinhalt + 10;


    } while (Zaehler != 0);


    system("pause");




    /*cout << "\n Aufgabe 4: ";
    short arrayvier[5];
    cout << "\n Bitte geben Sie die erste Zahl ein: ";
    cin >> arrayvier[0];

    cout << "\n Bitte geben Sie die zweite Zahl ein: ";
    cin >> arrayvier[1];

    cout << "\n Bitte geben Sie die dritte Zahl ein: ";
    cin >> arrayvier[2];

    cout << "\n Bitte geben Sie die vierte Zahl ein: ";
    cin >> arrayvier[3];

    cout << "\n Bitte geben Sie die fünfte Zahl ein: ";
    cin >> arrayvier[4];

   
    
        if (arrayvier[0] < arrayvier[1] && arrayvier[0] < arrayvier[2] && arrayvier[0] < arrayvier[3] && arrayvier[0] < arrayvier[4])
        {
            cout << "Kleinste Zahl: " << arrayvier[0];
            if (arrayvier[1] < arrayvier[0] && arrayvier[1] < arrayvier[2] && arrayvier[1] < arrayvier[3] && arrayvier[1] < arrayvier[4])
            {
                cout << "Zweitkleinste Zahl: " << arrayvier[1];

            }
            else if ()
        };



   

    

    system("pause"); */
}


