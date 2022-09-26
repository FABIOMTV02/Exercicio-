using Microsoft.AspNetCore.Mvc;
using mvc_modelbinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_modelbinding.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            if(cliente?.Id == 0 || cliente?.Nome == null || cliente?.Email == null)
            {
                ViewBag.erro = "Dados do cliente inválidos...";
                return View();
            }

            else
            
            { 
                return View("ExibirDados", cliente);
            }

        }

    }
}
