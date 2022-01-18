// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

namespace Priklad_1
{
    class Program
    {
        // Nadprumerna mzda
        static void Main(string[] args)
        {
            // Pocet zamenstnancu
            Console.WriteLine("Zadejte pocet zamestancu (pouze cislo):");
            int pocet_zamcu = Convert.ToInt32(Console.ReadLine());

            // Inisicalizace pole
            int[] mzdy = new int[pocet_zamcu];
            
            // Pridani mezd do pole
            for(int i = 0; i <= pocet_zamcu - 1; i++)
            {
                Console.WriteLine("Mzda cislo {0}: ", i + 1);
                int mzda = Convert.ToInt32(Console.ReadLine());
                mzdy[i] = mzda;
            }

            // Vypocet prumerne mzdy
            int avarage = 0, soucet = 0;
            
            foreach (int castka in mzdy)
            {
                soucet += castka;
                avarage = soucet / pocet_zamcu;
            }
            
            // Vypis naprumenrnych mezd
            Console.WriteLine("\nNadprumerne mzdy (prumerna mzda {0}):\n", avarage);
            foreach (int mzda in mzdy)
            {
               
                if(mzda >= avarage)
                    Console.WriteLine(mzda);
            }
            Console.ReadLine();
        }
    }
}
