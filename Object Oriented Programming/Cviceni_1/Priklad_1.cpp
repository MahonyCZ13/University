#include <iostream>
#include "zvire.h"
#include "zvire.cpp"
#include "student.h"
#include "student.cpp"
#include <string>

int main()
{
    //Zvire moucha(20); // Parametrova
    //Zvire beruska(pytlik); // Copy konstruktor

    Zvire pytlik; // Bezparametrova

    printf("Pytlik papa!\n");
    pytlik.jez(5);

    printf("Pytlik je na zachode...\n");
    pytlik.vymesuj(3);

    if(!pytlik.zije())
    {
        printf("Pytlik sel spat :(\n");
        return -1;
    }

    printf("Pytlik znovu papa!\n");
    pytlik.jez(1);

    printf("Pytlik je opet na zachode...\n");
    pytlik.vymesuj(4);

    if (!pytlik.jez(1)) 
    {
        if(!pytlik.zije()) printf("Pytlik uz nic nespapa :( \n");
        else return -2;
    }

    Student Petr;

    std::string* predmety[] = {};

    int znamka = 4;
    int hotovo = Petr.hodnoceni(znamka);
    predmety[0] = Petr.zapis("Matematika");
    predmety[1] = Petr.zapis("Cesky Jazyk");

    int delka = sizeof(predmety)/sizeof(predmety[0]);

    for(int i = 0; i <= delka; i++)
    {
        printf("Predmet cislo %d: %s\n", i, predmety[i]);
    }

    //bla<string> = new string[12];
    if (hotovo == 1) printf("Student splnil se znamkou %d\n", znamka);
    else  printf("Student predmet nesplnil\n");

    return 0;
}
