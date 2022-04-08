#pragma once
#include "Lebewesen.h"
class Pflanzen :
    public Lebewesen
{
private:
    string Blattform;
    float Wuchshöhe;
public:
    Pflanzen();

    void setBlattform();
    void setWuchshöhe();
    string getBlattform();
    float getWuchshöhe();

    ~Pflanzen();
};

