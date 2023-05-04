#pragma once
#include <iostream>
class Adresse
{
private:
	char Land, Straﬂe, HausNr, PLZ;

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
	void setStraﬂe(char s)
	{
		Straﬂe = s;
	}
	char getStraﬂe()
	{
		return Straﬂe;
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

