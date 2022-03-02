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
        private static int baseLevel = 2000;

        // testovaci metoda
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
        // testovaci metoda
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
            // Protoze pracujeme s globalni promennou, pouzijeme zamek
            lock(numLock)
            {
                //if (baseLevel >= 0) baseLevel += 610;
                //else Console.WriteLine($"Jsme v zaporu!: {baseLevel}");
                baseLevel += 610;
                
            }                         
        }
        private void DecreaseLevel()
        {
            // Protoze pracujeme s globalni promennou, pouzijeme zamek
            lock (numLock)
            {
                // Pokud pri odecitani narazime na azpornou hodnotu, jiz dale nesnizujeme
                if (baseLevel >= 0) baseLevel -= 500;
                else Console.WriteLine($"Jsme v zaporu!: {baseLevel}");
            }         
        }
        public void Vlakna()
        {
            // Vytvorime si vlakna na pseido-nahodne operace
            Thread thread1 = new Thread(IncreaseLevel);
            Thread thread2 = new Thread(DecreaseLevel);
            Thread thread3 = new Thread(IncreaseLevel);
            Thread thread4 = new Thread(DecreaseLevel);
            Thread thread5 = new Thread(IncreaseLevel);

            thread1.Name = "Zvysuji";
            thread2.Name = "Snizuji";
            thread3.Name = "Zvysuji";
            thread4.Name = "Snizuji";
            thread5.Name = "Zvysuji";

            // Spustime vlakna
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();

            // Pro test spustime take metody samostatne v hlavnim vlaknu
            DecreaseLevel();
            DecreaseLevel();
        }
        static void Main(string[] args)
        {

            Thread.CurrentThread.Name = "Main vlakno";
            Console.WriteLine(Thread.CurrentThread.Name);

            for(int i = 0; i < 10; i++)
            {
                Program run = new Program();
                run.Vlakna();               
                Console.WriteLine(baseLevel);              
            }
            Console.WriteLine("\nHotovo");
        }
    }
}
