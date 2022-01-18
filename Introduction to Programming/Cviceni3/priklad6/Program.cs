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
    	
    	enum Predmet
        {
            Kamen = 1,
            Nuzky = 2,
            Papir
        }

        static Predmet VyberUzivatele()
        {
            Predmet p = 0;

            bool overeni = false;
        	string vstup = "";
        	
        	while (overeni == false)
        	{
        		Console.WriteLine("Vyberte si predmet (kamen, nuzky, papir): ");
            	vstup = Console.ReadLine();
            	
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
			
			p = (Predmet)Enum.Parse(typeof(Predmet), vstup, true);
            
            return p;
        }

        static Predmet VyberPocitace()
        {
            Random r = new Random();
            int rozhodovaniPocitace = r.Next(1, 4);

            Predmet pp = (Predmet)rozhodovaniPocitace;

            return pp;
        }

        static void VlastniHra()
        {
		
            Console.WriteLine("Vitejte ve hre kamen-nuzky-papir\nHrajeme na 2 vitezna kola.\n--------------");

			
			int pocetHer, uzivatelVyhra = 0, pocitacVyhra = 0;
			Predmet hrac, pocitac;
			
			for(pocetHer = 1; pocetHer <= 3; pocetHer++)
			{
				
				hrac = VyberUzivatele();
				pocitac = VyberPocitace();
				
				switch(hrac)
				{
					case Predmet.Kamen:
						
						Console.WriteLine("Pocitac zvolil {0} a Hrac zvolil {1}", pocitac, hrac);
						
						if (pocitac == hrac)
						{
							Console.WriteLine("Remiza!");
							pocetHer--;
						}						
						else if (pocitac == Predmet.Papir)
						{
							Console.WriteLine("Pocitac vyhrava {0} kolo!\n--------------", pocetHer);
							pocitacVyhra++;
						}
						else
						{
							Console.WriteLine("Hrac vyhrava {0} kolo!", pocetHer);
							uzivatelVyhra++;
						}
						Console.WriteLine("Dosavadni skore\nPocitac | Hrac\n{0} : {1}", pocitacVyhra, uzivatelVyhra);
						break;
					case Predmet.Papir:
						
						Console.WriteLine("Pocitac zvolil {0} a Hrac zvolil {1}", pocitac, hrac);
						
						if (pocitac == hrac)
						{
							Console.WriteLine("Remiza!");
							pocetHer--;
						}						
						else if (pocitac == Predmet.Nuzky)
						{
							Console.WriteLine("Pocitac vyhrava {0} kolo!\n--------------", pocetHer);
							pocitacVyhra++;
						}
						else
						{
							Console.WriteLine("Hrac vyhrava {0} kolo!", pocetHer);
							uzivatelVyhra++;
						}
						Console.WriteLine("Dosavadni skore\nPocitac | Hrac\n{0} : {1}", pocitacVyhra, uzivatelVyhra);
						break;
					case Predmet.Nuzky:
						
						Console.WriteLine("Pocitac zvolil {0} a Hrac zvolil {1}", pocitac, hrac);
						
						if (pocitac == hrac)
						{
							Console.WriteLine("Remiza!");
							pocetHer--;
						}						
						else if (pocitac == Predmet.Kamen)
						{
							Console.WriteLine("Pocitac vyhrava {0} kolo!\n--------------", pocetHer);
							pocitacVyhra++;
						}
						else
						{
							Console.WriteLine("Hrac vyhrava {0} kolo!", pocetHer);
							uzivatelVyhra++;
						}
						Console.WriteLine("Dosavadni skore\nPocitac | Hrac\n{0} : {1}", pocitacVyhra, uzivatelVyhra);
						break;
					default:
						Console.WriteLine("Tohle bylo necekane! Tak znovu...\n--------------");
						pocetHer--;
						break;				
				}
				
				if(uzivatelVyhra == 2 || pocitacVyhra == 2)
				{
				
					Console.WriteLine("Konec hry! Gratulace vitezi.\nKonecne skore je Pocitac: {0} | Hrac:{1} po {2} kolech.", pocitacVyhra, uzivatelVyhra, pocetHer);
					break;
				
				}
			}            
        }
    	
        static void Main(string[] args)
        {

            VlastniHra();
            Console.ReadLine();

        }       
    }
}
