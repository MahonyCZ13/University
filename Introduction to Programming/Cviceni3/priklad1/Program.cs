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
            Console.WriteLine("Zadejte cenu zbozi: ");
            double uzivatelCena = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte sazbu DPH: ");
            int uzivatelDph = Convert.ToInt32(Console.ReadLine());

            double celkem = DphVypocet(uzivatelCena, uzivatelDph);

            Console.WriteLine("Celkova cena zbozi {0} CZK s {2}% DPH je {1} CZK.", uzivatelCena, celkem, uzivatelDph);
            Console.ReadLine();

        }
        static double DphVypocet(double cena, int dph)
        {
            double vysledek = cena * ((double)dph / 100) + cena;
            return vysledek;
        }
    }
}
