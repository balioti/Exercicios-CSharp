using System;

namespace parimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe se é par ou ímpar: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("o número é PAIR");
            }
            else {
                Console.WriteLine("o número é ODD");
            }
        }
    }
}
