using System;

namespace Usuário_e_Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string senha;

            Console.WriteLine("Nome de Usuário");
            usuario = Console.ReadLine();
            Console.WriteLine("Insira sua Senha");
            senha = Console.ReadLine();
            

            if(usuario == "admin" && senha == "admin"  ){
                Console.WriteLine("Bem vindo Adm");
            }
            else{Console.WriteLine("bem vindo usuário");}

        }
    }
}
