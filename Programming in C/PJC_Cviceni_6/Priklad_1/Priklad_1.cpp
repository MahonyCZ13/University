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
#define _CRT_SECURE_NO_DEPRECATE
#include<stdio.h>
#include<malloc.h>
#include <stdlib.h>
#include <string.h>
/******  Prvni pokus  ********/
/*
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
    printf("\nA[2][3] = %d\n", matice[a][&b]);

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
*/

int alocateMatrix(int m, int n)
{
    // Alokace matice
    int(*matice)[m][n];
    matice = (int(*)[m][n])calloc(m * n, sizeof(int));
    return (*matice)[m][n];
}

int saveToMatrix(int x, int y)
{
    int success = 0;

    //(*matice)[x][y] = success;

    return success;
}

int nsn(int x, int y, int nsd)
{
    int vysledek = x / nsd * y;
    return vysledek;
}

int nsd(int x, int y)
{
    if (y == 0) return x;
    return nsd(y, x % y);
}

void ErrorHandler(int ex)
{
    switch (ex)
    {
    case 10: printf("Parametr -f je povinny. Zadejte cestu k textovemu souboru, ktery chcete zpracovat.\n");
    case 11: printf("Chyba pri otevirani souboru. Pouzijte parametry kompilatoru pro vetsi podrobnosti.\n");
    default: printf("Genericka chyba. Vyuzijte vystupu na konzoli.\n");
    }
}

int main(int argc, char* argv[])
{
    char* path;
    int pnsn = 0;
    int pnsd = 0;

    // Promenne pro zpracovani prikazove radky
    char* d[] = { 0 };
    char* t[] = { 0 };
    int m = 0;
    int n = 0;

    /*
    Vstup od uzivatele
    printf("Zadejte prvni cislo:\n");
    scanf("%d", &m);
    printf("Zadejte druhe cislo:\n");
    scanf("%d", &n);
    */

    // Zpracujeme aurgumenty prikazove radky

    //while (*++argv && **argv == '-')
    while (*argv)
    {
        printf("%s\n", argv[1]);
        switch (argv[0][1])
        {
        case 'f': path = argv[1]; break;
        case 's': pnsn = 1; break;
        case 'd': pnsd = 1; break;
        case 'n': t = argv[1]; break;
        case 'm': d = argv[1]; break;
            //default: ErrorHandler(10);
        }
        argv++;
    }

    /*
    while (*argv){
        printf("%s\n", *argv);
        if(strcmp(*argv, "-nsn")) pnsn = 1;
        argv++;
    }
     */

     // Konverze char do int.
    m = d[0] - '0';
    if (strlen(t) != 0) n = t[0] - '0';
    else n = m;

    printf("NSN: %d\n", pnsn);
    printf("NSD: %d\n", pnsd);
    printf("var_m: %d\n", m);
    printf("var_n: %d\n", n);

    // Pointer na fci

    /*
    int (* fce)(int a, int b);
    fce = saveToMatrix;

    int ju = fce(9, 5);

    printf("%d\n", ju);
    */


    int(*matice)[m][n];
    matice = (int(*)[m][n])calloc(m * n, sizeof(int));

    // Naplneni matice
    /*
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++)
            (*matice)[i][j] = i*10+j;
    }
    */
    for (int i = 0; i < n * m; i++)
        (*matice)[i / n][i % n] = i + 1;
    //(*matice)[i/n][i%n] = i + 1;

// Inicializace promennych pro testovani
    int x = 6;
    int y = 7;
    int a = 105;
    int b = 30;

    // NSN a NSD
    //int nsdVysledek = nsd(a, b);
    //int nsnVysledek = nsn(a,b, nsdVysledek);

    // Ulozeni vysledku NSD do matice na souradnice
    //(*matice)[x][y] = nsdVysledek;

    // Vypis pouze jednoho elemtu na obrazovku
    //int element = (*matice)[x][y];

    // Prace cse souborem
    FILE* soubor;

    if (!(soubor = fopen(path, "w"))) ErrorHandler(11);

    // Vypocet usporadanych dvojic

//    if(pnsn == 1)
//    {
//        for (int i = 0; i < m; i++) {
//            for (int j = 0; j < n; j++)
//                int nsdVysledek = nsd((*matice)[i], (*matice)[j]);
//                printf("NSN pro usporadanou dvojici %d a %d je %d ", (*matice)[i], (*matice)[j], (*matice)[i][j]));
//            printf("\n");
//        }
//    }
    else if (pnsd == 1)
    {
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++)
                printf("%d ", (*matice)[i][j]);
            printf("\n");
        }
    }
    else printf("Neni zadane nic ke spocitani\n");


    // Vypis matice na obrazovku
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++)
            printf("%d ", (*matice)[i][j]);
        printf("\n");
    }

    // Vypis matice do souboru
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++)
            fprintf(soubor, "%d ", (*matice)[i][j]);
        fprintf(soubor, "\n");
    }

    // Zavreni souboru
    fclose(soubor);

    // Vystup pro jediny element
    //printf("%d\n", element);

    // Uvolneni pameti
    free(*matice);

    return 0;
}