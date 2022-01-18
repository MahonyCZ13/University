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

// Příklad 1.1: Funkce pro práci s jednosměrným spojovým seznamem celých čísel. 
// Následující funkce napište s optimálním počtem průchodů spojovým seznamem: 
// a) Napište funkci, která uloží spojový seznam do textového souboru. [2 body] 
// b) Napište funkci, která načte z textového souboru spojový seznam, který byl
//    uložen pomocí funkce z příkladu 1.1a. [2 body] 
// c) Napište funkci, která vrátí počet výskytů zadaného prvku ve spojovém seznamu. [2 body]
// e) Napište funkci, která ze spojového seznamu odstraní prvek s nejvyšší hodnotou.
//    Pokud má více prvků stejnou hodnotu, odstraní první z nich. [2 body]

namespace Priklad1
{
    class Seznam 
    {
        public int data;
        public Seznam next;
    }
    class Program
    {
        static void Save(Seznam s, string cil)
        {
            StreamWriter sw = new StreamWriter(cil);
            Seznam akt; 
            
            for(akt = s; akt != null; akt = akt.next)
                if(akt.next == null) sw.Write(akt.data.ToString());
                else sw.Write(akt.data.ToString() + "->");
            
            sw.Close(); 

        }
        
        static Seznam Load(string zdroj)
        {
            StreamReader sr = new StreamReader(zdroj);
            Seznam s; 
            string[] buffer;
            string pruchod;
            int i, n;

            pruchod = sr.ReadLine();
            buffer = pruchod.Split("->");

            int[] pole = new int[buffer.Length];
            
            sr.Close();
            
            for(i = 0; i < buffer.Length; i++)
            {
                n = Convert.ToInt32(buffer[i]);
                pole[i] = n;
            }

            s = ConvertArray(pole);

            return s; 

        }

        static Seznam Create(int c)
        {
            Seznam s = new Seznam();
            s.data = c;
            s.next = null;

            return s;
        }

        static Seznam ConvertArray(int[] pole)
        {
            int i;
            Seznam vys, akt, tmp;

            if(pole.Length == 0) return null;
            vys = akt = null;

            for(i = 0; i < pole.Length; i++)
            {
                tmp = Create(pole[i]);
                if(vys == null) vys = akt = tmp;
                else akt = akt.next = tmp;
            }            
            return vys;
        }
        static int Count(Seznam s, int hledane)
        {
            Seznam akt;
            int count = 0;

            for(akt = s; akt != null; akt = akt.next)
                if(akt.data == hledane) count++;

            return count;
        
        }

        static Seznam FindPrevious(Seznam s, Seznam s2)
        {
            Seznam akt = s;
            
            if(s == null || s2 == null || s == s2) return null;

            while(akt.next != null)
            {
                if(akt.next == s2) return akt;
                akt = akt.next;
            }
            
            return null; 
        }
        static Seznam DeleteLargest(Seznam s)
        {
            Seznam mazane = FindLargest(s);
            Seznam prev = FindPrevious(s, mazane);
            
            if(s == null) return null;
            if(mazane == null) return s;
            if(prev == null) return s.next;

            prev.next = mazane.next;

            return s;
        }

        static Seznam FindLargest(Seznam s)
        {
            Seznam akt = s;
            Seznam largest = s;
            
            while(akt !=null)
            {
                if(largest.data < akt.data) largest.data = akt.data;
                akt = akt.next;
            }

            return largest; 
        }
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
        static void Main(string[] args)
        {
            int[] pole = {1055, 2, 29, 8, 7, 15, 29, 8, 22, 6, 29, 1055 };
            Seznam s1 = ConvertArray(pole);
            PrintList(s1);

            Save(s1, "spojak.txt");
            
            Seznam s2 = Load("spojak.txt"); 
            PrintList(s2);

            int pocet = Count(s1, 29);
            Console.WriteLine(pocet);

            PrintList(DeleteLargest(s1));
            Console.ReadLine();
        }
    }
}
