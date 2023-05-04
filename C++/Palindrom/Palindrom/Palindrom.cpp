// Autor: Florian Fabian
// Datum: 23.11.2020

#include <iostream>
using namespace std;
#include <string>




int main()
{
    string palindrom[20];
    string umgekehrt[20];
    bool b = false;
    bool c = false;
    int choice;
    int buchstabe;
    int i = 0;
    do
    {
        cout << "Palindrom Test!\n";
        cout << "Bitte geben Sie Ihren gewuenschten Namen in einzelnen Buchstaben ein: \n";
        do
        {
            cin >> palindrom[i];
            i++;
            cout << "Weiterer Buchstabe? [(1)=y/(2)=n]";
            cin >> buchstabe;
            if (buchstabe == 1)
            {
                b = false;
            }
            else if (buchstabe == 2)
            {
                b = true;
            }
            else
            {
                cout << "Ungueltige Eingabe!";

            };
        } while (b == false);
        system("pause");
        i = 0;
        int io = 19;

        do
        {
            umgekehrt[i] = palindrom[io];
            if (palindrom[i] == umgekehrt[io])
            {
                b = true;
            }
            else
            {
                b = false;

            };
            i++;
            io--;




        } while (io > 0);

        if (b == true)
        {
            cout << "Es handelt sich bei dem Namen um ein Palindrom!\n";
        }
        else
        {
            cout << "Es handelt sich bei dem Namen um kein Palindrom!\n";
        };

        cout << "Moechten Sie noch einen Namen ueberpruefen? [(1)y/(2)n]\n";
        cin >> choice;
        if (choice == 1)
        {
            c = false;
        }
        else
        {
            c = true;
        };

    } while (c == false);


}

