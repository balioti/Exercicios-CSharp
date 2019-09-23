using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double salarioComReajuste = 0;

            Console.WriteLine("infome o salario");
            salario = double.Parse(Console.ReadLine());


            if(salario <= 500){
                Console.WriteLine("salario sem reajuste: "+ salario);
                salarioComReajuste = 1.3 * salario;
                Console.WriteLine("Salario com reajuste:" + salarioComReajuste);

            }
            else if(salario > 500){
                Console.WriteLine("TRABALHE MAIS");
            }

            
        }
    }
}
