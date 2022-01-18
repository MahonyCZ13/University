/*
 * =====================================================================================
 *
 *       Filename:  ukol_1.c
 *
 *    Description:  Napište program, který bude s uživatelem komunikovat pomocí
 *                  příkazové řádky a bude počítat +, -, *, /, sin, cos, tan, druhou
 *                  odmocninu. Vždy se zadává pouze číslo nebo operace, není třeba parsovat
 *                  výraz. Program bude pracovat jako obyčejná kalkulačka: uživatel zadá
 *                  jednociferné číslo, pak zadá operaci. V případě funkcí typu "sin" dostane
 *                  výsledek, v případě operátorů typu "+" zadá další jednociferné číslo a
 *                  poté získá výsledek. S výsledkem musí jít dále pracovat, tedy rovnou
 *                  můžeme zadat další operaci. Program se ukončí zadáním operace "Q". 
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
 *        Created:  12/01/2021 09:13:04 PM
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  Petr Maronek, 36456 
 *   Organization:  VSFS
 *
 * =====================================================================================
 */

#include <stdio.h>
#include <stdbool.h>
#include "scitani.h"
#include "odecitani.h"
#include "nasobeni.h"
#include "deleni.h"
#include "sin.h"
#include "cos.h"
#include "tan.h"
#include "odmocnina.h"

// Globalni promenne
double CISLO_1, CISLO_2;

int main()
{
    printf("\n---------- Kalkulacka----------\n\n");
    
    int operace;
    double vysledek;
    bool aktivni = true;

    while(aktivni)
    {
        printf("Zadejte Operaci:\n\n");
        printf("1) scitani (+)\n"); 
        printf("2) odecitani (-)\n"); 
        printf("3) nasobeni (*)\n"); 
        printf("4) deleni (/)\n"); 
        printf("5) sin (sin)\n"); 
        printf("6) cos (cos)\n"); 
        printf("7) tan (tan)\n"); 
        printf("8) druha odmocnina (^1/2)\n");
        //printf("Pro ukonceni stisknete 'Q'\n\n");

        scanf("%d", &operace);
        
        //if(operace == 'q')
        //{
        //    aktivni = false;
        //}

        switch(operace)
        {
            case 1:
                vysledek = Scitani(CISLO_1, CISLO_2);
                CISLO_1 = vysledek;
                break;
            case 2:
                vysledek = Odecitani(CISLO_1, CISLO_2);
                CISLO_1 = vysledek;
                break;
            case 3:
                vysledek = Nasobeni(CISLO_1, CISLO_2);
                CISLO_1 = vysledek;
                break;
            case 4:
                vysledek = Deleni(CISLO_1, CISLO_2);
                CISLO_1 = vysledek;
                break;
            case 5:
                vysledek = Sinus(CISLO_1);
                CISLO_1 = vysledek;
                break;
            case 6:
                vysledek = Cosinus(CISLO_1);
                CISLO_1 = vysledek;
                break;
            case 7:
                vysledek = Tangenc(CISLO_1);
                CISLO_1 = vysledek;
                break;
            case 8:
                vysledek = Odmocnina(CISLO_1);
                CISLO_1 = vysledek;
                break;
            default:
                printf("Tuto operaci neznam :(");
                break;
        }

        printf("\nVysledek vypoctu je: %f\n\n", vysledek);
    } 
    return 0;
}

