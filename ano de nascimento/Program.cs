using System;

namespace ano_de_nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int dataAtual = 2019;
            int anoDenascimento = 0;
            

            Console.WriteLine("Qual ano de nascimento");
            anoDenascimento = int.Parse(Console.ReadLine());
            idade = dataAtual - anoDenascimento;

            Console.WriteLine("sua idade é de " +idade+ "anos");

            if (idade <=2){
                Console.WriteLine("Recém nascido");
            }






        }
    }
}
