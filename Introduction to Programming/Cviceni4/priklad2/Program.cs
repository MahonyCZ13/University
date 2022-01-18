// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

// Příklad 4.2: Absolutní hodnota pole
// Napište funkci, která v zadaném poli nahradí hodnoty jednotlivých prvků pole jejich absolutní hodnotou. [1 bod]

namespace priklad2
{
    class Program
    {
        // Tuto funkci pouzivam ve vsech resenich, kde pracuji s poli. Jde jen o
        // vypis pole do konzole z duvodu kontroly nebo zpetne vazby uzivateli.
        static void VypisPole(int[] pole)
        {
            for(int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine(pole[i]);
            }
        }
        
        static void AbsolutniHodnotaPole(int[] pole)
        {
            // inicializace ridici promenne
            int i;
            
            // Vypis puvodniho pole pro kontrolu
            Console.WriteLine("Vstupni pole:");
            VypisPole(pole);
            
            for(i = 0; i < pole.Length; i++)
            {
                // Pokud je aktualni hodnota v poli mensi nez 0, vynasobime ji
                // -1, abychom dostali jeji absolutni hodnotu.
                if(pole[i] < 0)
                {
                    pole[i] = pole[i] * -1;
                }
            }
            
            // Vypis vysledneho pole do konzole
            Console.WriteLine("---------------------\nVystupni pole:");
            VypisPole(pole);
        }
        static void Main(string[] args)
        {

            int[] mojePole = { 3, -7, 8, 20, -9, 87, -100, 92, 0};

            AbsolutniHodnotaPole(mojePole);

            Console.ReadLine();
        }
    }
}
