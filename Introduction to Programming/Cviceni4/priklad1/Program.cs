// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

// Příklad 4.1: Sestupné setřídění
// Napište funkci, která své dva parametry setřídí sestupně. [1 bod]

namespace priklad1
{
    class Program
    {
        static void SetridSestupne(ref int x, ref int y)
        {
            // Lehce modifikovana verze algoritmu na vymenu hodnot dvou
            // promennych s kontrolou zda je hodnota x mensi, ci vetsi
            int tmp = 0;

            if (x < y)
            {
                tmp = y;
                y = x;
                x = tmp;
            }

        }
        static void Main(string[] args)
        {
            int x = 15;
            int y = 27;

            SetridSestupne(ref x, ref y);

            Console.WriteLine("{0}, {1}", x, y);
            Console.ReadLine();
        }
    }
}
