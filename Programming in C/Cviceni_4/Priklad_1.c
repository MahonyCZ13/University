/*
 * =====================================================================================
 *
 *       Filename:  priklad_1.c
 *
 *    Description:  Napište program, který setřídí pole. (minimem, bubblesort, margesort, quicksort, ...)        
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

// Funkce na zobrazeni pole do standardniho vystupu
int PrintArray(int pole[], int length)
{
    int i;

    for(i = 0; i < length; i++)
    {
        printf("%d ", pole[i]);
    }
    printf("\n");
    return 0;
}

int BubbleSort(int pole[], int length)
{
    int i, j, temp;

    // Vnejsi cyklus kontroluje cele pole
    for(i = 0; i < length; i++)
    {
        // Vnitrni cyklus kontroluje sousedni prvky pole
        for(j = 0; j < length - i; j++)
        {
            // Pokud je prave prochazeny prvek vetsi nez nasledujici
            // Porohodime
            if(pole[j] > pole[j+1])
            {
                temp = pole[j];
                pole[j] = pole[j+1];
                pole[j+1] = temp;
            }
        }
    }
    return 0;
}

int main()
{
    int pole[] = { 1, 5, 3, 6, 90, 2 };
    int length = sizeof(pole) / sizeof(pole[0]);
    
    PrintArray(pole, length);
    BubbleSort(pole, length);
    PrintArray(pole, length);


    return 0;
}
