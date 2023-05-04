// Autor: Florian Fabian    
// Datum: 23.11.2020

#include <iostream>
using namespace std;
#include <string>

int main()
{
    string s1 = "Alle Jahre kommt ...";
    string s2 = "wieder ";
    cout << s1 + s2 << endl;
    cout << s2 + s1 << endl;
    s1.insert(11, s2);
    cout << s1 << endl;
    s1.erase(24);
    cout << s1 << endl;
    s1.replace(5, 12, "kommen");
    cout << s1 << endl << endl;
    system("PAUSE");

    return 0;
}

