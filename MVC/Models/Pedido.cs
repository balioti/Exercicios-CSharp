using System;

namespace MVC.Models
{
    public class Pedido
    {
        public Cliente Cliente {get;set;}
        public Hamburguer Hamburguer {get;set;}
        public Shake shake {get;set;}

        public DateTime DataDoPedido {get;set;}

        public double PrecoTotal {get;set;}
    }
}