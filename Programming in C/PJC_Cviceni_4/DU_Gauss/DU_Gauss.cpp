/*
 * =====================================================================================
 *
 *       Filename:  Gauss.cpp
 *
 *    Description:  Dobrovolný domácí úkol č. 1: Gaussova eliminační metoda pro pevnou velikost pole.
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
 *        Created:  15/01/2021 09:13:04 PM
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  Petr Maronek, 36456
 *   Organization:  VSFS
 *
 * =====================================================================================
 */

#include<stdio.h>
#include<math.h>
#include<stdlib.h>

int main()
{
	// Inicializujeme si promenne a matice
	double A[10][10], x[10], pomer;
	int i, j, k, n;

	// Zeptame se uzivatele na pocet promennych
	printf("Zadejte mnozstvi promennych:");
	scanf_s("%d", &n);

	// Vyzveme uzivatele k zadani hodnot matice
	printf("Zadejte hodnoty matice:\n");

	// Pouzijeme vnoreny for cyklus kvuli dvou rozmerum
	for (i = 1; i <= n; i++)
	{
		for (j = 1; j <= n + 1; j++)
		{
			printf("a[%d][%d] = ", i, j);
			scanf_s("%lf", &A[i][j]);
		}
	}

	// Gaussova eliminacni metoda
	// Vstoupime do prvni radky
	for (i = 1; i <= n - 1; i++)
	{
		// Musime overit, zda nejsou prvky matice nulove
		if (A[i][i] == 0.0)
		{
			printf("Gaussova eliminacni metoda se na tuto matici neda pouzit.");

			return 0;
		}
		// Vstupime do nasledujici radky
		for (j = i + 1; j <= n; j++)
		{
			// Protoze musime dostat pod diagonalou nulu,
			// pouzijeme pomer nad sebou sousedicich prvku
			// a v dalsim cyklu je matematicky eliminujeme
			// V prvnim cyklu bude mit tak souradnice [2][1]
			// hodnotu 0.
			pomer = A[j][i] / A[i][i];

			for (k = 1; k <= n + 1; k++)
			{
				A[j][k] = A[j][k] - pomer * A[i][k];
			}
		}
	}

	// Ziskani reseni
	// Pole 'x' je pro kolekci reseni jednotlivych rovnic.

	// 
	x[n] = A[n][n + 1] / A[n][n];

	for (i = n - 1; i >= 1; i--)
	{
		x[i] = A[i][n + 1];
		for (j = i + 1; j <= n; j++)
		{
			x[i] = x[i] - A[i][j] * x[j];
		}
		x[i] = x[i] / A[i][i];
	}


	printf("Vyresene rovnice:\n\n");
	for (i = 1; i <= n; i++)
	{
		printf("x[%d] = %0.3lf\n", i, x[i]);
	}

	return(0);
}
