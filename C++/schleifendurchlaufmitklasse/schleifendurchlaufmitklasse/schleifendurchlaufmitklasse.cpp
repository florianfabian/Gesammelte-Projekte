// Autor: Florian Fabian
// Datum: 02.03.2021

#include "Header.h"
#include <iostream>
using namespace std;





int main()
{


    Zaehler z1;//Instanziieren = Ein Objekt der Klasse schaffen
    short wert;//Zum Setzen des Startwertes
    wert = 1;//Zaehler soll mit 1 starten
    
    for (z1.setZaehler(wert); z1.getZaehler() <= 10; z1.incrZaehler())
    {
        cout << "Schleifendurchlauf " << z1.getZaehler() << endl;


    }
    system("pause");
    return 0;
    

}

