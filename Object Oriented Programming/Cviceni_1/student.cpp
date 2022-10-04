#include "student.h"
#include <string>

int Student::hodnoceni(int znamka)
{
	int splneno;
	
	if (znamka >= 1 && znamka < 4) splneno = 1;
	else splneno = 0;

	return splneno;
}

std::string* Student::zapis(std::string predmet)
{
	std::string predmety[] = {};
	int i = 0;
	int aLength = sizeof(predmety) / sizeof(predmety[0]);
	for(i; i < aLength; i++)
	{
		predmety[i] = predmet;
	}
	
	return predmety;
}