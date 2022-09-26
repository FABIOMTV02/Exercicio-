using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mvc_BOO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BOO.Controllers
{
    public class HomeController : Controller
    {
        private IAlunoBLL alunoBll;
        public HomeController(IAlunoBLL _alunoBll)
        {
            alunoBll = _alunoBll;                  
        }
        

        public IActionResult Index()
        {
            //AlunoBLL _aluno = new AlunoBLL();
            List<Aluno> alunos = alunoBll.GetAlunos().ToList();
            return View("Lista",alunos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                //AlunoBLL _aluno = new AlunoBLL();
                alunoBll.IncluirAluno(aluno);
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //AlunoBLL alunoBll = new AlunoBLL();
            Aluno aluno = alunoBll.GetAlunos().Single(x => x.Id == id);
            return View(aluno);
        }

        [HttpPost]
        public IActionResult Edit(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                //AlunoBLL alunoBll = new AlunoBLL();
                alunoBll.AtualizarAluno(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }
        public IActionResult Delete(int id)
        {
            //alunoBll.DeletarAluno(id);
            //return RedirectToAction("Index");
            Aluno aluno = alunoBll.GetAlunos().Single(a => a.Id == id);
            return View(aluno);
        }

        [HttpPost]
        public IActionResult Delete(Aluno aluno)
        {
            alunoBll.DeletarAluno(aluno.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Aluno aluno = alunoBll.GetAlunos().Single(a => a.Id == id);
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
