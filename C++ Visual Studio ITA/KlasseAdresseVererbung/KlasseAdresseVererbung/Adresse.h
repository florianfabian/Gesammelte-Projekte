#pragma once
#include <iostream>
class Adresse
{
private:
	char Land, Stra�e, HausNr, PLZ;

public:
	Adresse();
	void setLand(char l)
	{
		Land = l;
	}
	char getLand() 
	{
		return Land;
	}
	void setStra�e(char s)
	{
		Stra�e = s;
	}
	char getStra�e()
	{
		return Stra�e;
	}
	void setHausNr(char hnr)
	{
		HausNr = hnr;
	}
	char getHausNr()
	{
		return HausNr;
	}
	void setPLZ(char p)
	{
		PLZ = p;
	}
	char getPLZ()
	{
		return PLZ;
	}
	~Adresse();
};

