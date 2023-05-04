
#pragma once

class Zaehler {
private:

    short zaehler;

public:



    Zaehler(); //Konstruktor
    void setZaehler(short); //Setzer des Zählers
    short getZaehler(); //Ausleser des Zählers
    void incrZaehler(); //Hochzähler
    ~Zaehler(); //Destruktor



};

