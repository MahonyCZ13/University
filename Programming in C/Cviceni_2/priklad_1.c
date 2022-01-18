/*
 * =====================================================================================
 *
 *       Filename:  priklad_1.c
 *
 *    Description:  Napište program malá násobilka z přednášky pomocí for cyklu. 
 *        
 *        Remarks:  Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
 *                  Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
 *                  Nikdo me pri vypracovani neradil
 *                  Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
 *                  NENI MOJE TVORBA
 *                  Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
 *                  Petr Maronek, 36456
 *
 *        Version:  1.0
 *        Created:  12/01/2021 09:13:04 PM
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  Petr Maronek, 36456 
 *   Organization:  VSFS
 *
 * =====================================================================================
 */

#include <stdio.h>

int main()
{
    printf("Mala nasobilka\n");

    // Inicializace promennych
    int i, j, k;

    // Vnejsi cyklus 
    for(i=1; i<=10; i++)
    {
        // Vnitrni cyklus
        for(j=1; j<=10; j++)
        {
            // Vypocet
            k = i*j;

            // Vystup vysledku na konzoli
            printf("%d*%d = %d\n", i, j, k);
        }
    }

    return 0;
}

