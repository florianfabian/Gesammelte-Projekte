// Autor: Florian Fabian
// Datum: 14.09.2020
//
//Programm ist nicht fertig geworden, kurz vor Ende
//Entschuldigung dafür

#include <iostream>
using namespace std;
int rechner(int Jahr); //platzhalter für rechner variable
string name(string); //Platzhalter für Namensvariable (Namensausgabe)


int main()
{
    string programmierer;
    int Jahr; //Variable für das Jahr 
    cout << "Guten Tag!\n";
    cout << "Mit diesem Programm koennen Sie ganz einfach herausfinden, ob ein beliebiges Jahr ein Schaltjahr ist.\n";
    string name(string programmierer);//Springen zur Namensvariable
    cout << name(programmierer);
    system("pause"); // Befehl zum warten des Programms
    cout << "Bitte geben Sie dazu an, welches Jahr sie überprüfen möchten\n";
    cin >> Jahr; //Einlesen des Jahrs

    cout << "Danke!\n";
    int rechner(int Jahr);//Springen zur Rechnervariable

    if (Jahr == 1)
    {
        cout << "Bei dem Jahr handelt es sich um ein Schaltjahr\n";
    }
    else 
    {
        cout << "Bei dem Jahr handelt es sich um KEIN Schaltjahr.\n";
    }

   

    system("pause"); //Programm wird pausiert
    return(0); //Programm gibt 0 zurück



}

string name(string programmierer)
{
    programmierer = "Florian Fabian";
    cout << "Name des Autors: Florian Fabian.\n";
    cout << "Datum der Erstellung 14.09.2020\n";
    return(programmierer);
   

}

int rechner(int Jahr)
{
    int rechnen = 4; //Extravariable zum Rechnen
    int regeleins = 100;
    int regelzwei = 400;
    
    if (Jahr % rechnen == 0 and Jahr % regelzwei == 0 and not Jahr % regeleins == 0) {        //if Konditionen, Regeln sind festgesetzt

        Jahr = 1;
        system("pause");
        return(Jahr);
    }

    else 
    {
        Jahr = 2;
        system("pause");
        return(Jahr);

    }
    

}




