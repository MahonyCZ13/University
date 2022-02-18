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
#include <stdlib.h>

void removeChar(char* s, char c)
{

    int j;
    size_t n = strlen(s);
    for (int i = j = 0; i < n; i++)
        if (s[i] != c)
            s[j++] = s[i];

    s[j] = '\0';
}

void swap(char* x, char* y)
{
    char temp = *x;
    *x = *y;
    *y = temp;
}

void permutation(char* a, int l, int r)
{
    int i;

    if (l == r)
        printf("%s\n", a);
    else
    {
        for (i = l; i <= r; i++)
        {
            swap((a + l), (a + i));
            permutation(a, l + 1, r);
            swap((a + l), (a + i));
        }
    }
}

void arrayMove(char* pole, int l, int r)
{

    int i, j = 1;
    size_t n = strnlen_s(pole, 20);

    for (i = 0; i <= r + 1; i++)
    {
        char subBuff[5];
        strcpy_s(subBuff, pole);
        if (n != r + 1)
        {
            while (j != r)
            {
                removeChar(subBuff, pole[j]);
                j++;
            }
        }
        permutation(subBuff, l, r);
    }
}

int main()
{
    char pole[] = "TGCA";
    int x = 3;

    arrayMove(pole, 0, x - 1);

    return 0;
}