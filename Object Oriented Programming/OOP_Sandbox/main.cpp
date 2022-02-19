#include <iostream>
#include "zvire.h"

using namespace std;

int main()
{

    Zvire pytlik;

    pytlik.jez(5);
    pytlik.vymesuj(3);

    if(!pytlik.zije()) return -1;

    pytlik.vymesuj(4);

    if(!pytlik.jez(1)) return -2;

    //cout << pytlik.zaludek << endl;
    return 0;
}
