/*
 * =====================================================================================
 *
 *       Filename:  priklad_4.c
 *
 *    Description:  Napište program, který vygeneruje všechny textové řetězce délky X=3 z písmen T G C A.
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
#include <string.h>



void printAllRec(char pole[], char prefix[], int n, int k)
{
    if(k== 0)
    {
        printf("%s", prefix);
    }

    for(int i = 0; i < n; ++i)
    {
        char newPrefix[4];
        strcpy(newPrefix, prefix);
        strcat(newPrefix, pole[i]);

        printAllRec(pole, newPrefix, n, k-1);
    }
}

void cus_printAll(char pole[], int k, int n)
{
    printAllRec(pole, "", n, k);
}
void permute(char *c, int i, int x)
{
    int j;
    if(i == x)
        printf("%s\n", c);
    else
    {
        for(j=1; j <= x; j++)
        {
            swap((c+i), (c+j));
            permute(c, i+1, x);
            swap((c+i), (c+j));
        }
    }
}

void swap(char *x, char *y)
{
    char temp = *x;
    *x = *y;
    *y = temp;
}

int main()
{
    int i,j,k,l,charCounter;
    int x = 3;
    char t = 'T';
    char g = 'G';
    char c = 'C';
    char a = 'A';
    
    char pole[] = {'T', 'G', 'C', 'A'};
    char pole2[] = "TGCA";
    //permute(pole2,0 , x);
    cus_printAll(pole, 2, 3);
    
    return 0;
}
