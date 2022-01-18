/*
 * =====================================================================================
 *
 *       Filename:  priklad_1.c
 *
 *    Description:  1. Napište funkci modulo pro reálná čísla. Příklad: 2,64 / 1,2 = 2,2. 
 *                     Celočíselně tedy 2. Zbytek po celočíselném dělení by byl 2,64 - 2*1,2 tedy 0,24.
 *                  2. Napište program, který ze vstupních dat spočítá aritmetický
 *                     průměr a najde třetí největší prvek. Funkce nesmí
 *                     modifikovat vstupní parametry, ani nesmí pole 
 *        
 *        Remarks:  Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
 *                  Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
 *                  Nikdo me pri vypracovani neradil
 *                  Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
 *                  NENI MOJE TVORBA
 *                  Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
 *                  Petr Maronek, 36456
 *
 *        Version:  0.1
 *        Created:  15/01/2021 09:13:04 PM
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  Petr Maronek, 36456 
 *   Organization:  VSFS
 *
 * =====================================================================================
 */

#include<stdio.h>
#include<math.h>

int Modulo(double cislo1, double cislo2)
{
    double mezisoucet = cislo1 / cislo2;
    int vysledek = round(mezisoucet);
    //printf("Mezi: %f\n", mezisoucet);
    return vysledek;
}

int Average()
{
    int pole[] = {3, 1, 5, 2, 6, 1, 7, 2};
    //int akt;
    int iterace = 7;
    int nejvetsi;
    int druheNejvetsi;
    int tretiNejvetsi;
    int akt;
    int mezisoucet = 0;
    double vysledek;
    for(int i = 0; i <= iterace; i = i+1)
    {
        akt = pole[i];
        mezisoucet = mezisoucet + akt;
        //printf("----------- Zacatek ------------\n");
        //printf("akt: %d\n", akt);
        //printf("Nejvetsi: %d\n", nejvetsi);
        //printf("Druhe nejvetsi: %d\n", druheNejvetsi);
        //printf("Treti nejvetsi: %d\n", tretiNejvetsi);
        
        if(nejvetsi < akt)
        {
            tretiNejvetsi = druheNejvetsi;
            druheNejvetsi = nejvetsi;
            nejvetsi = akt;
        }
        if(druheNejvetsi < akt && nejvetsi > akt)
        {
            tretiNejvetsi = druheNejvetsi;
            druheNejvetsi = akt;
        }
        if(tretiNejvetsi < akt && druheNejvetsi > akt && nejvetsi > akt)
        {
            tretiNejvetsi = akt;
        }

        //printf("----------- Konec ------------\n");
        //printf("Nejvetsi: %d\n", nejvetsi);
        //printf("Druhe nejvetsi: %d\n", druheNejvetsi);
    }
    vysledek = mezisoucet / iterace;
    printf("Prumer: %d/%d=%2.2f\n", mezisoucet, iterace, vysledek);

    printf("Treti nejvetsi: %d\n", tretiNejvetsi);
    return 0;
}

int main()
{
    Average();
    //printf("Vysledek: %d\n", Modulo(2.64, 1.2));
    return 0;
}
