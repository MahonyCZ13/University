#ifndef ZVIRE_H
#define ZVIRE_H

class Zvire
{
    public:
        Zvire() { zaludek = 1; };
        int zije() { return zaludek > 0; };
        int jez(int jidlo);
        int vymesuj(int objem);

    private:
        int zaludek;
};

#endif // ZVIRE_H
