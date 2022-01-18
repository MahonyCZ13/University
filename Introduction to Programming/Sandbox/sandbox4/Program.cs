using System;

namespace sandbox4
{
    class Program
    {
    	static int Euklides(int cisloX, int cisloY)
    	{
    		int zbytek = 0;
    	
    		while(cisloY != 0)
    		{
    		
    			zbytek = cisloX % cisloY;
    			cisloX = cisloY;
    			cisloY = zbytek;
    		
    		}
    		
    		return cisloX;
    	
    	}
        static void Main(string[] args)
        {
            
            int x = 21;
            int y = 30;
            int nsd = Euklides(x, y);
            
            int nsn = x * y / nsd;
            
            Console.WriteLine(nsn);
            Console.ReadLine();
            
            
        }
    }
}
