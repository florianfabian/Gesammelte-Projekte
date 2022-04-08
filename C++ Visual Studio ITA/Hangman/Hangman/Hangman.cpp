// Autor: Florian Fabian
// Datum: 26.11.2020
// Programm: Hangman

#include <iostream>
using namespace std;
#include <string>
#include<string.h>
char Wort[20];
char Raten[1];
char Ergebnis[20];


int main()
{
    int i = 0;
    int b = 0;
    int x = 0;
    int gesamt = 7;
    int choice;
    bool j;
    bool programm = false;
    bool partone = false;
  
        do
        {
            cout << "Willkommen bei Hangman!\n";                                                                        //Begrüßung an den Benutzer
            cout << "Bitte geben Sie die einzelnen Buchstaben des Wortes ein, das Sie loesen moechten : \n";

            do
            {
                cin >> Wort[i];
                cout << "Weiterer Buchstabe? [(1)=y/(2)=n]";                    
                cin >> choice;
                if (choice == 1)                                                                                        //Schleife zum Einlesen der Variablen
                {
                    j = false;
                }
                else if (choice == 2)
                {
                    j = true;
                }
                else
                {
                    cout << "Ungueltige Eingabe!";

                };
            } while (j == false);
            system("cls");                                                                                             //Bildschirm wird für zweiten Benutzer freigegeben
            int wortlang = strlen(Wort);
            cout << "Das zu erratene Wort hat " << wortlang << " Buchstaben.\n";                                       //Wortlänge wird ausgegeben
            cout << "Bitte raten Sie einen Buchstaben: ";
           
            i = 0;
            do
            {
                cin >> Raten[0];                                                                                        //Ratespiel in Schleife gepackt
                i++;                                                                                                    //Ratebuchstabe wird in Variable "Raten" geschrieben
                                                                                                                        //Zählervariable
                b = 0;
                x = 0;                                                                                                  //Variablen x und c werden vor dem Schleifendurchgang noch einmal festgesetzt
                bool c = true;
                do
                {
                    if (Raten[0] == Wort[b])                                                                            //Wenn der gewählte Buchstabe mit einem des Wortes übereinstimmt, dann...
                    {

                        
                                                                                                                        //...wird eine Meldung ausgegeben!
                        cout << "Richtig!\n";                                                                           //String Wort wird in String Ergebnis ausgegeben
                        Ergebnis[x] = Wort[x];
                        x++;
                        

                    }
                    else if (Raten[0] != Wort[b])
                    {
                        c = false;

                    }
                    b++;

                } while (b < 20);
                if (strcmp(Ergebnis, Wort) == 0)                                                                        //Wenn Wort und Ergebnis gleich sind, dann....
                {
                    cout << "Sie haben gewonnen!\n";                                                                    //wird eine Meldung ausgegeben!
                    system("pause");
                    partone = true;
                }
                                                                                                                        //Wenn nicht, dann wird weiter gemacht
                if (partone == false)
                {
                    system("cls");
                    cout << "Ihre erratenen Buchstaben ";
                    printf(Ergebnis);
                    cout << " Weiter so!\n";
                }

                system("pause");

        


                if (c == false && x<1)                  //Wenn kein Ergebnis erzielt werden konnte, dann...
                {



                    cout << "Keinen Treffer!\n";                        //Gibt es eine entsprechende Meldung
                    gesamt--;
                    cout << "Noch " << gesamt << " Versuche!\n";
                    
                




                    }
                
                if (gesamt == 0)                                    //Wenn keine Leben mehr übrig sind...
                {
                    cout << "Leider verloren!\n";                   //Verliert der Spieler
                    system("pause");    
                    bool partone = true;                                //Schleifenbedingung wird aufgelöst



                }



            } while (partone == false);

            cout << "Noch ein Spiel? [(1)y/(2)n]\n";        //Wird nach einer evtl. gewünschten neuen Runde gefragt,
            choice = 0;                                     //Variable wird wieder auf 0 gesetzt (da sie schon einmal verwendet wurde),
            cin >> choice;                                  //Variable wird eingelesen,
            if (choice == 1)                                //Wenn 1 dann...
            {
                programm = false;                           //Läuft Schleife weiter,
            }
            else if (choice == 2)                           //Wenn 2 dann...
            {
                programm = true;                            //Wird Bedingung der Variable außer Kraft gesetzt
                cout << "Danke fuers Mitspielen! Auf Wiedersehen \n";
                system("pause");
                break;
                return 0;                                   //Programm wird beendet

            }
          
       
            
        



    } while (programm == false);




}


