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

// Příklad 8.3 Součet čísel na řádku
// Napište funkci, která ze zadaného textového souboru obsahujícího celá čísla
// vytvoří nový textový soubor, který bude na každém řádku obsahovat součet
// čísel z odpovídajícího řádku původního souboru.  Nápověda: na součet použijte
// datový typ long. [3 body]

namespace priklad3
{
    class Program
    {
        static void SoucetCisel(string zdroj, string cil)
        {
            // Inicializujeme si metody pro cteni a zapis souboru
            StreamReader sr = new StreamReader(zdroj);
            StreamWriter sw = new StreamWriter(cil);
            
            // Pripravime si pomocne promenne
            int i = 0, akt;
            long soucet;
            string s;
            string[] buffer = new string[9];

            // Precteme kazdy radek ze souboru cisla.txt
            while((s = sr.ReadLine()) != null)
            {
                // Vynulujeme si promennou soucet pro kazdou iteraci
                soucet = 0;

                // Protoze jsou cisla na kazdem radku oddelena mezerou,
                // vyuzijeme toho naplnime si pomocne pole 10 cisly ze 
                // radku (stale jako string)  
                buffer = s.Split(" ", 10);
                
                // Nyni budeme pomocnym polem iterovat pro kazde cislo
                for(i = 0; i < buffer.Length; i++)
                {
                    // Aktualni cislo zkonvertujeme na opravdove cislo
                    akt = Convert.ToInt32(buffer[i]);

                    // Pricteme cislo do promenne soucet
                    soucet = soucet + akt;
                }

                // Zapiseme vysledek do souboru a odradkujeme
                sw.WriteLine(soucet);

            }

            // Zavreme oba soubory
            sr.Close();
            sw.Close(); 
        }
        static void Main(string[] args)
        {
            string soubor = "cisla.txt";
            string soucet = "soucet.txt";
            SoucetCisel(soubor, soucet);
        }
    }
}
