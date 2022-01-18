/*
 * =====================================================================================
 *
 *       Filename:  priklad_1.c
 *
 *    Description:  Implementujte některé ze standardních knihovních funkcí pro práci s řetězci: strlen, strcpy, strcat, strcmp, ...        
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

#include<stdio.h>

int custom_strlen(char* pole)
{
    int i = 0;
    int valid = 1;

    while(valid == 1)
    {

        if(pole[i] == '\000')
        {
            valid = 0; 
            break;
        }
        //printf("%c\n", pole[i]);
        i = i + 1;
    }
    return i;
}

int main()
{

    char* pozdrav = "Hello!!";
    int length = custom_strlen(pozdrav);

    printf("Delka pole je %d\n", length);
    return 0;
}
