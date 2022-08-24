/*
 * =====================================================================================
 *
 *       Filename:  priklad_š.c
 *
 *    Description:  Napište program, který umí zpracovat následující parametry a v případně vypíše, co je špatně zadáno: -a číslo [-b řetězec [číslo1 číslo2]] [-c | -d] file1 file2
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


#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>

int main(int argc, char* argv[]) {
    
    char* a;
    char* b;
    char* c;
    char* d;
    while (*argv)
    {
        //printf("%s\n", argv[1]);
        switch (argv[0][1])
        {
            case 'a': a = argv[1]; break;
            case 'b': b = argv[1]; break;
            case 'c': c = argv[1]; break;
            case 'd': d = argv[1]; break;
            //default: ErrorHandler(10);
        }
        argv++;
    }
    
    if(!isdigit(a[0])) printf("%s neni cislo!\n", a);
    
    if(((int)strlen(b)) < 1) printf("%s neni retezec!\n", b);
    
    // Prace se souborem
    FILE *soubor;
    FILE *soubor2;
    
    if(!(soubor = fopen(c, "r"))) printf("Argument C neni soubor\n");
    else fclose(soubor);
    if(!(soubor2 = fopen(d, "r"))) printf("Argument D neni soubor\n");
    else fclose(soubor);
    
    
    //printf("Done\n");
    return 0;
}
