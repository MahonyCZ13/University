/*
 * =====================================================================================
 *
 *       Filename:  priklad_1.c
 *
 *    Description:  1. Napište funkci, která alokuje prostor pro matici celých čísel n*m.
 *                  2. Napište funkce, které spočtou nejmenší společný násobek (nsn) a největší společný
 *                  dělitel (nsd) dvou čísel.
 *                  3. Napište funkci, která do každého prvku zadané matice uloží výsledek zadané funkci se
 *                  dvěma parametry typu int vracející int. Parametry funkce jsou x a y a určují pozice
 *                  prvku v matici. Použijte pointry na funkce.
 *                  4. Napište program s parametry "{-nsn | -nsd } [-f output] n [m]", který spočte nsd nebo
 *                  nsn pro všechny uspořádané dvojice čísel [x,y] takových, že x je z 1..n a y je z 1..m.
 *                  Pokud m není zadáno, bude mít stejnou hodnotu jako n.
 *                  5. Obsah matice bude vypsán na obrazovku
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
#include<malloc.h>

int NSD(int* x, int* y)
{
    int i, result = 0;

    for (i = 1; i <= *x && i <= *y; i++)
    {
        if (*x % i == 0 && *y % i == 0)
            result = i;
    }

    return result;
}

int NSN(int* x, int* y, int* nsd)
{
    int result = 0;

    result = (*x * *y / *nsd);

    return result;
}

void saveResult(int* matice, int* n, int* m, int (F)(int* a, int* b))
{
    F = &NSD;

    int result = F(n, m);

    matice[*n][m] = result;

    printf("A[%d][%d] = %d\n\n", *n, *m, matice[*n][m]);

}

int main()
{
    int n = 5, m = 5;
    int i,j;
    
    int* matice = (int*)malloc((n * m) * sizeof(int));

    // Naplneni matice
    for (i = 0; i < n * m; i++)
    {
        matice[i] = i + 1;
    }

    // Vypis matice na obrazovku
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < m; j++)
        {
            int position = i * n + j;
            printf(" %d |", matice[position]);
           
        }
        printf("\n");
    }

    int nsd = NSD(&n, &m);
    printf("\n%d\n", nsd);

    int nsn = NSN(&n, &m, &nsd);
    printf("\n%d\n", nsn);


    saveResult(matice, &n, &m, NSD);
    
    int a = 2;
    int b = 3;
    printf("\nA[2][3] = %d\n", matice[a][b]);

    // Vypis matice na obrazovku
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < m; j++)
        {
            int position = i * n + j;
            printf(" %d |", matice[position]);

        }
        printf("\n");
    }

    return 0;
}