//Autor: Florian Fabian
//Datum: 07.01.2020
// Hier wird der PIN für eine vorgestellte, nachfolgende Anwendung eingegeben
// Wird der PIN 3x falsch eingegeben, dann beendet sich das Programm;
// Der Nutzer wird also vorgestellt "gesperrt".

#include <iostream>;
using namespace std;
int Zahl = 6239;
int PIN;
int EXIT;

int main()
{
    do
    {
//Aufforderung zum PIN
//Dieser ist voreingestellt auf "6239"
        cout << "Geben Sie bitte Ihre PIN ein.\n";
        cout << "Falls die Zahl nicht uebereinstimmt, muessen Sie den Vorgang wiederholen. Sie haben drei Versuche.\n";
        cin >> PIN;
        if (PIN != 6239) {
            EXIT = EXIT + 1;
        };
//Konto wird gesperrt, wenn dreimal falsch eingegeben
        if (EXIT == 3) {
            cout << "Konto gesperrt";
            system("pause");    
            return (0);
        };

    } while (PIN != 6239);
       
   
    
    

//Wenn PIN korrekt, wird das bestätigt und das Programm beendet sich.    
    if (PIN == 6239) {
        cout << "Pin ist korrekt!\n";
        cout << "Sie werden nun weitergeleitet.\n"; 
            cout << EXIT;

        system ("pause");
        return (0);

    };

        
}

