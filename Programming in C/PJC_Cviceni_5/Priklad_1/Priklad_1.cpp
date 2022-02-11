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
 // Funkce na delku retezce
int custom_strlen(char* pole)
{
    // Inicializace a deklarace promennych
    int i = 0;
    int valid = 1;

    while (valid == 1)
    {
        // Pomoci valid promenne, kontrolujeme konec pole
        if (pole[i] == '\000')
        {
            // Pokud na nej narazime, cyklus ukoncime
            valid = 0;
            break;
        }
        // Pokud ne, pokracujeme v pruchodu a zvedame iteracni promennou
        i = i + 1;
    }

    // Vratime delku retezce
    return i;
}

int main()
{

    char* pozdrav = "Hello!!";
    int length = custom_strlen(pozdrav);

    printf("Delka pole je %d\n", length);
    return 0;
}