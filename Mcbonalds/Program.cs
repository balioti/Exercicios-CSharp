using System;

namespace Mcbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente cliente1 = new cliente("Alexandre", "55 11 1223-4567", "alexandre@hotmail.com");

            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Telefone" + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);
        }
    }
}
