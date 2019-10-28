using System;

namespace Revisao_Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura, comprimento;
            Console.WriteLine("introduza a largura");
            largura = int.Parse(Console.ReadLine());
            Console.WriteLine("introduza o comprimento");
            comprimento = int.Parse(Console.ReadLine());

            Console.WriteLine("A área é = " + (largura*comprimento));
            Console.WriteLine("O perímetro é = " + ((2* largura) + (2 * comprimento)));
        }
    }
}
