/*
 * =====================================================================================
 *
 *       Filename:  odmocnina.h
 *
 *    Description:  
 *
 *        Remarks:  Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
 *                  Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
 *                  Nikdo me pri vypracovani neradil
 *                  Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
 *                  NENI MOJE TVORBA
 *                  Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
 *                  Petr Maronek, 36456
 *        Version:  1.0
 *        Created:  12/02/2021 09:48:55 PM
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  Petr Maronek, 36456 
 *   Organization:  VSFS
 *
 * =====================================================================================
 */

#include <stdio.h>
#include <math.h>

double Odmocnina(double cislo1)
{
    printf("===== Druha odmocnina! =====\n\n");
    if(cislo1 == 0)
    {
        printf("Zadejte prvni cislici:\n");
        scanf("%lf", &cislo1);
    }
    else
    {
        printf("Cislo 1 je jiz zadane vysledek z predchoziho prikladu.\n");
    }

    double vysledek = sqrt(cislo1);
    return vysledek;
}
