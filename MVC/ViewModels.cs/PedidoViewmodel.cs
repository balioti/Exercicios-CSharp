using System.Collections.Generic;
using MVC.Models;

namespace MVC.ViewModels.cs
{
    public class PedidoViewmodel
    {
        public List<Hamburguer> Hamburgueres {get; set;}

        public PedidoViewmodel()
        {
            this.Hamburgueres = new List<Hamburguer>();
        }
    }
}