// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// // Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// // Nikdo me pri vypracovani neradil
// // Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// // NENI MOJE TVORBA
// // Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// // Petr Maronek, 36456

using System;

namespace Sandbox
{
    class Program
    {
        static void VypisPole(int[] pole)
        {
            int i;
            Console.WriteLine("------------------");
            for (i = 0; i < pole.Length; i++)
                Console.WriteLine(pole[i]);
        }
        static void Prohod(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void SelectionSort(int[] pole)
        {
            int i, j, min;

            for(i = 0; i < pole.Length; i++)
            {
                min = i;
                for (j = i; j < pole.Length; j++)
                    if (pole[j] < pole[min])
                        min = j;

                Prohod(ref pole[min], ref pole[i]);
            }
        }
        static void InsertionSort(int[] pole)
        {
            int i, j, akt;

            for(i = 1; i < pole.Length; i++)
            {
                akt = pole[i];
                for (j = i; (j > 0) && (pole[j - 1] > akt); j--)
                    pole[j] = pole[j - 1];
                pole[j] = akt;
            }
        }
        static void BubbleSort(int[] pole)
        {
            int i;
            bool vymena = true;

            while (vymena)
            {
                vymena = false;
                for(i = 1; i < pole.Length; i++)
                    if(pole[i] < pole[i - 1])
                    {
                        Prohod(ref pole[i], ref pole[i - 1]);
                        vymena = true;
                    }
            }          
        }
        static void CountingSort(int[] pole)
        {
            int i, j, max = -1;
            int[] hodnoty;

            for (i = 0; i < pole.Length; i++)
                if (pole[i] > max) max = pole[i];

            hodnoty = new int[max + 1];

            for (i = 0; i < pole.Length; i++)
                hodnoty[pole[i]]++;

            i = 0; 
            j = 0;

            while(i < pole.Length)
            {
                if (hodnoty[j] > 0)
                {
                    hodnoty[j]--;
                    pole[i] = j;
                    i++;
                }
                else j++;
            }
        }
        static int BinaryFind(int[] pole, int hodnota)
        {
            int stred, levy = 0, pravy = pole.Length - 1;
           
            while (levy <= pravy)
            {
                stred = (levy + pravy) / 2;
                if (pole[stred] == hodnota) return stred;
                else if (pole[stred] < hodnota) levy = stred + 1;
                else pravy = stred - 1; 
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] pole = { 2, 9, 1, 7, 6, 4, 1, 0, 5, 3 };
            int hledane = 5;

            Console.WriteLine("Puvodni pole:");
            VypisPole(pole);

            // Selection sort
            Console.WriteLine("SelectionSort:");
            SelectionSort(pole);
            VypisPole(pole);

            // Reset pole
            int[] pole2 = { 2, 9, 1, 7, 6, 4, 1, 0, 5, 3 };

            // Insertion sort
            Console.WriteLine("InsertionSort:");
            InsertionSort(pole2);
            VypisPole(pole2);

            // Reset pole
            int[] pole3 = { 2, 9, 1, 7, 6, 4, 1, 0, 5, 3 };

            // Bubble sort
            Console.WriteLine("BubbleSort:");
            BubbleSort(pole3);
            VypisPole(pole3);

            // Reset pole
            int[] pole4 = { 2, 9, 1, 7, 6, 4, 1, 0, 5, 3 };

            // Counting sort
            Console.WriteLine("Counting Sort:");
            CountingSort(pole4);
            VypisPole(pole4);

            // Binary Find
            Console.WriteLine("Binary Find:");
            int poziceHodnoty = BinaryFind(pole, hledane);

            Console.WriteLine("Hodnata {0} nalezena na pozici {1}", hledane, poziceHodnoty);

            Console.ReadLine();
        }
    }
}
