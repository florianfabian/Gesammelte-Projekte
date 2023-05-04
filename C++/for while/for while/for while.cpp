//Autor: Florian Fabian
//Datum: 14.01.2020

#include <iostream>;
using namespace std;

char Name;
int Zahl;
int Zaehler = 0;
int Platzhalter = 10;
int Anzahl;
int Wahl;

int main()
{
    cout << "Guten Tag!\n";
    cout << "Hier wird Ihnen ein Schleifendurchlauf 10 x angezeigt.\n";
    cout << "Alternativ koennen Sie eine beliebige Anzahl an Durchlaeufen waehlen.\n";
    cout << "Wollen Sie das tun? 1 fuer Ja, 2 fuer Nein.\n";
    cin >> Wahl;
    cout << "Wie oft wollen Sie die Schleife durchlaufen lassen?\n";
    cin >> Anzahl;
    if (Wahl == 1)
    {
        for (Zahl = 1, Platzhalter = Anzahl; Zaehler != Platzhalter; ++Zahl, ++Zaehler)
        {
            cout << Zahl;
            cout << "\n\nNoch "; cout << Platzhalter - Zaehler - 1; cout << " Schleifendurchlaeufe.";
            cout << " Sie hatten bisher "; cout << Zaehler; cout << " Schleifendurchlaeufe\n\n";


        }
    }
    
    else

        for (Zahl = 1; Zaehler != Platzhalter; ++Zahl, ++Zaehler)
    {
        cout << Zahl;
        cout << "\n\nNoch "; cout << Platzhalter - Zaehler - 1; cout << " Schleifendurchlaeufe.";
        cout << " Sie hatten bisher "; cout << Zaehler + 1; cout << " Schleifendurchlaeufe\n\n";
        

    }
        
       
    system("pause");
}

