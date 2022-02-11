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

    int j, n = strlen(s);
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

    int i;
    size_t n = sizeof(pole) / sizeof(pole[0]);

    for (i = 0; i <= n - 1; i++)
    {
        char subBuff[5];
        strcpy_s(subBuff, pole);
        removeChar(subBuff, pole[i]);
        permutation(subBuff, l, r);
    }

    /*char subBuff1[5];
    strcpy_s(subBuff1, pole);
    removeChar(subBuff1, 'T');
    permutation(subBuff1, l, r);
    free(subBuff1);

    char subBuff2[5];
    strcpy_s(subBuff2, pole);
    removeChar(subBuff2, 'G');
    permutation(subBuff2, l, r);
    free(subBuff2);

    char subBuff3[5];
    strcpy_s(subBuff3, pole);
    removeChar(subBuff3, 'C');
    permutation(subBuff3, l, r);
    free(subBuff3);

    char subBuff4[5];
    strcpy_s(subBuff4, pole);
    removeChar(subBuff4, 'A');
    permutation(subBuff4, l, r);
    free(subBuff4);*/

}

int main()
{
    char pole[] = "TGCA";
    int n = 3;

    arrayMove(pole, 0, n - 1);

    return 0;
}