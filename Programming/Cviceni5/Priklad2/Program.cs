// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat
// VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

namespace Priklad2
{
    class Program
    {
        // Metoda pro QuickSort pro rozdeleni pole do dvou casti na zaklade promenne 'pivot'
        static int Rozdel(int[] pole, int leva, int prava)
        {
            // Pro prvni iteraci si pro pivot si zvolime posledni prvek pole
            // Dalsi iterace nam pivot dynamicky urci promenna 'j'
            int stred = pole[prava];
            int i;
            // Promenna j nam na konci metody urci, kde se bude nachazet pristi pivot. Promennou nastavujeme
            // na hodnotu -1 kvuli pripadum, kdy for cyklus nize projde bez prohozeni prvku a muze dojit k
            // preskoceni nesestridenych prvku v poli 
            int j = leva - 1;

            for (i = leva; i < prava; i++)
            {
                // Overime, zda je prvek vetsi nez pivot. Pokud ano, inkrementujeme promennou 'j',
                // ktera nam urcuje index setridenych prvku. Zaroven pokud je aktualni prvek mensi
                // nez pivot, podminka se nesplni, promenna 'j' neni inkrementovana a v dalsi iteraci
                // sousedni prvky prohodime.
                if (pole[i] >= stred)
                {
                    j++;
                    // Tato vymena zde jepotreba, kdyby doslo k rozdilum v promennych 'i' a 'j'.
                    Prohod(ref pole[i], ref pole[j]);
                }
            }
            // Pokud je aktualni prvek mensi nez pivot, navzajem je vymenime a tim urcime
            // pivot pro dalsi operaci
            Prohod(ref pole[prava], ref pole[j + 1]);

            return j + 1;
        }

        static void QuickSort(int[] pole, int leva, int prava)
        {
            // Zkontrolujeme hranicni prvky: zda je nejvice levy prvek mensi, nez ten nejvice pravy
            // Hranicnim prvkem rozumime i prvek pivotu (stred - 1 nebo stred + 1)
            if (leva < prava)
            {
                // Tato promenna nam urci, kde bude 'pristi stred'. V Metode Rozdel mame promennou 'j'
                // ktera nam sdeli, po jaky index pole uz mame setrideno. Protoze jsme si zvolili pivot jako
                // posledni prvek pole a tridime sestupne, promenna 'j' a tim i promenna 'stred' se bude 
                // postupne dekrementovat
                int stred = Rozdel(pole, leva, prava);

                // Setridime levou stranu
                QuickSort(pole, leva, stred - 1);
                // Pote pravou
                QuickSort(pole, stred + 1, prava);
            }
        }
        // Metoda na prohozeni hodnot (zjemena v poli)
        static void Prohod(ref int x, ref int y)
        {
            int poleB;
            poleB = x;
            x = y;
            y = poleB;
        }
        // Metoda pro vypis pole do konzole
        static void VypisPole(int[] pole)
        {
            int i;
            for (i = 0; i < pole.Length; i++)
                Console.Write(pole[i] + " ");
        }

        static void MergeSort(int[] pole, int leva, int prava)
        {
            if (leva < prava)
            {
                // Rozdelime pole na dve casti pomoce promenne 'stred' 
                int stred = (leva / 2) + (prava / 2);
                // Setridime levou stranu
                MergeSort(pole, leva, stred);
                // Setridime pravou
                MergeSort(pole, stred + 1, prava);
                // Metoda pro slevani setridenych rozdelenych poli
                Merge(pole, leva, stred, prava);
            }
        }

        private static void Merge(int[] pole, int leva, int stred, int prava)
        {
            // Nastavime si zacatek iteracni promenne za hodnotu indexu, kde uz mame pole setridene
            int i = leva;
            // Nastavime si horni index pole
            int j = stred + 1;
            // Vytvorime si pomocne pole na dynamickou velikost prave prochazenych prvku
            int[] poleB = new int[prava - leva + 1];
            // Promenna pro plneni pomocneho pole
            int k = 0;
            // Promenna pro plneni vstupniho pole
            int l;

            // Kontrola, abychom se udrzeli v hranicich prave prochazenych prvku
            while ((i <= stred) && (j <= prava))
            {
                // Pokud je aktualni prvek vetsi nez horni index, pridame ho 
                // do prvnich indexu pomocneho pole
                if (pole[i] > pole[j])
                {
                    poleB[k] = pole[i];
                    i++;
                }
                else
                {
                    // V opacnem pripade tento horni index
                    poleB[k] = pole[j];
                    j++;
                }
                k++;
            }
            // Pokud se predchozi podminka vyhodnotila do 'else' vetve, pridame zbyvajici prvek za
            // jeho vetsiho souseda. Pokud i tato podminka selze, pridame hodnotu v dalsim if[1]
            if (i <= stred)
            {
                while (i <= stred)
                {
                    poleB[k] = pole[i];
                    i++;
                    k++;
                }
            }
            // [1] 'Cistici' podminka. Pokud nastane situace, kdy je index hodnota shodna s horni hranici,
            // pridame cyklicky tyto prvky do pomocneho pole na posledni mista
            if (j <= prava)
            {
                while (j <= prava)
                {
                    poleB[k] = pole[j];
                    j++;
                    k++;
                }
            }

            // Aktualizujeme pole o setridene prvky a vratime k (pripadnym) dalsim iteracim
            for (l = 0; l < poleB.Length; l++)
            {
                // Zaciname vkladat do pole od poslednich setridenych prvku
                pole[leva + l] = poleB[l];
            }
        }
        // Metoda pro vygenerovani nahodneho pole
        static int[] GenerateArray(int arrayLength)
        {
            int[] pole = new int[arrayLength];
            Random r = new Random();
            int i;

            for(i = 0; i < pole.Length; i++)
                pole[i] = r.Next(1000);

            return pole;
        }
        static void Main()
        {
            int[] mergePole = GenerateArray(20);
            int[] quickPole = GenerateArray(20);
            
            Console.WriteLine("Vstupni pole pro MergeSort:");
            VypisPole(mergePole);

            MergeSort(mergePole, 0, mergePole.Length - 1);
            Console.WriteLine("\n\nMergeSort:");
            VypisPole(mergePole);

            Console.WriteLine("\n\n-------------------------------------");

            Console.WriteLine("\nVstupni pole pro QuickSort:");
            VypisPole(quickPole);

            QuickSort(quickPole, 0, quickPole.Length - 1);
            Console.WriteLine("\n\nQuickSort:");
            VypisPole(quickPole);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
