/*
 * =====================================================================================
 *
 *       Filename:  priklad_1.c
 *
 *    Description:  Napište program, který obrátí začátek a konec souboru. Obrátí se pořadí všech znaků v souboru, celý soubor bude pozpátku.  Parametry programu: -i input. Velikost souboru může být větší než vaše RAM a dokonce i větší než 1/2 disku.        
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

int main()
{
    FILE* myFile;
    int c;

    if( !(myFile = fopen("test.txt", "r"))) error();
    
    while((c = getc( myFile)) != EOF) putchar(c);
    
    fclose(myFile);
    
    return 0;
}