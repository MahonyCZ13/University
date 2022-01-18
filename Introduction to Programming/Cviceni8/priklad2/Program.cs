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

// Příklad 8.2 Převod binárního souboru na textový 
// Napište funkci, která ze zadaného binárního souboru obsahujícího kladné celá
// čísla vytvoří textový soubor, který bude na každém řádku obsahovat 10 čísel.
// Nápověda: počet čísel v souboru zjistíte z jeho délky. [3 body].

namespace priklad2
{
    class Program
    {
        static void BinarniNaTextovy(string zdroj, string cil)
        {
            // Pripravime si soubory pro praci. Protoze se jedna o binarni
            // soubor, ze ktereho budeme cist, inicializujeme si i metodu
            // FileStream
            FileStream fs = new FileStream(zdroj, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            StreamWriter sw = new StreamWriter(cil);
            
            // Inicializace pomocnych promennych
            int i, delka;
            
            // Zjistime si delku souboru
            delka = br.ReadInt32();
            
            for(i = 1; i <= delka; i++)
            {
                // Precteme cislo z binarniho souboru a zapiseme do textoveho
                // souboru. Pridame mezeru pro oddeleni jednotlivych cisel.
                sw.Write(br.ReadInt32() + " ");
                
                // Po 10 iteracich (tedy po 10 cislech) odradkujeme
                if(i % 10 == 0) sw.Write("\n");
            }
            
            // Zavreme oba soubory
            br.Close();
            sw.Close();
        }
        static void Main(string[] args)
        {
            string bsoubor = "cisla.dat";
            string soubor = "cisla.txt";
            BinarniNaTextovy(bsoubor, soubor);
        }
    }
}
