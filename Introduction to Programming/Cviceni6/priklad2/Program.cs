// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

// Příklad 6.2 Césarova šifra
// Césarova šifra je jednou z nejstarších metod pro převod přenášené zprávy do
// zašifrované podoby, která je nečitelná pro neinformovaného útočníka.
// Parametrem šifry je celé číslo nazvané posun. Každé písmeno zprávy je
// zaměněno za písmeno, které se v abecedě nachází za tímto písmenem o počet
// znaků určený hodnotou parametru posun. Původní zprávu získáme aplikací tohoto
// postupu na zašifrovanou zprávu s modifikovaným parametrem posun. Hodnota
// parametru posun bude mít oproti původní hodnotě tohoto parametru opačné
// znaménko. 
//
// a) Implementujte funkci pro zašifrování textového řetězce pomocí této šifry.
// Pro jednoduchost nezkoumejte, co jsou písmena a posouvejte celý řetězec. [1
// bod].
// b) Slovně (pomocí komentáře ve zdrojovém kódu) popište postup, kterým byste
// v roli útočníka bez znalosti parametru posun ze zašifrované zprávy získali
// původní zprávu. [2 body]

// Postup pro rozsifrovani bez znalosti parametru pro posun.
//
// Budu predpokladat, ze sifra vychazi s predem dane tabulky symbolu, kde ma
// kazdy znak sve indexove cislo (napr ASCII). Protoze sifrujeme i bile znaky, jako
// jsou mezery, diky nim muzeme vypozorovat, o kolik je puvodni text posunuty.
// Na prikladu nize vidime, ze se az podezrele casto opakuje cislo 4, ktere jak
// se zda oddeluje jednotliva slova. Cislo 4 ma v ASCII tabulce hodnotu 52. Pokud
// budu pracovat s teorii, ze cislo 4 oznacuje mezeru, vsechny znaky ponizim o
// 20 (mezera ma v ASCII tabulce cislo 32). Pokud by tato podezrele opakujici se 
// hodnota byla mensi nez 32 pro mezeru v ASCII, rozdil bych naopak pricital.
// Pokud by tento pristup selhal, hledal bych dale stejne se opakujici
// znaky az bych nasel znak, ktery reprezentuje mezeru mezi slovy. Pokud by byla
// sifra vytvorena bez mezer, hledal bych nejvice se opakujici se znak a zkusil
// bych ho porovnat se samohlaskami, ktere se v textu vyskytuji nejvice
// (napriklad pismeno 'a').

namespace priklad2
{
    class Program
    {
        static string Zasifrovat(string zprava, int posun)
        {
            // Deklarace a inicializace pomocnych a ridich promennych
            string zasifrovanaZprava = "";
            char[] priprava = zprava.ToCharArray();
            int i;
            
            // Precteme kazdy znak v retezci
            for(i = 0; i < priprava.Length; i++)
            {
                // Aktualni hodnotu si nejprve prevedeme na int (zde 16, protoze
                // char ma velikost 16 bitu) a hned navysime jeho hodnotu o
                // posun
                int akt = Convert.ToInt16(priprava[i]) + posun;
                
                // Vyslednou hodnotu povysenou o posun prevedeme zpet do char
                char sifra = Convert.ToChar(akt);
                // Console.WriteLine("{0}: {1} -> {2}: {3}",Convert.ToInt16(priprava[i]), priprava[i], akt, sifra);

                // Pridame vysledny char do retezce
                zasifrovanaZprava = zasifrovanaZprava + sifra;
            }
            
            // Vratime retezec
            return zasifrovanaZprava;
        }
        static void Main(string[] args)
        {
            string dopis = "Toto je tajny text: 1726";
            
            string sifra = Zasifrovat(dopis, 20);
            string odsifrovane = Zasifrovat(sifra, -20);
            Console.WriteLine("Puvodni zprava:\n{0}", dopis);
            Console.WriteLine("Zasifrovano:\n{0}", sifra);
            Console.WriteLine("Odsifrovane:\n{0}", odsifrovane);
            Console.ReadLine();
        }
    }
}
