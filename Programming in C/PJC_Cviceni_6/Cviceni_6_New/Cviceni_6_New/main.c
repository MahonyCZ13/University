#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int alocateMatrix(int m, int n)
{
    // Alokace matice
    int (*matice)[m][n];
    matice = (int (*)[m][n])calloc(m*n, sizeof(int));
    return (*matice)[m][n];
}

int nsn(int x, int y, int nsd)
{
    int vysledek = x / nsd * y;
    return vysledek;
}

int nsd(int x, int y)
{
    if(y == 0) return x;
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
    int fileSpecified = 0;
    
    // Promenne pro zpracovani prikazove radky
    char* d = "";
    char* t = "";
    int m = 0;
    int n = 0;
    
    /*
    Vstup od uzivatele - Testovani
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
            case 'f':
                path = argv[1];
                fileSpecified = 1;
                break;
            case 's': pnsn = 1; break;
            case 'd': pnsd = 1; break;
            case 'n': t = argv[1]; break;
            case 'm': d = argv[1]; break;
            //default: ErrorHandler(10);
        }
        argv++;
    }
    
    // Konverze char do int.
    m = d[0] - '0';
    if(strlen(t) != 0) n = t[0] - '0';
    else n = m;
    
    /* Testovani - Vystup
    printf("NSN: %d\n", pnsn);
    printf("NSD: %d\n", pnsd);
    printf("var_m: %d\n", m);
    printf("var_n: %d\n", n);
    */
    int (*matice)[m][n];
    matice = (int (*)[m][n])malloc(m*n * sizeof(int));
    
    // Naplneni matice
    /*
    // OLD
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++)
            (*matice)[i][j] = i*10+j;
    }
    */
    
    for(int i = 0; i < n * m; i++)
    {
        //(*matice)[i/n][i%n] = i + 1;
        (*matice)[i/n][i%n] = rand() % 100;
    }
    // Vypis matice na obrazovku
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++)
            printf("%d ", (*matice)[i][j]);
        printf("\n");
    }
    // Inicializace promennych pro testovani
//    int x = 6;
//    int y = 7;
//    int a = 105;
//    int b = 30;
    
    // NSN a NSD
    //int nsdVysledek = nsd(a, b);
    //int nsnVysledek = nsn(a,b, nsdVysledek);
    
    // Ulozeni vysledku NSD do matice na souradnice
    //(*matice)[m][n] = vysledek;
    
    // Vypis pouze jednoho elemtu na obrazovku
    //int element = (*matice)[x][y];
    
    
    
    // Vypocet usporadanych dvojic
    
    if(pnsn == 1)
    {
        // Pointer na fci
        int (* vypocti)(int x, int y, int z);
        int (* vypoctiNSD)(int x, int y);
        vypoctiNSD = nsd;
        vypocti = nsn;
        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++)
            {
                int previousX = (*matice)[i][j];
                int previousY = (*matice)[j][i];
                int nsdVysledek = vypoctiNSD(previousX, previousY);
                int vysledek = vypocti(previousX, previousY, nsdVysledek);
                (*matice)[i][j] = vysledek;
                printf("NSD pro usporadanou dvojici %d a %d je %d\n", previousX, previousY, (*matice)[i][j]);
            }
            printf("\n");
        }
    }
    else if(pnsd == 1)
    {
        // Pointer na fci
        int (* vypocti)(int x, int y);
        vypocti = nsd;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++)
            {
                int previousX = (*matice)[i][j];
                int previousY = (*matice)[j][i];
                int vysledek = vypocti(previousX, previousY);
                (*matice)[i][j] = vysledek;
                printf("NSD pro usporadanou dvojici %d a %d je %d\n", previousX, previousY, (*matice)[i][j]);
            }
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
    
    if(fileSpecified == 1)
    {
        // Prace cse souborem
        FILE *soubor;
        
        if(!(soubor = fopen(path, "w"))) ErrorHandler(11);
        
        // Vypis matice do souboru
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++)
                fprintf(soubor, "%d ", (*matice)[i][j]);
            fprintf(soubor, "\n");
        }
        
        // Zavreni souboru
        fclose(soubor);
    }
    
    // Uvolneni pameti
    free(*matice);
    
    return 0;
}
