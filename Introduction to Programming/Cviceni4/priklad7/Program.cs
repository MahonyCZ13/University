// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

// Příklad 4.7: Skalární součin
// Napište funkci, která spočte skalární součin dvou stejně dlouhých vektorů. Vektor o n složkách je reprezentovaný pomocí pole délky n. 
// Skalární součin pro dva vektory délky n se počítá jako součet n součinů. 
// Jednotlivé součiny vzniknou vynásobením odpovídajících složek prvního a druhého vektoru [2 body].

namespace Priklad7
{
    class Program
    {
        // do fuknce si nacteme 2 pole o stejnem rozmeru
        static void SkalarniSoucin(int[] poleA, int[] poleB)
        {
            int i, vysledek = 0;
            
            for(i = 0; i < poleA.Length; i++)
            {   
                // Vlastni vypocet. vynasobime hodnoty na aktualni pozici pro
                // obe pole a pricteme vysledek z minle iterace.
                // Pro prvni iteraci jsme si vysledek nastavili na hodnotu 0.
                vysledek = poleA[i] * poleB[i] + vysledek;             
            }
            Console.WriteLine(vysledek);
        }
        static void Main(string[] args)
        {

            int[] poleU = { 2, 5, -2, 4, 1 };
            int[] poleV = { 3, -3, 0, 1, 2 };

            SkalarniSoucin(poleU, poleV);

            Console.ReadLine();
        }
    }
}
