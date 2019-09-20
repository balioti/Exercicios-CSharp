using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            double media=0;

            Console.WriteLine("informe a primeira nota");
            double nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("informe a segunda nota");
            double nota2 = int.Parse(Console.ReadLine());

            media= (nota1 + nota2) / 2;

            if (media >=7)
            {
                Console.WriteLine("APROVADO");
            }
            else if (media <=7)
            {
                Console.WriteLine("REPROVADO");
            }


        }
    }
}
