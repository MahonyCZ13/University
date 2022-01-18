/*
 * =====================================================================================
 *
 *       Filename:  priklad_3.c
 *
 *    Description:  Napište program, který ze standardního vstupu čte tak dlouho text, dokud není zadáno písmeno X. 
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
 *        Created:  12/01/2021 10:33:45 PM
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  Petr Maronek, 36456 
 *   Organization:  VSFS
 *
 * =====================================================================================
 */

#include <stdio.h>
#include <stdbool.h>

int main()
{
    printf("Zadejte vstupni data:\n");

    // Inicializace promennych
    char input;
    bool magicKey = true;
    
    // Pouzijeme do-while cyklus
    do
    {
        // Cteme od uzivatele
        scanf("%c", &input);
        
        // Pokud uzivatel zada 'x', nastavime bool promennou na false
        // a z cyklu vyskocime
        if(input == 'x'){
            magicKey=false;
            printf("Uzivatel zadal 'x'. Koncime!");
        }
    }
    while(magicKey);

    return 0;
}

