﻿// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techt pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System;

namespace priklad3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Zadejte cislo: ");           
            int uzivatelCislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte mocninu: ");           
            int uzivatelMocnina = Convert.ToInt32(Console.ReadLine());
            double cisloProVyraz = 5.14;
            
            
            Console.WriteLine("{0}! = {1}", uzivatelCislo, Faktorial(uzivatelCislo));
            Console.WriteLine("{0}^{1} = {2}", uzivatelCislo, uzivatelMocnina, Mocnina(uzivatelCislo, uzivatelMocnina));
            Console.WriteLine("n = {0}; sum_(k=0)^(100) (n^k)/k! = {1:N3}", cisloProVyraz,Vyraz(cisloProVyraz));
            Console.ReadLine();
            
        }
 
        static int Faktorial(int cislo)
        {      
        	int i = 1, vysledek = 1;
        	
        	while(i <= cislo)
        	{       	
        		vysledek = vysledek * i;
        		i++;       	
        	}        	
        	return vysledek;       
        }
        
        static double Mocnina(int cislo, int exponent)
        {
        
        	double vysledek = Math.Pow((double)cislo, exponent);
        	return vysledek;
        }
        
        static double Vyraz(double n)
        {

            int limit = 100;
            double vysledek = 0, k = 0, kFaktorial = k;

            while (k <= limit)
            {
                if (k == 0)
                {
                    double mocninaCisla = Math.Pow(n, k);
                    kFaktorial = 1;
                    vysledek = (mocninaCisla / kFaktorial) + vysledek;
                }
                else
                {
                    double mocninaCisla = Math.Pow(n, k);
                    kFaktorial = kFaktorial * k;
                    vysledek = (mocninaCisla / kFaktorial) + vysledek;
                }

                k++;
            }
            return vysledek;
        }
    }
}
