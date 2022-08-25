#include <iostream>
#include "zvire.h"
#include "zvire.cpp"
#include "student.h"
#include "student.cpp"

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
        printf("Tak to je konec!!!\n");
        return -1;
    }

    printf("Pytlik papa!\n");
    pytlik.jez(1);

    printf("Pytlik je opet na zachode...\n");
    pytlik.vymesuj(4);

    if (!pytlik.jez(1)) 
    {
        printf("Pytlik uz nic nespapa...\n");
        //return -2;
    }

    Student Petr;

    int znamka = 4;
    int hotovo = Petr.hodnoceni(znamka);

    if (hotovo == 1) printf("Student splnil se znamkou %d\n", znamka);
    else  printf("Student predmet nesplnil\n");

    return 0;
}
