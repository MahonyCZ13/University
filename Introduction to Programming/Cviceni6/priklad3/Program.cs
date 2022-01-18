// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456                     

using System;

// Příklad 6.3 Naše vlastní řetězce
// Napište funkce pracující s polem znaků char[], které budou mít stejnou
// funkčnost jako funkce pro textové řetězce string. (Aniž byste pole znaků
// char[], na textový řetězec string převedli).
// a) Funkce lexikografického porovnání řetězců s1 a s2: Compare(s1, s2). [2
// body]
// b) Funkce vracející index prvního výskytu hledaného řetězce s2 v řetězci s1.
// Řetězec s1 se prohledává od zadané pozice start: IndexOf(s1, s2, start). [2
// body]
// c) Funkce vracející podřetězec zadaného řetězce s1. Podřetězec začíná na
// zadané pozici a má zadanou délku: Substring(s1, start, delka). [1 bod]
// d) Funkce vracející řetězec vzniklý vložením řetězce s2 do řetězce s1 na
// pozici zadanou indexem: Insert(s1, index, s2). [2 body]
// e) Funkce vracející řetězec vzniklý odstraněním podřetězce ze zadaného
// řetězce s1. Z řetězce s1 se odstraní podřetězec určený indexem (v rámci
// řetězce s1) svého prvního znaku a svojí délkou: Remove(s1, index, delka). [2
// body]
// f) Funkce vracející řetězec vzniklý z řetězce s1 nahrazením všech výskytů
// řetězce s2 za řetězec s3: Replace (s1, s2, s3). [4 body]

namespace priklad3
{
    class Program
    {
        static int Compare(char[] s1, char[] s2)
        {

            int i = 0, vysledek = 0, delkaPole;
            bool rovna = true;
            
            // Overeni pro nastaeni spravne delky pole
            if(s1.Length > s2.Length) delkaPole = s1.Length;
            else delkaPole = s2.Length;
            
            // Pokud jsou si znaky rovny a zaroven ridici promenna i je mensi,
            // nez porovnavane pole
            while(rovna && (i < delkaPole))
            {

                rovna = false;
                
                // break zde pouzijeme, abychom nemuseli prochazet zbytek pole
                if(s1[i] > s2[i])
                {
                    vysledek = 1;
                    break;
                }
                else if(s1[i] < s2[i])
                {
                    vysledek = -1;
                    break;
                }
                else rovna = true;
                
                i++;
            }
            
            return vysledek;
        }

        static int IndexOf(char[] s1, char[] s2, int start)
        {
            // Zde nastavime pozici na -1 jako vychozi hodnotu pro pripad, ze
            // hledany znak nenalezneme
            int pozice = -1, i = start;
            bool nalezeno = false;
            
            // Pracujeme s boolean hodnotou false dokud nenajdeme vysledek.
            // Abychom se vyhnuli nekonecnemu cyklu, pouzijeme ridici promennou
            // cyklu 'i'
            while(nalezeno == false && i < s1.Length)
            {
                if(s1[i] == s2[0])
                {
                    // Nasli jsme! Ukoncime cyklus nastavenim promene nalezeno
                    // na true
                    pozice = i;
                    nalezeno = true;
                }
               i++; 
            }
            return pozice;
        }
        static char[] Substring(char[] s1, int start, int delka)
        {
            // Nastavime si prazdne pole na vyslednou delku
            char[] vysledek = new char[delka];
            int i;
            
            // Tento cyklus ukoncime po poctu iteraci stanovene delkou
            for(i = 0; i < delka; i++)
            {
                // Dokud je splnena podminka, kompilujeme znaky z pole s1 do
                // pole vysledek. Manualne inkrementujeme i promennou 'start',
                // ktera udava pozici indexu ve zdrojovem poli znaku
                vysledek[i] = s1[start];
                start++; 
            } 

            return vysledek;
        }
        static char[] Insert(char[] s1, int index, char[] s2)
        {

            // Incicializujeme si prazdne pole, ktere odpovida delkou vychoziho
            // pole + znaky z pole druheho
            char[] vysledek = new char[s1.Length + s2.Length];
            int i, j = 0;
            
            // Tento cyklus je nastaven na pocet iteraci podle hodnoty promenne
            // 'index' + delka pole, ze ktereho budeme cerpat.
            for(i = 0; i < index + s2.Length; i++)
            {
                // Pokud je ridici promenna i mensi nez hodnota index,
                // muzeme pridat znaky z pole s1 do pole vysledek dokud
                // nenarazime na start indexu, kde uz budeme vkladat znaky z
                // pole s2
                if(i < index) vysledek[i] = s1[i];
                // Narazili jsme na start indexu, kam mame vlozit znaky z pole
                // s2. Pomoci vnoreneho for cyklu vlozime znaky do pole
                // vysledek.    
                if(i == index) for(j = 0; j < s2.Length; j++) vysledek[j+i] = s2[j];
            }
            
            // Pro lepsi prehled nyni doplnime zbytek znaku z pole s1 na vlozene
            // znaky z pole s2. Ridici promenna i je nastavena na hodnotu indexu
            // + delku pole s2, abych v poli s1 zacali na spravne pozici. tedy
            // az za nove vlozenymi znaky.
            // Cyklus pobezi po dobu delky pole vysledek.
            // Abychom zajistili precteni spravnych znaku z pole s1, musime
            // ridici promennou i ponizit o delku pole s2.
            for(i = index + s2.Length; i < vysledek.Length; i++) vysledek[i] = s1[i - s2.Length];
            
            return vysledek;
        }
        static void Main(string[] args)
        {
            char[] s1 = "klokan".ToCharArray();
            char[] s2 = "klobouk".ToCharArray();
            int i1 = Compare(s1, s2);
            int i2 = IndexOf(s2, "o".ToCharArray(), 3);
            char[] s3 = Substring(s2, 2, 3);
            char[] s4 = Insert(s1, 1, s3);
            Console.WriteLine("Priklad a): {0}\nPriklad b): {1}\nPriklad c): {2},{3},{4}", i1, i2, s3[0], s3[1], s3[2]);
            Console.WriteLine("Priklad d): {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}",s4[0],s4[1],s4[2],s4[3],s4[4],s4[5],s4[6],s4[7], s4[8]); 
            Console.ReadLine();
        }
    }
}
