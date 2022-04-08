#pragma once
#include "Lebewesen.h"

class Tiere :
    public Lebewesen
{
private:
    string Kleid;
    float Geschwindigkeit;
public:
    Tiere();
    void setKleid();
    void setGeschwindigkeit();
    string getKleid();
    float getGeschwindigkeit();
    ~Tiere();
};

