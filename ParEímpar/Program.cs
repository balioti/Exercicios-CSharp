using System;

namespace parimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string op = "s";
            while (op == "s")
            {

            Console.WriteLine("informe se é par ou ímpar: ");
            num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("o número é PAR");
            }
            else {
                Console.WriteLine("o número é ÍMPAR");
            }

            Console.WriteLine("desejar inserir outro número? s/n");
            op = Console.ReadLine();
            


            
            }
        }
    }
}
