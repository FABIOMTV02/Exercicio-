using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_BO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_BO.Controllers
{
    public class HomeController : Controller
    {
        private IAlunoBLL alunoBLL;
        public HomeController(IAlunoBLL alunoBLL)
        {
            alunoBLL = _alunoBLL;
        }
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            //AlunoBLL _aluno = new AlunoBLL();
            List<Aluno> alunos = alunoBLL.GetAlunos().ToList();
            return View("Lista", alunos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            //if (string.IsNullOrEmpty(aluno.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O nome é obrigatório!");
            //}
            //if (string.IsNullOrEmpty(aluno.Sexo))
            //{
            //    ModelState.AddModelError("Sexo", "O sexo é obrigatório!");
            //}
            //if (string.IsNullOrEmpty(aluno.Email))
            //{
            //    ModelState.AddModelError("Email", "O email é obrigatório!");
            //}
            //if (aluno.Nascimento <= DateTime.Now.AddYears(-18))
            //{
            //    ModelState.AddModelError("Nascimento", "Data de nascimento obrigatório!");
            //}
            //if(aluno?.Nome == null || aluno?.Email == null || aluno.Sexo == null)
            //{
            //    ViewBag.Erro = "Dados Inválidos";
            //    return View();
            //}
            //else
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                AlunoBLL _aluno = new AlunoBLL();
                _aluno.IncluirAluno(aluno);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            AlunoBLL alunoBLL = new AlunoBLL();
            Aluno aluno = alunoBLL.GetAlunos().Single(x => x.Id == id);
            return View(aluno);
        }

        [HttpPost]
        public IActionResult Edit(Aluno aluno)
        {
            if(ModelState.IsValid)
            {
                AlunoBLL alunoBLL = new AlunoBLL();
                alunoBLL.AtualizarAluno(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
