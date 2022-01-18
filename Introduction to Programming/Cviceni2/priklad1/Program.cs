// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

namespace priklad1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Příklad 2.1: Dvě čísla sestupně
			// Uživatel zadá dvě čísla z klávesnice. Setřiďte tato číslo ve vnitřní paměti. 
			// Vypište tato čísla setříděná sestupně dle jejich hodnot. [1 bod]
            
            int x, y, temp;
            
            Console.WriteLine("Zadejte prvni cislo: ");
            x = Convert.ToInt32(Console.ReadLine());
            //Konverze muze probehnout i takto:  x = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Zadejte druhe cislo: ");
            y = Convert.ToInt32(Console.ReadLine());            
            
            // Overime si, zda je y vetsi nez x. Pokud ano, musime obe hodnoty prohodit
            // Pokud ne, poracujeme dal na vypis vystupu na obrazovku
            if(x < y)
            {
            	// Nejprve si musime ulozit hodnotu y do docasne promenne
            	// kvuli prepsani promenne y
            	temp = y;
            	
            	// Protoze je hodnota x mensi nez y, musime hodnotu y prenastavit na hodnotu x
            	// abychom dosahli sestupnosti
            	y = x;
            	
            	// Nyni nastavime hdnotu x hodnotou z promenne temp, do ktere jsme si ulozili
            	// vetsi hodnotu na zacatku podminky
            	x = temp;
            } 
            
            
            Console.WriteLine("Cesla serazena sestupne: {0}, {1}", x, y);
            Console.ReadLine();
            
            // OTAZKA: Muzeme zde pouzit 'Console.ReadKey()' misto ReadLine?
            
        }
    }
}
