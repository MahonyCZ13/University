// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

namespace priklad4
{
    class Program
    {
        static void Main(string[] args)
        {
        	
        	// Příklad 2.4: Faktoriál
			// Uživatel zadá číslo. Vypište faktoriál tohoto čísla. Faktoriál čísla 0 je definován jako 1, 
			// faktoriál pro číslo n>0 je definovaný jako součin všech čísel od 1 do n. Pro záporná čísla není 
			// faktoriál definován. Př.: 6!  = 1*2*3*4*5*6 =720. [1 bod]
        	
            Console.WriteLine("Zadejte cislo:");
            int x = Convert.ToInt32(Console.ReadLine());
            
            // Deklarace a inicializace promennych
            
            // Inkrementacni promenna
            int i = 1;
            
            // Promenna pro ulozeni vysledku
            int faktorial = 1;
            
            // Dokud je hodnota i mensi nebo rovno hodnote x, budeme nasobit
            while(i <= x)
            {
            	// Promenna 'faktorial' je aktualizovana o hodnotu nasobku promenne faktorial 
            	// z posledniho cyklu a inkrementovane promenne 'i'         	
            	faktorial = faktorial * i;
            	
            	// Inkrementace promenne 'i'. Mozno zapsat i takto:
            	// i++;           	
            	i = i + 1;
            }
            
            // Vypsani vysledku do konzole
            Console.WriteLine("Cislo {0}! a vysledek je {1}", x, faktorial);
            Console.ReadLine();
        }
    }
}
