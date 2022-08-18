#pragma once

class Student
{
	public:
		int hodnoceni(int znamka);
		int zapis(char* predmety);

	private:
		int znamka;
		char* predmet;
		char* predmety[];
};

