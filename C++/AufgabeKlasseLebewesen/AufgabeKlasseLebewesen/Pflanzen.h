#pragma once
#include "Lebewesen.h"
class Pflanzen :
    public Lebewesen
{
private:
    string Blattform;
    float Wuchsh�he;
public:
    Pflanzen();

    void setBlattform();
    void setWuchsh�he();
    string getBlattform();
    float getWuchsh�he();

    ~Pflanzen();
};

