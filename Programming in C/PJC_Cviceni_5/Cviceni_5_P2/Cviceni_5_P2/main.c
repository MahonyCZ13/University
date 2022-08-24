//
//  main.c
//  Cviceni_5_P2
//
//  Created by Maronek, Petr on 23.08.2022.
//

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// NENI MOJE Tvorba
int compare (const void * a, const void * b) {
   return strcasecmp( *(char**)a, *(char**)b );
}

int main(int argc, char * argv[]) {
    int n;
    argv++;
    argc--;
    
    
    printf("Vypis pred setridenim: \n");
       for( n = 0 ; n < argc; n++ ) {
          printf("%s ", argv[n]);
       }
        qsort((void *)argv, (size_t)argc, sizeof(char*), compare);
    
    printf("Vypis po setridenim: \n");
       for( n = 0 ; n < argc; n++ ) {
          printf("%s ", argv[n]);
       }
    

    return 0;
}
