using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try{
            System.Console.WriteLine("====================");
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["senha"]);
            System.Console.WriteLine("====================");

                var usuario = form["email"];
                var senha = form["senha"];

            return View("Sucesso");
            } catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }


        }
    }
}