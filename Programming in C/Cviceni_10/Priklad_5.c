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

// https://www.geeksforgeeks.org/write-a-function-to-get-nth-node-in-a-linked-list/
// https://github.com/oi8io/clang/blob/master/example/linkedlist.c

#include<stdio.h>
#include<stdlib.h>
typedef struct prvek
{
    int n;
    struct prvek *next;
} PRVEK;

void addLast(struct prvek **prvni, int hodnota)
{
    struct prvek *novaData = malloc(sizeof(struct prvek));

    novaData->n = hodnota;
    novaData->next;

    if(*prvni == NULL) *prvni = novaData;
    else {
        struct prvek *posledniPrvek = *prvni;
        while(posledniPrvek->next != NULL)
        {
            posledniPrvek = posledniPrvek->next;
        }
        posledniPrvek->next = novaData;
    } 
}

int main()
{
    
    int i, pocet = 5;

    PRVEK *p_akt, *p_prvni, *p_pos;

    // Inicializace Seznamu
    if((p_prvni = (PRVEK *) malloc(sizeof(PRVEK))) == NULL)
        printf("Malo pameti\n");
 
    p_akt = p_prvni;
    p_prvni->n = 1;

    // Naplneni Seznamu
    for (i = 2; i <= pocet; i++)
    {
        if((p_akt->next = (PRVEK *) malloc(sizeof(PRVEK))) == NULL)
        {
            printf("Malo pameti\n");
            break;
        }
        
        p_akt = p_akt->next;
        p_akt->n = i;
        
    }
    
    // Vypis pred Pop
    for(p_akt = p_prvni; p_akt != NULL; p_akt = p_akt->next)
    {
        printf("%d \n", p_akt->n);
    }

    // Pop
    struct prvek *temp = p_prvni;
    p_prvni = p_prvni->next;
    
    printf("--------------\n");
    printf("\nVymazana hodnota:\n");
    printf("%d\n", temp->n);
    printf("--------------\n");
    
    
    // Vypis po Pop
    for(p_akt = p_prvni; p_akt != NULL; p_akt = p_akt->next)
    {
        
        printf("%d \n", p_akt->n);
    }
    
    
    // Push
    struct prvek *novaData = malloc(sizeof(struct prvek));
    int hodnota = 13;

    novaData->n = hodnota;
    novaData->next;

    if(p_prvni == NULL) p_prvni = novaData;
    else {
        struct prvek *posledniPrvek = p_prvni;
        while(posledniPrvek->next != NULL)
        {
            posledniPrvek = posledniPrvek->next;
        }
        posledniPrvek->next = novaData;
    }
    printf("--------------\n");
    
    // Vypis po Push
    for(p_akt = p_prvni; p_akt != NULL; p_akt = p_akt->next)
    {    
        printf("%d \n", p_akt->n);
    }

    return 0;
}