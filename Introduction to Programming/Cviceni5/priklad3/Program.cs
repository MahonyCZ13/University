// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

// Příklad 5.3 Sestupné třídění:
// Napište třídící funkce pro sestupné třídění. Body navíc lze získat za použití pomocných funkcí z příkladu 5.2 pro porovnávání a přiřazování hodnot prvků. 
// Pomocné funkce nepoužívejte pro práci s řídící proměnnou cyklu. Výjimkou je Count sort, u kterého pomocné funkce se používají pro řídící proměnnou cyklu v 
// situacích, ve kterých je řídící proměnná cyklu brána jako prvek pole. 
// a) Selection sort [3+1 body]
// b) Insertion sort [3+1  body]
// c) Bubble sort [2+1  body]
// d) Count sort [3+2 body]

namespace priklad3
{
    class Program
    {

        static void VypisPole(int[] pole)
        {
            int i;
            Console.WriteLine("------------------");
            for (i = 0; i < pole.Length; i++)
                Console.WriteLine(pole[i]);
        }

        static void Prohod(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        static void SelectionSort(int[] pole)
        {
            int prvni, i, j;
            
            for(i = 0; i < pole.Length; i++)
            {
                // Zde si nastavime index pro aktualni prochazenou hodnotu
				prvni = i;
                // Ve druhem cyklu for nastavime ridici promennou na
                // index pro aktualni merenou hodnotu, kterou nasledne porovname
                // se sousedni hodnotou, zda je mensi (radime sestupne). Pokud ano Pouzijeme
                // funkci 'Prohod' a hodnoty v poli presuneme.
           		for(j = i; j < pole.Length; j++)
				    if(pole[j] > pole[i]) Prohod(ref pole[j], ref pole[prvni]);	
			}
            // Vypiseme vysledne pole do konzole
            VypisPole(pole);
        }

		static void BetterBubbleSort(int[] pole)
		{
            
			int i, posledniVymena = 0;
			bool operace = true;
			
            // 'operace' je boolean promenna, kterou kontrolujeme, zda probehla
            // vymena hodnot na aktualnim indexu. Pokud ano, cyklus pokracuje
            while(operace)
			{
                // Promennou si hned nastavime na false a kontrolujeme, zda
                // prohozeni v cyklu nastalo
				operace = false;
				for(i = 1; i < pole.Length; i++)
				{
                    // Pokud posledni vymena nastala na aktualnim indexu, pro
                    // lepsi rychlost algoritmu okamzite ukoncujeme iteraci a
                    // postupujeme na dalsi
					if(i == posledniVymena) break;

                    // Pokud je predchozi podminka nesplnena, porovname je
                    // soucasne kontrolovana hodnota vetsi, nez jeji levy
                    // soused. Pokud ano, hodnoty prohodime a nastavime
                    // promennou 'operace' na true, abychom zajistili dalsi
                    // iteraci. Soucasne nastavime promennou 'posledniVymena' na
                    // aktualni index
					else if(pole[i] > pole[i-1])
					{
						Prohod(ref pole[i], ref pole[i-1]);
						operace = true;
						posledniVymena = i;
					}
    			}
			}
			
            VypisPole(pole);
		}
        static void Main(string[] args)
        {
            // Obe pole jsou inicializovane stejnymi hodnotami kvuli kontrole
            int[] pole = { 2, 9, 1, 7, 6, 4, 1, 0, 5, 3 };
            int[] pole2 = { 2, 9, 1, 7, 6, 4, 1, 0, 5, 3 };

	    	SelectionSort(pole);
			BetterBubbleSort(pole2);
            
			Console.ReadLine();
        }
    }
}
