// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat
// VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;
using System.IO;

// Příklad 8.1 Náhodný binární soubor
// Napište funkci, která vytvoří binární soubor obsahující zadaný počet
// náhodných kladných celých čísel. [2 body].

namespace priklad1
{
    class Program
    {
        static void NahodnySoubor(string soubor, int velikost)
        {
            // Inicializujeme si metody pro praci s binarnim souborem.
            FileStream fs = new FileStream(soubor, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            
            // Inicializujeme si metodu pro generovani nahodnych cisel
            Random r = new Random();
            
            // Pomocne promenne
            int i = 1, nahodneCislo;
            
            // Nastavime velikost souboru
            bw.Write(velikost);
            
            while(i <= velikost)
            {
                // Vygenerujeme nahodne kladne cislo
                nahodneCislo = r.Next();
                
                // Cislo zapiseme do souboru
                bw.Write(nahodneCislo);
                
                // Ikrementujeme ridici promennou
                i++;
            }
            
            // Zavreme soubor
            bw.Close();
        }
        static void Main(string[] args)
        {
            string soubor = "cisla.dat";
            NahodnySoubor(soubor, 1000);
        }
    }
}
