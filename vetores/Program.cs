using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];
            int pares = 0;
            int impares = 0;

            for(int cont = 0; cont < 6; cont++){
                Console.Write("digite um numero: ");
                vetor[cont] = int.Parse(Console.ReadLine());
            }

            foreach (int num in vetor)
            {
                if(num%2 == 0){
                    pares +=1;
                    
                } else {
                    impares++;
                }


            }

            Console.WriteLine($"vc tem {pares} numeros pares e {impares} numeros impares");
        }
    }
}
