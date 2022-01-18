/*
 * =====================================================================================
 *
 *       Filename:  priklad_2.c
 *
 *    Description:  Napište program, který pro daný měsíc (stačí jen do září) v roce zadaný číslem vypíše jeho název. 
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
 *        Created:  12/01/2021 09:45:00 PM
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
    printf("Zadejte mesic (1-12):\n");
    
    // Inicializace promenne
    int mesic;
    
    // Precteme od uzivatele vstup a ulozime do promenne 'mesic' pomoci pointeru
    scanf("%d", &mesic);

    // Pomoci SWITCH funkce rozpozname mesic
    switch(mesic)
    {
        case 1:
            printf("Leden.\n");
            break;
        case 2:
            printf("Unor\n");
            break;
        case 3:
            printf("Brezen\n");
            break;
        case 4:
            printf("Duben\n");
            break;
        case 5:
            printf("Kveten\n");
            break;
        case 6:
            printf("Cerven\n");
            break;
        case 7:
            printf("Cervenec\n");
            break;
        case 8:
            printf("Srpen\n");
            break;
        case 9:
            printf("Zari\n");
            break;
        case 10:
            printf("Rijen\n");
            break;
        case 11:
            printf("Listopad\n");
            break;
        case 12:
            printf("Prosinec\n");
            break;
        default:
            printf("Tento mesic neznam :'(\n");
            break;
    }
    
    return 0;
}

