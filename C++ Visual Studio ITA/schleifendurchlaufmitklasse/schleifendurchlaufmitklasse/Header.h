
#pragma once

class Zaehler {
private:

    short zaehler;

public:



    Zaehler(); //Konstruktor
    void setZaehler(short); //Setzer des Z�hlers
    short getZaehler(); //Ausleser des Z�hlers
    void incrZaehler(); //Hochz�hler
    ~Zaehler(); //Destruktor



};

