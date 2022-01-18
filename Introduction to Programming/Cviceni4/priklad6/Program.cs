// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

// Příklad 4.6: Nejčastější prvek.
// Napište funkci, která v zadaném poli najde nejčastěji se vyskytující hodnotu prvku.
// Vyskytují-li se dvě hodnoty stejně často, přednost má první vyskytnuvši se hodnota. [3 body]

namespace Priklad6
{
    class Program
    {
        static int[] NejcastejsiPrvek(int[] prohledavanePole)
        {
            // Protoze chceme vedet, kolikrat se konkretni hodnota vyskytuje v
            // poli, vytvorime si pomocne pole, ktere ulozi jak vyslednou
            // hodnotu, tak jeji pocet vyskytu
            int[] vysledek = new int[2];
            int predchoziPocetVysktu = 0, i;

            for (i = 0; i < prohledavanePole.Length; i++)
            {
                // nastavime si aktualni hledanou hodnotu
                int hledame = prohledavanePole[i];
                // predame vstupni hodnoty funkci, ktera nam vrati pocet vyskytu
                // pro aktualni hodnotu
                int pocetVyskytu = PocetVyskytu(hledame, prohledavanePole);
                
                // overime si, zda se aktualni hodnota vyskytla v poli vicekrat,
                // nez ta predchozi
                if(pocetVyskytu > predchoziPocetVysktu)
                {
                    // Pokud ano, nastavime si aktualni hodnotu jako prvni prvek
                    // pole 'vysledek' a jako druhy prvek si nasavime pocet
                    // vyskytu
                    vysledek[0] = hledame;
                    vysledek[1] = pocetVyskytu;

                    // pro potreby kontroly nastavime aktualni pocet vyskytu pro
                    // dalsi iteraci
                    predchoziPocetVysktu = pocetVyskytu;
                }  
            }
            // vratime vysledek
            return vysledek;
        }
        // Funkce pro pocet vyskytu. diky teto funkci si overime, kolikrat se
        // danna hodnota nachazi v nasem poli
        static int PocetVyskytu(int hledaneCislo, int[] pole)
        {
            int vyskytu = 0, i;

            for(i = 0; i < pole.Length; i++)
            {
                // Pokud najdeme vyskyt v poli, zvysime citaci promennou o jedna
                if (pole[i] == hledaneCislo) vyskytu++;
            }
            
            // vratime vysledek k dalsimu zpracovani
            return vyskytu;
        }
        static void Main(string[] args)
        {
            int[] pole = { 3, 3, 6, 3, 7, 7, 8, 3, 9 , 7, 7, 7, 9, 9, 2 ,2, 2, 2 , 1, 2 };
            int[] vysledek = NejcastejsiPrvek(pole);

            Console.WriteLine("Cislo {0} bylo nalezeno {1}-krat, coz nejvice v danem poli.", vysledek[0], vysledek[1]);
            Console.ReadLine();
        }
    }
}
