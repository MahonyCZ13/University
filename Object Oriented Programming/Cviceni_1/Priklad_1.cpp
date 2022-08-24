#include <iostream>
#include "zvire.h"
#include "student.h"

using namespace std;

int main()
{
    //Zvire pytlik; // Bezparametrova
    //Zvire moucha(20); // Parametrova
    //Zvire beruska(pytlik); // Copy konstruktor

    //pytlik.jez(5);
    //pytlik.vymesuj(3);

    //if (!pytlik.zije()) return -1;

    //pytlik.vymesuj(4);

    //if (!pytlik.jez(1)) return -2;

    Student Petr;

    int hotovo = Petr.hodnoceni(4);

    if (hotovo == 1) printf("Student splnil se znamkou 2");
    else printf("Student predmet nesplnil");

    return 0;
}
