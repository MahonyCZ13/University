/*
 * =====================================================================================
 *
 *       Filename:  priklad_2.c
 *
 *    Description:  2.	Napište program, který pomocí knihovní funkce qsort setřídí řetězce, které mu jsou zadány jako parametry programu. Výstup se vypisuje na obrazovku.
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
 *        Created:  15/01/2021 16:11:04
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  Petr Maronek, 36456
 *   Organization:  VSFS
 *
 * =====================================================================================
 */


#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// NENI MOJE Tvorba
int compare (const void * a, const void * b) {
   return strcasecmp( *(char**)a, *(char**)b );
}

int main(int argc, char * argv[]) {
    int n;
    argv++;
    argc--;
    
    
    printf("Vypis pred setridenim: \n");
       for( n = 0 ; n < argc; n++ ) {
          printf("%s ", argv[n]);
       }
        qsort((void *)argv, (size_t)argc, sizeof(char*), compare);
    
    printf("Vypis po setridenim: \n");
       for( n = 0 ; n < argc; n++ ) {
          printf("%s ", argv[n]);
       }
    

    return 0;
}
