﻿// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

namespace sandbox1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -5, y = 4;
            int xAbs = Abs(x);
            
            
            
            Console.WriteLine("Vysledek: {0}", OvereniVstupu());
            
            
            Console.WriteLine("Absolutni hodnota cisla {0} je {1}", x, xAbs);
            Console.WriteLine("Absolutni hodnota cisla {0} je {1}", y, Abs(y));
            Console.ReadLine();
        }
        
        static int Abs(int hodnota)
        {
        	if(hodnota < 0) return -hodnota;
        	else return hodnota;
        }
        
        static bool OvereniVstupu()
        {
        
        	bool overeni = false;
        	
        	while (overeni == false)
        	{
        		Console.WriteLine("Napiset jedno ze tri slov (kamen, nuzky, papir): ");
            	string vstup = Console.ReadLine();
            	
        		if(vstup == "kamen" || vstup == "nuzky" || vstup == "papir")
        		{
        			overeni = true;
        			break;        			
        		}
        		else
        		{
        			Console.WriteLine("Tento vstup je neplatny!");
        			overeni = false;        			
        		}       		        	
        	}
        	
        	return overeni;
        
        }
    }
}
