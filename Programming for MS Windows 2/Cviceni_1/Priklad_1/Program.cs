// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

using System.Threading;

namespace Cviceni1
{
    class Program
    {
        // NENI MOJE TVORBA
        public delegate void ThreadStart();
        public object numLock = new object();

        public void PrintNumber()
        {
            // Projit v prezentaci
            lock(numLock)
            { 
                for(int i = 0; i<= 50; i++)
                {
                    Console.Write(i);
                    Thread.Sleep(10);
                }
            }
        }
        public void PrintCharacter()
        {
            int j;
            for (int i = 0;i<= 40;i++)
            {
                // Vypiseme na obrazovku znak z ASCII tabulky
                // +20 je zde proto, abychom vypsali na obrazovku zname znaky a ne specialni
                j = i + 60;
                Console.Write((char)j);
                Thread.Sleep(100);

                j = i;
            }
        }
        public void PrintDash()
        {
            for(int i = 0; i <= 70;i++)
            {
                Console.Write("-");
                Thread.Sleep(50);
            }
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Hlavni vlakno";
            Console.WriteLine(Thread.CurrentThread.Name);

            Program program = new Program();

            // Vytvarime 3 vlakna
            Thread thread1 = new Thread(program.PrintNumber);
            Thread thread2 = new Thread(program.PrintCharacter);
            Thread thread3 = new Thread(program.PrintDash);

            // Pojmenujeme si vsechna vlakna
            thread1.Name = "Cisla";
            thread2.Name = "Pismena";
            thread3.Name = "Pomlcky";

            // Postupne vlakna spustime
            Console.WriteLine($"Vypusuji {thread1.Name}");
            thread1.Start();
            Console.WriteLine($"Vypusuji {thread2.Name}");
            thread2.Start();
            Console.WriteLine($"Vypusuji {thread3.Name}");
            thread3.Start();
            
            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("\nHotovo");

        }
    }
}
