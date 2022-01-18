// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat
// VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

// Příklad 2.3: Funkce pro práci obousměrným spojovým seznamem celých čísel. 
// a) Napište funkci, která ze spojového seznamu odstraní všechny prvky, jejichž hodnota je shodná se zadanou hodnotou. [3 body]
// c) Napište funkci, prvky spojového seznamu uspořádá vzestupně [3 body]
// d) Napište funkci, která ve spojovém seznamu prohodí první prvek a poslední prvek. [2 body]
namespace Priklad3
{
    class Seznam
    {
        public int data;
        public Seznam next;
        public Seznam prev;
    }
    class Program
    {

		static int[] SortAscending(int[] pole)
		{
            
			int i, posledniVymena = 0;
			bool operace = true;
			
            while(operace)
			{
				operace = false;
				for(i = 1; i < pole.Length; i++)
				{
					if(i == posledniVymena) break;

					else if(pole[i] < pole[i-1])
					{
						Prohod(ref pole[i], ref pole[i-1]);
						operace = true;
						posledniVymena = i;
					}
    			}
			}
		    return pole;	
		}

        static void Prohod(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        // NENI MOJe TVORBA
        static Seznam Create(int n)
        {
            Seznam vys = new Seznam();
            vys.data = n;
            vys.next = null;
            vys.next = null;

            return vys;
        }

        //NENI MOJE TVORBA
        static Seznam ConvertArray(int[] pole)
        {
            int i;
            Seznam vys, akt, tmp;

            if(pole.Length == 0) return null;
            vys = akt = null;

            for(i = 0; i < pole.Length; i++)
            {
                tmp = Create(pole[i]);
                tmp.prev = akt;
                if(vys == null) vys = akt = tmp;
                else akt = akt.next = tmp;
            }

            return vys;
              
        }

        // Metoda pro zobrazeni seznamu do konzole
        static void PrintList(Seznam s)
        {
            Seznam akt = s;

            while(akt != null)
            {
                Console.Write(akt.data + " ");
                akt = akt.next;
            }
        
            Console.WriteLine();    
        }

        // Vymaze nejvyssi hodnotu
        static Seznam DeleteItem(Seznam s, int vymaz)
        {
            
            while(s.next != null)
            {
                // Zkontrolujeme, zda jsme na hledanem prvku
                if(s.data == vymaz)
                {
                    // Zkontrolujeme, zda jsme na zacatku Seznamu
                    if(s.prev != null)
                    {
                        // Prelinkujeme aktualni prvek na nasledujici prvek
                        // Tim 'vymazeme' hledany prvek ze seznamu tim, ze
                        // na nej presteneme v Seznamu odkazovat 
                        s.prev.next = s.next;
                        s = s.next;
                    }
                }
                else
                {
                    // Nastavime Predchozi prvek aktualnim prvkem a poskocime vpred
                    s.prev = s;
                    s = s.next;
                }
            }
            return s;
        }

        // Spocita delku Seznamu
        static int SeznamLength(Seznam s)
        {
            Seznam akt = s;
            int delka = 0;
            
            // Jednoducha metoda na spocitani velikosti Seznamu 
            for(akt = s; akt != null; akt = akt.next) delka++;
            
            return delka;
        }

        // Setridi seznam
        static Seznam Sort(Seznam s)
        {
            int i;
            // Vytorime si pole na kterem budeme delat vsechny operace
            int[] pole = new int[SeznamLength(s)];
            Seznam akt = s;

            // Pro vetsi prehled si vytvorime cilovy Seznam
            Seznam vzestupne = new Seznam();
            
            // Prevedeme Seznam zpet na pole
            for(i = 0; i < pole.Length; i++)
            { 
                pole[i] = akt.data;
                akt = akt.next;
            }

            // Pouzijeme tridici algoritmus (BubbleSort v tomto pripade)
            pole = SortAscending(pole);
            
            // Pole konvertujeme zpet do Seznamu
            vzestupne = ConvertArray(pole);

            return vzestupne;
        }

        // Prohodi prvni a posledni prvek
        static Seznam SwapFirstLast(Seznam s)
        {
            
            int i;
            int[] pole = new int[SeznamLength(s)];
            Seznam akt = s;
            Seznam novy = new Seznam();
            
            // Prevedeme si Seznam do pole a na nem budeme delat vsechny operace
            for(i = 0; i < pole.Length; i++)
            {
                pole[i] = Convert.ToInt32(akt.data);
                akt = akt.next;
            }

            // Pouzijeme pomocnou metodu na prohozeni hodnot v poli
            Prohod(ref pole[0], ref pole[pole.Length -1]);
            
            // Konvertujeme zpet do Seznamu
            novy = ConvertArray(pole);
            
            return novy;
        }

        static void Main(string[] args)
        {
            int[] pole = { 1055, 2, 29, 8, 7, 15, 29, 8, 22, 6, 29, 30 };
            Seznam s1 = ConvertArray(pole);
            Console.WriteLine("\n---------------\nVstupni data:");
            PrintList(s1);
            Console.WriteLine("\n---------------\nVzestupne:");
            PrintList(Sort(s1));
            Console.WriteLine("\n---------------\nProhozene prvni a posledni:");
            PrintList(SwapFirstLast(s1));
            Console.WriteLine("\n---------------\nVymazane prvky:");
            DeleteItem(s1, 29);
            PrintList(s1);
            Console.ReadLine();
        }
    }
}
