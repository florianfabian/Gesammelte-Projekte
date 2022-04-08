// Autor: Florian Fabian
// Datum 17.08.2020
// Funktion: Berechnung eines beliebigen Kreisumfanges
//Edit 26.10.2020: Erstellung eines externen Headers für den Precompiler (Florian Fabian)

#include "Header.h"
void Ausgabe(float, float);

int main()
{

	float Rechner=0, Radius;
	cout << "Radius eingeben: \n";
	cin >> Radius;
	Ausgabe(Rechner, Radius);

	system("pause");
	return(0);


}

void Ausgabe(float Rechner, float Radius)
{
	

	
	Rechner = Radius * 2 * M_PI;
	cout << "Ihr Umfang hat einen Wert von: " << Rechner << endl;



}
