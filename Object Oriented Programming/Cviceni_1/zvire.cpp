#include "zvire.h"

int Zvire::jez(int jidlo)
{
    if (!zije()) return 0;
    int akt = starni(2);
    printf("Stari: %d\n", akt);
    return zaludek += jidlo;
}

int Zvire::vymesuj(int objem)
{
    if ((zaludek -= objem) <= 0) zaludek = 0;
    return zaludek;
}

int Zvire::starni(int rychlost)
{
    if (!zije()) return 0;
    return stari += rychlost;
}