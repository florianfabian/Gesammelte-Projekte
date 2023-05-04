#pragma once
#include "Adresse.h"
class Schule :
    public Adresse
{
private:
    char offiVertreter, Name;

public:

    Schule();

    void setOffiVertreter(char ov)
    {
        offiVertreter = ov;
    }
    char getOffiVertreter()
    {
        return offiVertreter;
    }
    void setName(char n)
    {
        Name = n;
    }
    char getName()
    {
        return Name;
    }
 
    ~Schule();

};

