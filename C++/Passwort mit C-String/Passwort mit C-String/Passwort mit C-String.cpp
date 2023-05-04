// Autor: Florian Fabian
// Datum: 16.11.2020
// Editierung/Weiterführung: 19.11.2020
// Aufhören: 19.11.2020 Grund: Verrannt, Lehrer hat Lösung angeschrieben die ich kopieren werde

#include <iostream>
using namespace std;
bool berechnung(char[1], char[1]);
char passworteingabe[1];
char passwort[1];

int main()
{
    char passwort[] = {"passwort"};
    
    cout << "Guten Tag! Bitte geben Sie das festgelegte Passwort ein: \n";
    cout << "Passwortlänge: 8 Zeichen.\n";
 
    
        cin >> passworteingabe;
       
    
    cout << "Vielen Dank! Ihr Passwort wird jetzt abgeglichen... \n";
    system("pause");
    berechnung(passwort, passworteingabe);
  

    system("pause");
    return 0;

}



bool berechnung(char passwort[1], char passworteingabe[1])
{
    system("pause");
    do
    {
        if (passwort == passworteingabe)
        {
            cout << "Richtiges Passwort!!\n";
            system("pause");
            return true;

        }

        else if (passwort != passworteingabe)
        {
            cout << "Falsches Passwort! Nochmal versuchen: \n";

                cin >> passworteingabe;
          
            return false;
           

        };


    } while (passwort != passworteingabe);

   

}


