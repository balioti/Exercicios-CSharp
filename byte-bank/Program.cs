using System;

namespace byte_bank
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Cadastro de clientes");
           System.Console.WriteLine();
           Console.Write("Nome: ");
           string nome = Console.ReadLine();
           Console.Write("Cpf: ");
           string cpf = Console.ReadLine();
           Console.Write("Email: ");
           string email = Console.ReadLine();

           Cliente cliente1 = new Cliente(nome,cpf,email);

           bool senhaok = false;
           do{

               Console.Write("digite a senha:");
               string senha = Console.ReadLine();
               senhaok = cliente1.TrocarSenha(senha);
               if (!senhaok) {
                   System.Console.WriteLine("senha nao atende aos requisitos");
               } else {
                   System.Console.WriteLine("senha alterada com sucesso");
               }
           }    while(!senhaok);

               System.Console.WriteLine("Cadastro de conta corrente");
               System.Console.WriteLine();
               System.Console.Write("Agencia: ");
               int agencia = int.Parse(Console.ReadLine());
               System.Console.Write("Conta: ");
               int Conta = int.Parse(Console.ReadLine());
               //System.Console.Write("Titular: ");
               //string Titular = Console.ReadLine();

               bool saldovalido = false;
               double saldo;
               do{
                   Console.Write("Digite o Saldo: ");
                   saldo = double.Parse(Console.ReadLine());
                   if (saldo >=0){
                       saldovalido = true;
                   }    else{
                       Console.WriteLine("O saldo não pode ser negativo");
                   }
               }    while(!saldovalido);

                   Contacorrente contaCorrente = new Contacorrente (agencia,Conta,cliente1);
                   contaCorrente.Saldo = saldo;

                   System.Console.WriteLine("Bytebank - Deposito");
                   Cliente usuario = contaCorrente.Titular;
                   System.Console.WriteLine($"Bem Vindo - {usuario.Nome}");
                   Console.Write("Digite o Valor do Deposito: ");
                   double valor = double.Parse(Console.ReadLine());
                   contaCorrente.Deposito(valor);
                   Console.WriteLine();
               }

           }
        }
    

