#define Deutsch 1
#define Englisch 2
#define Franzoesisch 3
#define Spanisch 4
#define Italienisch 5

#define VERSION Deutsch

#if (VERSION == Deutsch)
	#define SPRACHE cout << "Bitte geben Sie einen Wert ein: \n";
#elif (VERSION == Englisch)
	#define SPRACHE cout << "Please enter a numeric value: \n";
#elif (VERSION == Franzoesisch)
	#define SPRACHE cout << "Se il vous plait entrer une valeur: \n";
#elif (VERSION == Spanisch)
	#define SPRACHE cout << "Por favor, introduzca un valor: \n";
#elif (VERSION == Italienisch)
	#define SPRACHE cout << "Si prega di inserire un valore: \n";
#endif



