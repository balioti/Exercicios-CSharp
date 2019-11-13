using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Repositories;

namespace MVC.Controllers
{
    public class CadastroController : Controller
    {
        ClienteRepository clienterepositorio = new ClienteRepository();
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

            clienterepositorio.Inserir(cliente);

            return View("Sucesso");
           } catch(Exception e)
           {
               return View("Erro");
           }
           
            
        }
    }
}