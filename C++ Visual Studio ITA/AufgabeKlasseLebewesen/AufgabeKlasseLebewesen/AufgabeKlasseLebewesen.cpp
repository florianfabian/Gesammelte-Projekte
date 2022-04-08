// Autor: Florian Fabian
// Datum: 26.03.2021

#include <iostream>
#include "Lebewesen.h"
#include "Pflanzen.h"
#include "Tiere.h"
int main()
{
	short anzahl = 0; 
	int i = 0;
	cin >> anzahl;
	Tiere* Wolf = new Tiere[anzahl];
	 Wolf[i].getName();
	 Wolf[i].getAlterinJahren();
	 Wolf[i].getKleid();
	 Wolf[i].getGeschwindigkeit();

	 Pflanzen* Bambus = new Pflanzen[anzahl];
	 Bambus[i].getName();
	 Bambus[i].getAlterinJahren();
	 Bambus[i].getBlattform();
	 Bambus[i].getWuchshöhe();


	 bool choice;
	 cout << "Welches Lebewesen soll ausgegeben werden?\n";

	 cin >> choice;

	 if (choice == true)
	 {


	 }
	 else (choice == false)
	 {


	 }

	


	

}
