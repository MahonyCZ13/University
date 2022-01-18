// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

namespace priklad5
{
    class Program
    {
        static void Main(string[] args)
        {
        
        	// Příklad 2.5: Nejmenší společný násobek
			// Uživatel zadá dvě čísla z klávesnice. Vypište jejich nejmenší společný násobek. 
			// Nejmenší společný násobek čísel x a y je nejmenší číslo n takové, že x dělí n beze 
			// zbytku a zároveň y dělí n beze zbytku. Nápověda: využijte Euklidův algoritmus, který 
			// nalezne největšího společného dělitele. [3 body]
            
            Console.WriteLine("Zadejte prvni cislo:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte druhe cislo:");
            int y = Convert.ToInt32(Console.ReadLine());
            // Protoze by program prepsal hodnoty 'x'' a 'y', musime si je ulozit do
            // dalsich promennych, protoze je budeme po vypoctu nsd opet potrebovat
            int tempX = x;
            int tempY = y;
            
            // Inicializace a deklarace promenne pro zbytek po vypoctu nsd
            int zbytek = 0;
            
            // Eukliduv algoritmus pro vypocet nsd, ktery potrebujeme pro zjisteni nsn
            // Dokud se nejmesi z cisel nerovna 0, pokracujeme ve vypoctu. Hodnota
            // 'y' bude vzdy mensi cislo
            while(y != 0)
            {
            	// Zde ukladame zbytek po deleni
            	zbytek = x % y;
            	// Protoze vzdy pocitame vesi cislo deleno mensim cislem, musime zde promenne
            	// prohodit, je pro algoritmus nezbyte, abych delili vzdy vetsi cislo mensim.
            	x = y;
            	// Hodnotu 'y' nastavime na mensi cislo ('zbytek') 
            	y = zbytek;
            }
            
            // Zde na zaklade Euklidova algoritmu vypocteme nsn pomoci vzorce n1 * n2 / nsd
            
            int vysledek = tempX * tempY / x;
            
            Console.WriteLine("Nejmensi spolecny nasobek cisel {0} a {1} je {2}.", tempX, tempY, vysledek);
            Console.ReadLine();
            
        }
    }
}
