﻿// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

// Dochází k přetečení. Tedy odpověď D nebo E.

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int iMax = int.MaxValue;

            for(int i = int.MaxValue - 10; i <= int.MaxValue; i++)
            {
                j++;
                //Console.WriteLine(j);
            }
            Console.WriteLine(j);

        }
    }
}