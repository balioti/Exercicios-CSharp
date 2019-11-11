using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
           try{        
            Cliente cliente = new Cliente(
            form["nome"],
            form["endereco"],
            form["telefone"],
            form["senha"],
            form["email"],
            DateTime.Parse(form["data-nascimento"]));

            return View("Sucesso");
           } catch(Exception e)
           {
               return View("Erro");
           }
           
            
        }
    }
}