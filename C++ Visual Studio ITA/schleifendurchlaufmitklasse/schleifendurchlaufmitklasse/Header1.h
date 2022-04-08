#pragma once
#include "Header.h"

Zaehler::Zaehler()
{
    zaehler = 0;

}

void Zaehler::setZaehler(short wert)
{
    zaehler = wert;
}

short Zaehler::getZaehler()
{
    return zaehler;
}

void Zaehler::incrZaehler()
{
    zaehler++;
}

Zaehler::~Zaehler()
{
    zaehler = 0;
}