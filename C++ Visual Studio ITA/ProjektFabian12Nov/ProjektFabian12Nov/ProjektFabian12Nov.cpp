/*
Autor:					Florian Fabian
Programm:				Zinsrechner
Datum der Erstellung:	12.11.2019
Beschreibung:			Dieses Programm errechnet das Endkapital von einem beliebigen Startkapital.
						Dies passiert zu einem beliebigen Zinssatz und über eine beliebige Laufzeit in Jahren.



*/


#include <iostream>
using namespace std;


int main()
{
	float Startkapital, Endkapital, Laufzeit, Zinssatz;
	system("chcp 1252");
	system("cls");
    cout << "Guten Tag! \n";
	cout << "Dieses Programm berechnet Ihnen das Endkapital von einem Startkapital mit einem beliebigen Zinssatz für einem beliebigen Zeitraum.\n";
	cout << "\nBitte geben Sie Ihr gewünschtes Startkapital ein: ";
	cin >> Startkapital;
	cout << "\nBitte geben Sie Ihre gewünschte Laufzeit in Jahren ein: ";
	cin >> Laufzeit;
	cout << "\nBitte geben Sie Ihren gewünschten Zinssatz in Prozenten ohne Prozenzeichen ein: ";
	cin >> Zinssatz;
	Zinssatz / 100 + 1;
	Endkapital = Startkapital * pow(((100 + Zinssatz) / 100), Laufzeit);
	cout << "\nEndkapital: " << Endkapital;
	cout << "\n";
	system("pause");
	return 0;




}


