#include "zvire.h"

int Zvire::jez(int jidlo)
{
    if(!zije()) return 0;
    return zaludek += jidlo;
}

int Zvire::vymesuj(int objem)
{
    if((zaludek -= objem) <= 0) zaludek = 0;
    return zaludek;
}
