//
//  main.c
//  Cviceni_5_P3
//
//  Created by Maronek, Petr on 23.08.2022.
//

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
