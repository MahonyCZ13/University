/*
 * =====================================================================================
 *
 *       Filename:  priklad_1.c
 *
 *    Description:  Napište program, který obrátí začátek a konec souboru. Obrátí se pořadí všech znaků v souboru, celý soubor bude pozpátku.  Parametry programu: -i input. Velikost souboru může být větší než vaše RAM a dokonce i větší než 1/2 disku.
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
#include<stdlib.h>
 
void ErrorHandler(int ex)
{
    switch (ex)
    {
    case 10: printf("Parametr -i je povinny. Zadejte cestu k textovemu souboru, ktery chcete zpracovat.\n");
    case 11: printf("Chyba pri otevirani souboru. Pouzijte parametry kompilatoru pro vetsi podrobnosti.\n");
    default: printf("Genericka chyba. Vyuzijte vystupu na konzoli.\n");
    }
}

void ProcessFile(char* path)
{
    FILE* myFile;
    int c;
    char* fileContent = (char *) malloc(555);
    long length = 0;
    char c1;
    int i = 1;
    int j = 0;

    // Overime si dostupnost souboru. Pokud selze, posleme si vlastni chybu
    if (!(myFile = fopen(path, "r"))) ErrorHandler(11);

    printf("Originalni string: \n");

    // Iterujeme celym souborem znak po znaku
    while ((c1 = fgetc(myFile)) != EOF)
    {
        fileContent[i] = c1;
        printf("%c", c1);
        length += 1;
        i = i + 1;
    }
    printf("\nObraceny string:\n");
    j = length;

    // Nyni vypiseme soubor na obrazovku
    for (i = 0; i <= length; i++)
    {
        printf("%c", fileContent[j]);
        j--;
    }
    printf("\n");
}
int main(int argc, char** argv)
{
    char* path{};

    // Zpracujeme aurgumenty prikazove radky
    while (*++argv && **argv == '-')
    {
        switch (argv[0][1])
        {
        case 'i': path = argv[1]; break;
        default: ErrorHandler(10);
        }
    }

    if (path == NULL) return 0;
    else ProcessFile(path);

    return 0;
}