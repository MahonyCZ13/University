#pragma once

class Zvire
{
public:
    Zvire() { zaludek = 1, stari = 0; }; // Bezparametricky
    Zvire(int zal) { zaludek = zal, stari = 0; }; // Parametricky
    Zvire(const Zvire& vzor) { zaludek = vzor.zaludek, stari = 0; }; //Zvire& -> Copy konstruktor

    int zije() { return zaludek > 0; };
    int jez(int jidlo);
    int vymesuj(int objem);
    int starni(int rychlost);

private:
    int zaludek;
    int stari;
};
