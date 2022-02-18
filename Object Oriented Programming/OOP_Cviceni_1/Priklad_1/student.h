#pragma once

class Student
{
	public:
		int hodnoceni(int znamka);
		int zapis(char* predmet);

	private:
		int znamka;
		char* predmet;
};

