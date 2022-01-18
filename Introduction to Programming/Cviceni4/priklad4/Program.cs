// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

// Příklad 4.4: Obrácení pole
// Napište funkci, která v zadaném poli obrátí pořadí prvků. První prvek bude posledním, druhý prvek předposledním, atd. Je zakázáno použít pomocné pole. [3 body]

namespace priklad4
{
    class Program
    {
        static void VypisPole(int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                Console.WriteLine(pole[i]);
            }
        }
        static void ProhodPole(int[] pole)
        {
            int i, posledniPozice, prvniPozice;
            int arrayLength = pole.Length - 1;

            Console.WriteLine("Vstupni pole:");
            VypisPole(pole);
            
            // Zde delku pole vydelime 2, protoze v jedne iteraci osetrime obe
            // strany pole a postupujeme smerem ke stredu
            for (i = 0; i < (pole.Length) / 2; i++)
            {
                // v prvni iteraci manualne nastavime posledni pozici
                if (i == 0) posledniPozice = arrayLength;
                
                // Posledni neosetrena pozice je vzdy delka pole ponizena o
                // index pole aktualniho.
                posledniPozice = arrayLength - i;
                prvniPozice = i;
                
                // Zde si nastavime pomocne pormenne pro prohozeni hodnot
                int prvni = pole[prvniPozice];
                int posledni = pole[posledniPozice];
        
                // A nastavime hodnoty
                pole[prvniPozice] = posledni;
                pole[posledniPozice] = prvni;


            }

            Console.WriteLine("---------------------\nVystupni pole:");
            VypisPole(pole);

        }
        static void Main(string[] args)
        {

            int[] mojePole = {0, 2, 3, 7, 8, 9, 1 };

            ProhodPole(mojePole);

            Console.ReadLine();

        }
    }
}
