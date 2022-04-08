#pragma once
using namespace std;
#include <iostream>
class Lebewesen
{
private:
	string Name;
	int AlterinJahren;

public:
	Lebewesen();
	void setName();
	void setAlterinJahren();
	string getName();
	int getAlterinJahren();
	~Lebewesen();

	
};

