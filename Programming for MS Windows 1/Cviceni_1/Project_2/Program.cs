// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

namespace Project_2
{
    // Kód končí: 0, protože 'f' bude vždy menší, kvůli podmínce 'f < START + 50'.
    // Tedy odpověď C.
    class Program
    {
        static void Main(string[] args)
        {
            int START = 2000000000;
            int count = 0;
            for (float f = START; f < START + 50; f++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}