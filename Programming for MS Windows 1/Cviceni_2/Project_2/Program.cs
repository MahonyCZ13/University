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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zvolte si cislo a hrajte! (od 1 do 5):\n");

            string tip = Console.ReadLine();
            int tipNum = Convert.ToInt32(tip);

            // Zde by si hodil nejlepe switch, ale cviceni je na else if

            if(tipNum == 1)
            {
                Console.WriteLine("Vyhra je kolo!");
            }
            else if(tipNum == 2)
            {
                Console.WriteLine("Vyhrl je zajezd!");
            }
            else if(tipNum == 3)
            {
                Console.WriteLine("Vyhra je zmrzka!");
            }
            else if(tipNum == 4)
            {
                Console.WriteLine("Vyhra je auto!");
            }
            else if(tipNum == 5)
            {
                Console.WriteLine("Vyhra je lizatko!");
            }
            else
            {
                Console.WriteLine("Spatne cislo! Koncime...");
            }
        }
    }
}