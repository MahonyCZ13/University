// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat
// VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

// Příklad 6.2: Třídící algoritmy
// Napište následující třídící algoritmy pro sestupné setřídění zadaného vstupního pole:
// b) heapsort implementovaný pomocí pole [4 body]

using System;
namespace HeapSort
{
    class Priklad2
    {
        // HeapSort - sestupne trideni
        public static int[] HeapSort(int[] pole)
        {
            // Nastavime si velikost pole, kde budeme kontrolovat,
            // zda neni pole prazdne nebo setridene
            int velikost = pole.Length;

            // Prerovname pole tak, abychom meli haldu s nejmensim prvkem na zacatku
            // Tridime sestupne
            for (int i = (velikost - 1) / 2; i >= 0; i--)
            {
                Heapify(pole, velikost, i);
            }
            
            // Nyni muzeme pole konvertovane do haldy
            for (int j = pole.Length - 1; j > 0; j--)
            {
                // Prehodime koren nakonec, protoze je po Heapify nejmensi
                // a tudiz setrideny
                Prohod(ref pole[j], ref pole[0]);
                
                // Snizime velikost pole, kvuli jiz setridenim prvkum
                velikost--;

                // Volame opet Heapify. Index resetujeme na 0, protoz
                // jsme v poslednim cyklu jiz prochazene prvky setridili
                Heapify(pole, velikost, 0);
            }
            return pole;
        }

        public static void Heapify(int[] pole, int velikost, int index)
        {
            // Zjistime si pozice leveho a praveho syna
            int leva = index * 2 + 1;
            int prava = index * 2 + 2;

            // Jako nejmensiho z nich si nastavime otce
            int nejmensi = index;

            // Pokud je levy syn mensi nez otec, nastavime nejmensi hodnotu
            // podstromu na hodnotu leveho syna
            if (leva < velikost && pole[leva] < pole[index]) nejmensi = leva;

            // Jinak ji nastavime na soucasnou prochazebou hodnotu
            else nejmensi = index;

            // Pokud je pravy syn mensi nez otec, nastavime nejmensi hodnotu
            // podstromu na hodnotu praveho syna. Tato hodnota je nyni nejmensi
            // v danem podstromu
            if (prava < velikost && pole[prava] < pole[nejmensi]) nejmensi = prava;

            // Pokud neni soucasna hodnota stajne jako otec
            if (nejmensi != index)
            {
                // Prohodime v podstromu nejmensi hodnotu se soucasnou
                Prohod(ref pole[index], ref pole[nejmensi]);

                // Rekurzivne tridime soucasny podstrom
                Heapify(pole, velikost, nejmensi);
            }
        }

        // Vymenna promennych
        static void Prohod(ref int x, ref int y)
        {
            int poleB;
            poleB = x;
            x = y;
            y = poleB;
        }
        // Vypis pole do konzole
        static void VypisPole(int[] pole)
        {
            int i;
            for (i = 0; i < pole.Length; i++)
                Console.Write(pole[i] + " ");
        }

        // Metoda pro vygenerovani nahodneho pole
        static int[] GenerateArray(int arrayLength)
        {
            int[] pole = new int[arrayLength];
            Random r = new Random();
            int i;

            for (i = 0; i < pole.Length; i++)
                pole[i] = r.Next(100);

            return pole;
        }
        static void Main(string[] args)
        {
            int[] pole = GenerateArray(10);

            Console.WriteLine("Vstupni pole:");
            VypisPole(pole);
            Console.WriteLine("\n\nHeapSort:");

            VypisPole(HeapSort(pole));
            Console.ReadLine();
        }
    }
}

