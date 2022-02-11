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
 // Fuknce na modulo
int Modulo(double cislo1, double cislo2)
{

    // Vydelime obe cislo a zaokrouhlime
    double mezisoucet = cislo1 / cislo2;
    int vysledek = round(mezisoucet);

    return vysledek;
}

int Average()
{
    // Inicializujeme a deklarujeme si pole
    int pole[] = { 3, 1, 5, 2, 6, 1, 7, 2 };

    // Promenne
    int iterace = 7;
    int nejvetsi = 0;
    int druheNejvetsi = 0;
    int tretiNejvetsi = 0;
    int akt = 0;
    int mezisoucet = 0;
    double vysledek = 0.0;

    // Prochod polem
    for (int i = 0; i <= iterace; i = i + 1)
    {
        // Nastavime si aktualni hodnotu do promenne
        akt = pole[i];

        // Zalogujeme si aktualni mezisoucet
        mezisoucet = mezisoucet + akt;
        //printf("----------- Zacatek ------------\n");
        //printf("akt: %d\n", akt);
        //printf("Nejvetsi: %d\n", nejvetsi);
        //printf("Druhe nejvetsi: %d\n", druheNejvetsi);
        //printf("Treti nejvetsi: %d\n", tretiNejvetsi);

        // Nejprve si overime, zda jsme nenarazili na nejvetsi cislo
        if (nejvetsi < akt)
        {
            // Poud ano, postupne 'setreseme' hodnoty o uroven nize
            tretiNejvetsi = druheNejvetsi;
            druheNejvetsi = nejvetsi;
            nejvetsi = akt;
        }
        // Overime si, zda nemame druhe nejvetsi cislo
        if (druheNejvetsi < akt && nejvetsi > akt)
        {
            // Pokud ano, opet 'setreseme'
            tretiNejvetsi = druheNejvetsi;
            druheNejvetsi = akt;
        }
        // Nakonec si overime, zda nemame treti nejvetsi cislo
        if (tretiNejvetsi < akt && druheNejvetsi > akt && nejvetsi > akt)
        {
            // Pokud ano, nastavime
            tretiNejvetsi = akt;
        }

        //printf("----------- Konec ------------\n");
        //printf("Nejvetsi: %d\n", nejvetsi);
        //printf("Druhe nejvetsi: %d\n", druheNejvetsi);
    }
    // Vypocteme prumer
    vysledek = mezisoucet / iterace;
    printf("Prumer: %d/%d=%2.2f\n", mezisoucet, iterace, vysledek);

    printf("Treti nejvetsi: %d\n", tretiNejvetsi);

    // Navratovou hodnotu nechceme
    return 0;
}

int main()
{
    Average();
    return 0;
}