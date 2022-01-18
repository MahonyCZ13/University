// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

namespace Priklad_2
{
    // Mala nasobilka
    class Program
    {
        static void Main(string[] args)
        {
            int max = 10,
            min = 1,
            current = 0;

            for(int i = min; i <= max; i++)
            {
                // Tento vnejsi cyklus osetruje zakladni cislo
                Console.WriteLine("--------{0}--------", i);
                for(int j = min; j <= max; j++)
                {
                    // Tento vnitrni cyklus osetruje cislo, kterym nasobime
                    current = j * i;

                    // Vypiseme pouze licha cisla
                    if(current % 2 != 0)
                        Console.WriteLine(current);
                }
            }
            
        }
    }
}
