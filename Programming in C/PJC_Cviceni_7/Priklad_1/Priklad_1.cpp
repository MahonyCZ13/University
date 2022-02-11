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

#include<stdio.h>
#include<stdlib.h>
 // Test Function
 /*
 int DoIt(char* first, char* second, int one, int two)
  {
     printf("%s and %s | %d and %d\n", first, second, one, two);
     return 0;
 }
 */
void ErrorHandler(int ex)
{
    switch (ex)
    {
    case 10: printf("Parametr -i je povinny. Zadejte cestu k textovemu souboru, ktery chcete zpracovat.\n");
    case 11: printf("Chyba pri otevirani souboru. Pouzijte parametry kompilatoru pro vetsi podrobnosti.\n");
    default: printf("Genericka chyba. Vyuzijte vystupu na konzoli.\n");
    }

    //return 0;
}

void ProcessFile(char* path)
{
    FILE* myFile;
    int c;
    char* fileContent;
    long length;
    char c1;
    int i = 0;

    if (!(myFile = fopen(path, "rw"))) ErrorHandler(11);
    /*
    while((c = getc( myFile)) != EOF) fileContent = putchar(c);

    //fclose(myFile);
    if(myFile)
    {

        fseek(myFile, 0 , SEEK_END);
        length = ftell(myFile);
        //fseek(myFile, 0, SEEK_SET);
        fileContent = malloc(length);
        if(fileContent)
        {
            fread(fileContent, 1, length, myFile);
        }
        fclose(myFile);
    }*/

    while ((c1 = fgetc(myFile)) != EOF)
    {
        fileContent[i] = c1;
        printf("%c", c1);
        i = i + 1;
    }

    //printf("%s", fileContent);
}
int main(int argc, char** argv)
{
    char* path;

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
    //DoIt(argv[0], argv[1], w, o);


    return 0;
}