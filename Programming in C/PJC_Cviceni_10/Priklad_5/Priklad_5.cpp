/*
 * =====================================================================================
 *
 *       Filename:  priklad_1.c
 *
 *    Description:  Napište zásobník, implementujte funkce Push a Pop.
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
typedef struct prvek
{
    int n;
    struct prvek* next;
} PRVEK;

void Push(struct prvek** prvni, int hodnota)
{
    // Inicializace noveho seznamu
    struct prvek* novaData = malloc(sizeof(struct prvek));

    // Naplneni noveho seznamu prvni hodnotou
    novaData->n = hodnota;
    novaData->next;

    // Pokud seznam neexistuje (tedy jeho prvni prvek), vytvorime
    if (*prvni == NULL) *prvni = novaData;
    // Pokud ano, nejdeme posledni prvek v seznamu a za nej
    // pridame prvek novy (tedy na konec fronty)
    else {
        struct prvek* posledniPrvek = *prvni;
        while (posledniPrvek->next != NULL)
        {
            posledniPrvek = posledniPrvek->next;
        }
        posledniPrvek->next = novaData;
    }
}

int main()
{

    int i, pocet = 5;

    PRVEK* p_akt, * p_prvni, * p_pos;

    // Inicializace Seznamu
    if ((p_prvni = (PRVEK*)malloc(sizeof(PRVEK))) == NULL)
        printf("Malo pameti\n");

    p_akt = p_prvni;
    p_prvni->n = 1;

    // Naplneni Seznamu
    for (i = 2; i <= pocet; i++)
    {
        if ((p_akt->next = (PRVEK*)malloc(sizeof(PRVEK))) == NULL)
        {
            printf("Malo pameti\n");
            break;
        }

        p_akt = p_akt->next;
        p_akt->n = i;

    }

    printf("------ Vypis pred Pop -------\n");
    for (p_akt = p_prvni; p_akt != NULL; p_akt = p_akt->next)
    {
        printf("%d \n", p_akt->n);
    }
    printf("\n");

    // ******** Pop ********
    // Inicializujeme si novy seznam jako docasnou promennou
    struct prvek* temp = p_prvni;
    // Posuneme koren seznamu o jednu hodnotu dal
    // a tim efektivne vymazeme referenci puvodni prvni hodnoty
    p_prvni = p_prvni->next;

    printf("------ Vypis po Pop -------\n");
    printf("\nVymazana hodnota:\n");
    // Docasnou promennou nyni pouzijeme jako zpetnou vazbu,
    // Kterou hodnotu jsme z fronty odebrali
    printf("((( %d )))\n\n", temp->n);
    printf("------ Aktualni fronta -------\n");

    // Uvolnime pamet
    free(temp);

    // Vypis po Pop
    for (p_akt = p_prvni; p_akt != NULL; p_akt = p_akt->next)
    {
        printf("%d \n", p_akt->n);
    }

    printf("\n");

    // ******** Push ********
    // Inicializace noveho seznamu
    struct prvek* novaData = malloc(sizeof(struct prvek));
    int hodnota = 13;

    // Naplneni noveho seznamu prvni hodnotou
    novaData->n = hodnota;
    novaData->next;

    // Pokud seznam neexistuje (tedy jeho prvni prvek), vytvorime
    if (p_prvni == NULL) p_prvni = novaData;
    // Pokud ano, nejdeme posledni prvek v seznamu a za nej
    // pridame prvek novy (tedy na konec fronty)
    else {
        struct prvek* posledniPrvek = p_prvni;
        while (posledniPrvek->next != NULL)
        {
            posledniPrvek = posledniPrvek->next;
        }
        posledniPrvek->next = novaData;
    }

    printf("------ Vypis po Push -------\n");

    // Vypis po Push
    for (p_akt = p_prvni; p_akt != NULL; p_akt = p_akt->next)
    {
        printf("%d \n", p_akt->n);
    }
    printf("\n");
    return 0;
}