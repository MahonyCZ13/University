#pragma once

#include <string>

class Student
{
	public:
		int hodnoceni(int znamka);
		std::string* zapis(std::string predmet);

	private:
		int znamka;
		std::string predmet;
		//std::string predmety[];
};

