#pragma once
#include "Adresse.h"
class Privat :
    public Adresse
{
private:

    char email;
    bool geschwister;

public:

    Privat();

    void setEmail(char e)
    {
        email = e;

    }
    char getEmail()
    {
        return email;
    }

    void setGeschwister(bool g)
    {
        geschwister = g;
    }

    bool getGeschwister()
    {
        return geschwister;
    }

    ~Privat();

};

