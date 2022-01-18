using System;

namespace prg_sandbox
{
    class Seznam 
    {
        public int data;
        public Seznam next;
    }

    class Zasobnik 
    {
        public Seznam vrchol;
    }
    
    class Program
    {

        static Zasobnik Create()
        {
            Zasobnik vys = new Zasobnik();
            vys.vrchol = null;
            return vys;
        }

        static bool IsEmpty(Zasobnik z)
        {
            return z.vrchol == null;
        }
        
        static void Push(Zasobnik z, int n)
        {
            Seznam tmp = new Seznam();
            tmp.data = n;
            tmp.next = z.vrchol;
            z.vrchol = tmp;
        }

        static int Top(Zasobnik z)
        {
            return z.vrchol.data;
        }

        static int Pop(Zasobnik z)
        {
            int vys = z.vrchol.data;
            z.vrchol = z.vrchol.next;
            return vys;
        }

        static void Fill(Zasobnik z, int range)
        {
            int i;
            Random rand = new Random();

            for(i = 0; i < range; i++)
                Push(z, rand.Next(10000));
            
        }

        static void Main(string[] args)
        {
            
            Zasobnik zasobnik = Create();

            Fill(zasobnik, 3);    

            Console.WriteLine(Top(zasobnik));

            Console.WriteLine(Pop(zasobnik));
            Console.WriteLine(Pop(zasobnik));
            Console.WriteLine(IsEmpty(zasobnik));

            Console.WriteLine(Pop(zasobnik));

            
            Console.WriteLine(IsEmpty(zasobnik));

            Console.ReadLine();
        }
    }
}
