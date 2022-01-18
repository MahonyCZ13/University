// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

namespace priklad6
{
	class Program
	{
		static void Main(string[] args)
		{

			//Příklad 2.6 Prvočísla
			// Vypište všechna prvočísla menší než 1000 [3 body]
			
			// Deklarace a inicializace promennych
			int limit = 100;
            int i = 2;
            bool temp = true;
			
			// Zde pro promennou x nastavime hodnotu '2', protoze 2 je prvni prvocislo a
			// cisla mensi nez 2 prvocisla nejsou
			for(int x = 2; x < limit; x++)
            {
            	// Zde si overime, zda mocnina delitele ('i') neni vetsi nez delenec ('x'),
            	// protoze prvocisla jsou pouze prirozena cisla
            	// pokud ne, musime overit zda je kontrolovane cislo delitelne beze zbytku 
				while(i * i <= x)
				{
					// Zde overime, zda kontrolovana hodnota promenne x je delitelna beze zbytku
					// Pokud ano, nastavime promennou temp na nepravdu, protoze jsem nasli delitele
					// promenne x a pro prvocislo tato podminka neplati
					if(x % i == 0) temp = false;
					
					
					// Inkrementujeme promennou 'i' apokracujeme v overeni
					i = i + 1;
				}
				
				// Vypiseme vysledek do konzole, pokud hodnota temp zustala 'true'
				if(temp)Console.WriteLine(x);
				
				// Resetujeme nastaveni promennych pro dalsi cyklus
				i = 2;
				temp = true;
			
			}
            // Pockame na stisknuti klavesy
			Console.ReadLine();
		}
	}
}
