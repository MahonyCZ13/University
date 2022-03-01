// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Petr Maronek, 36456

namespace Cviceni1
{
    class Program
    {
        // NENI MOJE TVORBA
        public delegate void ThreadStart();
        public object numLock = new object();
        public int baseLevel = 1000;

        public void PrintNumber()
        {
            // Projit v prezentaci
            lock (numLock)
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.Write(i);
                    Thread.Sleep(10);
                }
            }
        }
        public void PrintCharacter()
        {
            int j;
            for (int i = 0; i <= 40; i++)
            {
                // Vypiseme na obrazovku znak z ASCII tabulky
                // +20 je zde proto, abychom vypsali na obrazovku zname znaky a ne specialni
                j = i + 60;
                Console.Write((char)j);
                Thread.Sleep(100);
            }
        }

        private void IncreaseLevel()
        {
            lock(numLock)
            {
                if (baseLevel > 0) baseLevel += 1000;
                else Console.WriteLine($"Jsme v zaporu!: {baseLevel}");
                
            }
                           
        }
        public void DecreaseLevel()
        {
            lock(numLock)
            {
                if (baseLevel > 0) baseLevel -= 1000;
                else Console.WriteLine($"Jsme v zaporu!: {baseLevel}");
            }
            
        }
        public void Vlakna()
        {
            Program program = new Program();
            Thread thread1 = new Thread(program.IncreaseLevel);
            Thread thread2 = new Thread(program.DecreaseLevel);
            Thread thread3 = new Thread(program.IncreaseLevel);
            
            thread1.Name = "Zvysuji";
            thread2.Name = "Snizuji";
            thread3.Name = "Pomlcky";
            
            thread1.Start();
            thread2.Start();
            thread3.Start();

            IncreaseLevel();
            DecreaseLevel();
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Hlavni vlakno";
            Console.WriteLine(Thread.CurrentThread.Name);

            for(int i = 0; i < 10; i++)
            {
                Program run = new Program();
                run.Vlakna();
                Console.WriteLine(run.baseLevel);
            }
            Console.WriteLine("\nHotovo");
        }
    }
}
