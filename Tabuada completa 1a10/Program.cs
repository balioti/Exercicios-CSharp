using System;

namespace Tabuada_completa_1a10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int e =1; e <=10; e ++)
            {
                for(int d = 1; d<=10; d ++)
                {        
                    Console.WriteLine(e + " x " + d +" = " + e * d);
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
