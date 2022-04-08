//Autor: Florian Fabian
//Datum: 03.12.2020
#include <iostream>;
#include <string.h>
#include <string>;
#include <cstring>
using namespace std;
struct personalien
{
	char name;
	char vorname;
	int bday;
	int bmonth;
	int byear;



};

int main()
{

	

	
	cout << "Guten Tag! Bitte geben Sie die Personalien der Personen ein.\n";

	personalien person1;
	personalien person2;
	personalien person3;

		cout << "Person 1 Name\n";
		cin >> person1.name;
		cout << "Person 1 Vorname\n";
		cin >> person1.vorname;
		cout << "Person 1 Geburtstag\n";
		cin >> person1.bday;
		cout << "Person 1 Geburtsmonat\n";
		cin >> person1.bmonth;
		cout << "Person 1 Geburtsjahr\n";
		cin >> person1.byear;
		system("cls");
	
		cout << "Person 2 Name\n";
		cin >> person2.name;
		cout << "Person 2 Vorname\n";
		cin >> person2.vorname;
		cout << "Person 2 Geburtstag\n";
		cin >> person2.bday;
		cout << "Person 2 Geburtsmonat\n";
		cin >> person2.bmonth;
		cout << "Person 2 Geburtsjahr\n";
		cin >> person2.byear;
		system("cls");

		
		cout << "Person 3 Name\n";
		cin >> person3.name;
		cout << "Person 3 Vorname\n";
		cin >> person3.vorname;
		cout << "Person 1 Geburtstag\n";
		cin >> person3.bday;
		cout << "Person 3 Geburtsmonat\n";
		cin >> person3.bmonth;
		cout << "Person 3 Geburtsjahr\n";
		cin >> person3.byear;

		system("cls");
		cout << "Ausgabe Person 1: \n";
		cout << person1.name << endl;
		cout << person1.vorname << endl;
		cout << person1.bday << endl;
		cout << person1.bmonth << endl;
		cout << person1.byear << endl;
		system("pause");
		system("cls");
		cout << "Ausgabe Person 2: \n";
		cout << person2.name << endl;
		cout << person2.vorname << endl;
		cout << person2.bday << endl;
		cout << person2.bmonth << endl;
		cout << person2.byear << endl;
		system("pause");
		system("cls");
		cout << "Ausgabe Person 3: \n";
		cout << person3.name << endl;
		cout << person3.vorname << endl;
		cout << person3.bday << endl;
		cout << person3.bmonth << endl;
		cout << person3.byear << endl;
		system("pause");
		system("cls");

	


}