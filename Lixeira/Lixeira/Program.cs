using System;

namespace Lixeira
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            int codigoProduto = 0;
            do
            {

            Console.WriteLine("Reciclagem");
            Console.WriteLine();
            Console.WriteLine("[1] Garrafa");
            Console.WriteLine("[2] GarrafaPET");
            Console.WriteLine("[3] Guarda-Chuva");
            Console.WriteLine("[4] Latinha");
            Console.WriteLine("[5] Papelão");
            Console.WriteLine("[6] Pote de Manteiga");
            
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    ColocarNaLixeira((Vidro) Lixo);
                    Confirmar();
                    break;
                case 2:
                    ColocarNaLixeira((Plasticos) Lixo);
                    Confirmar();
                    break;
                case 3:
                    ColocarNaLixeira((Diversos) Lixo);
                    Confirmar();
                    break;
                case 4:
                    ColocarNaLixeira((Metal) Lixo);
                    Confirmar();
                    break;
                case 5:
                    ColocarNaLixeira((Papel) Lixo);
                    Confirmar();
                    break;
                case 6:
                    ColocarNalixeira((Plasticos) Lixo);
                    Confirmar();
                    break;
                    



            }
        }
    }
}
