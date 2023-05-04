#include <iostream>
using namespace std;


void main(void)
{
	cout << "Eine Variable vom Typ char belegt " << sizeof(char) << " Byte\n";
	cout << "und hat den Wertebereich von " << CHAR_MIN << " bis" << CHAR_MAX << endl;
	cout << "Eine Variable vom Typ int belegt " << sizeof(int) << " Byte\n";
	cout << "und hat den Wertebereich von " << INT_MIN << "bis  " << INT_MAX << endl;
	system("pause");
}