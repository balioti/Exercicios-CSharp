using System.IO;

namespace MVC.Repositories
{
    public class PedidoRepository
    {
        
        {
            private const string PATH = "Database/Pedido.csv";

            public PedidoRepository()
            {
                if(!File.Exists(PATH)){
                    File.Create(PATH).Close();
                }
            }
        }

        public bool Inserir(PedidoRepository pedido)
        {
            
        }
    }
}