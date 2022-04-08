#pragma once
class Rechner
{
private:
	float Zahl, ZahlZwei, ErgebnisAdd, ErgebnisSub, ErgebnisMult, ErgebnisDiv;
	int choice;
public:
	Rechner();
	void setZahl(float)
	{
		Zahl = 0;
	}
	float getZahl()
	{
		return Zahl;
	}

	void setZahlzwei(float)
	{
		ZahlZwei = 0;
	}
	float getZahl()
	{
		return ZahlZwei;
	}

	void setChoice(int)
	{
		choice = 0;
	}
	int getChoice()
	{
		return choice;
	}

	void setErgebnisAdd(float, float)
	{
		ErgebnisAdd = Zahl + ZahlZwei;
	}
	float getErgebnisAdd()
	{
		return ErgebnisAdd;
	}

	void setErgebnisSub(float, float)
	{
		ErgebnisSub = Zahl - ZahlZwei;
	}
	float getErgebnisSub()
	{
		return ErgebnisSub;
	}

	void setErgebnisMult(float, float)
	{
		ErgebnisMult = Zahl * ZahlZwei;
	}
	float getErgebnisMult()
	{
		return ErgebnisMult;
	}

	void setErgebnisDiv(float, float)
	{
		ErgebnisDiv = Zahl / ZahlZwei;
	}
	float getErgebnisDiv()
	{
		return ErgebnisDiv;
	}

	~Rechner();


		

};

