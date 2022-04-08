//Autor: Florian Fabian
//Datum: 03.12.2020
#include <iostream>;
using namespace std;

int main()
{
	int zaehler = 1;

	struct personalien
	{
		string name, vorname;
		int bday, bmonth, byear;



	};
	cout << "Guten Tag! Bitte geben Sie die Personalien der Personen ein.\n";
	personalien.name n1, n2, vn3;
	personalien.vorname = vn1, vn2, vn3;
	personalien.bday = bd1, bd2, bd3;
	personalien.bmonth = bm1, bm2, bm3;
	personalien.byear = by1, by2, by3;

	do {
		cout << "Person " << int << "Name\n";
		cin >> n(zaehler);
		cout << "Person " << int << "Vorname\n";
		cin >> vn(zaehler);
		cout << "Person " << int << "Geburtstag\n";
		cin >> bd(zaehler);
		cout << "Person " << int << "Geburtsmonat\n";
		cin >> bm(zaehler);
		cout << "Person " << int << "Geburtsjahr\n";
		cin >> bm(zaehler);
		zaehler++;

	} while (zaehler < 4);

}