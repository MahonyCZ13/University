// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci 
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody 
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem 
// NENI MOJE TVORBA 
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat 
// VYLOUCENIM ZE STUDIA 
// Petr Maronek, 36456 

using System; 

// *a) Napište funkci, která pro zadaný uzel binárního stromu vrátí jeho strýce. [2 body]* 
// b) Napište funkci, která pro zadaný uzel vypíše celou cestu od kořene k tomuto uzlu. [2 body] 
// d) Napište funkci Insert, která do binárního vyhledávacího stromu vloží prvek se zadanou hodnotou. Příklad byl předveden na přednášce, proto není hodnocen. [0 bodů] 
// g) Napište funkci, která vypíše binární vyhledávací strom jako sestupně setříděnou posloupnost hodnot jeho uzlů. [3 body] 

namespace Priklad2 
{ 
    class Strom 
    { 
        public int data; 
        public Strom left; 
        public Strom right; 
    } 

    class Program 
    { 
        // NENI MOJE TVORBA 
        static Strom Create(int n) 
        { 
            Strom s = new Strom(); 
            s.data = n; 
            s.left = null; 
            s.right = null; 

            return s; 
        } 

        // NENI MOJE TVORBA 
        static Strom InsertInto(Strom snew, int item) 
        { 
            Strom akt = snew; 
            Strom tmp = Create(item); 

            if (snew == null) return tmp; 

            while (akt != null) 
            { 
                if (akt.data == item) return snew; 
                if (item < akt.data) 
                { 
                    if (akt.left == null) 
                    { 
                        akt.left = tmp; 
                        return snew; 
                    } 
                    else akt = akt.left; 
                } 
                else 
                { 
                    if (akt.right == null) 
                    { 
                        akt.right = tmp; 
                        return snew; 
                    } 
                    else akt = akt.right; 
                } 
            } 
            return snew; 
        } 

        // NENI MOJE TVORBA 
        static Strom ConvertArray(int[] pole) 
        { 
            Strom s = null; 
            int i; 

            for (i = 0; i < pole.Length; i++) 
            {  
                s = InsertInto(s, pole[i]); 
            } 
             return s; 
        } 
        // Zobrazi strom v konzoli v danem formatu
        static void PrintTree(Strom s, int hloubka, string side) 
        { 
            Strom akt = s; 
            int i;

            // Pokud je aktualni hodnota ve strome prazdna, koncime
            if (akt == null) return; 
            
            // Akce pro zobrazeni stromu do konzole s hloubkou a stranou
            for(i = 0; i < hloubka; i++) 
            { 
                Console.Write("{0} | ", side); 
            }
            
            // Vytiskneme radek do konzole
            Console.WriteLine(akt.data); 

            // Rekurzivne pokracujeme pro pravou i levou stranu
            PrintTree(akt.left, hloubka + 1, "l"); 
            PrintTree(akt.right, hloubka + 1, "r"); 
        } 

        // NENI MOJE TVORBA 
        static Strom Find(Strom s, int target) 
        { 
            Strom akt = s; 

            while (akt != null) 
            { 
                if (akt.data == target) return akt; 
                if (target < akt.data) akt = akt.left; 
                else akt = akt.right; 
            } 
            return null; 
        } 
        
        // ZATIM NEDOKONCENE
        static Strom FindUncle(Strom s, int nephew) 
        { 
            Strom akt = s; 
            Strom uncle = null; 

            while(akt != null) 
            { 
                if (akt.right.right.data == nephew || akt.right.left.data == nephew) 
                { 
                    if (akt.left != null) uncle = akt.left; 
                } 
                else uncle = null; 

                if (akt.left.right.data == nephew || akt.left.left.data == nephew) 
                { 
                    if (akt.right != null) uncle = akt.right; 
                } 
                else uncle = null; 

                if (akt.data == nephew) return uncle; 
                if (nephew < akt.data) akt = akt.left; 
                else akt = akt.right; 
            } 
            return uncle; 
        } 
        // Zobrazi cestu k danemu prvku
        static Strom PrintPath(Strom s, int target) 
        { 
            Strom akt = s; 
            Strom path = null; 

            while (akt != null) 
            {
                // Pokud narazime na cilovy prvek, iniciujeme metodu k zobrazeni cesty v konzoli
                if (akt.data == target) 
                { 
                    path = InsertInto(path, akt.data); 
                    PrintTree(path, 0, "koren"); 
                }
                // Pokud jsme narazili na prvek mensi, nez otcovska noda, pridame do naseho stromu a pokracujeme vlevo.
                if (target < akt.data) 
                { 
                    path = InsertInto(path, akt.data); 
                    akt = akt.left; 
                }
                // V opacnem pripade to same, ale pokracujeme vpravo. 
                else  
                {
                    path = InsertInto(path, akt.data); 
                    akt = akt.right; 
                } 
            }
            // Indikace konce stromu
            Console.WriteLine("End of path"); 

            return path; 
        } 
        // Setridi Nody sestupne
        static void NodeSort(Strom s) 
        {
            Strom akt = s; 
            
            if (akt == null) return; 

            // Protoze potrebujeme strom setridit sestupne, nejprve rekurzivne osetrujeme pravou stranu...
			
			// Zakomentovane overeni, zda se nejedna o list
            // Overime si, zda se nejedna o list.   
            // if (akt.right.right != null) 
            NodeSort(akt.right); 

            Console.Write(akt.data + " "); 

            // ... a pote tu levou
            // if (akt.left.left != null) 
            NodeSort(akt.left);             
        } 

        static void Main(string[] args) 
        { 
            int target = 89; 
            int[] pole = { 23, 45, 67, 85, 21, 98, 47, 51, 35, 76, 109, 43, 25, 89 }; 
            Strom s1 = ConvertArray(pole); 

            PrintTree(s1, 0, "koren"); 

            Console.WriteLine("\nPrint Path for item {0}\n", target); 
            PrintPath(s1, target); 

            Console.WriteLine("\nNode Sort:\n"); 
            NodeSort(s1); 

            // Console.WriteLine("\n\nFind Uncle:\n"); 
            // Strom result = FindUncle(s1, target); 
            // Console.WriteLine(result.data); 

            Console.ReadLine(); 
        } 
    } 
} 
