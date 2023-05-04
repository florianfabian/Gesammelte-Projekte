// Autor: Florian Fabian - nach Vorlage des Lehrers
// Datum: 19.11.2020

#include <iostream>
using namespace std;
bool vergleich(char[9], char[20]);

int main()
{
	bool falsch = false;
	char pwd[] = "passwort", eingabe[20]; //c-strings
	do
	{
		cout << "Bitte das Passwort: \n";
		cin >> eingabe; //Einlesen
		falsch = vergleich(pwd, eingabe); //Springen zur boolschen Funktion und Wertzuweisung dessen Rückgabewertes in Variable "falsch"
		if (falsch) //Abfrage des Rückgabewertes
		{
			cout << "Eingabe falsch!\n";

		}
		else
		{

			cout << "Eingabe korrekt\n";
			falsch = false;


		}
	}
		while (falsch);  //Solange Eingabe falsch ist

		system("pause");
		return 0;

	

}


bool vergleich(char pwd[9], char eingabe[20])
{


	return strcmp(pwd, eingabe); //Gibt 0 zurück, falls unwahr, und 1, wenn wahr
}