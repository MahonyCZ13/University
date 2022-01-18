﻿// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;
using System.Diagnostics;

// Příklad 5.6 Vylepšený Bubble Sort
// Algoritmus Bubble Sort třídící sestupně zadané pole lze implementovat ve dvou verzích. V základní verzi algoritmu se ve vnořeném cyklu 
// prochází pole až do posledního prvku.  Ve vylepšené verzi algoritmu se ve vnořeném cyklu prochází pole jen do místa poslední výměny, 
// která proběhla v předchozí iteraci vnějšího cyklu. 
// a) Napište vylepšenou verzi Bubble sortu. Pokud jste vylepšenou verzi napsali již v příklad 5.3c, napište nyní verzi základní. [2 body]
// b) Změřte (dle příkladu 5.4) počty operací a dobu běhu vylepšené a základní verze. [1 bod]

namespace priklad6
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
        // Standardni BubbleSort
        static void BubbleSort(int[] pole)
		{
			int i;
			bool operace = true;

			while(operace)
			{
				operace = false;
				for(i = 1; i < pole.Length; i++)
				{
					if(pole[i] > pole[i-1])
					{
						Prohod(ref pole[i], ref pole[i-1]);
						operace = true;
					}
				}
			}
			VypisPole(pole);
		}
        // Tato funkce je pouzita v priklad3
		static void BetterBubbleSort(int[] pole)
		{
			int i, posledniVymena = 0;
			bool operace = true;

			while(operace)
			{
				operace = false;
				for(i = 1; i<pole.Length; i++)
				{
					if(i == posledniVymena) break;
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
            int[] pole = { 2, 9, 1, 7, 6, 4, 1, 0, 5, 3 };
            int[] pole2 = { 2, 9, 1, 7, 6, 4, 1, 0, 5, 3 };
            
            Stopwatch mereni = new Stopwatch();
									
			mereni.Start();
			BubbleSort(pole);
			mereni.Stop();
			Console.WriteLine("Vysledek pro BubbleSort funkci: {0} ms / {1} tiku", mereni.ElapsedMilliseconds, mereni.ElapsedTicks);
			mereni.Reset();

			mereni.Start();
			BetterBubbleSort(pole2);
			mereni.Stop();
			Console.WriteLine("Vysledek pro BetterBubbleSort funkci: {0} ms / {1} tiku", mereni.ElapsedMilliseconds, mereni.ElapsedTicks);
			mereni.Reset();
            
            Console.ReadLine();
        }
    }
}
