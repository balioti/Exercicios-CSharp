using System;
using escoladerock.models;

namespace escoladerock
{
    class program
    {
        static void Main(string[] args)
        {
            instrumentomusical generico = new instrumentomusical();
            System.Console.WriteLine(generico.TocarMusica());

            Violao violao = new Violao();
            System.Console.WriteLine("Violao;" + violao.TocarMusica());

        }

               
    }
}
