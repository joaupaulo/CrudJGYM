using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AcademiaJGYM.Models;
using AcademiaJGYM.Repositorios;

namespace AcademiaJGYM.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAluno _context;

public HomeController(IAluno aluno)
        {
            _context = aluno;
        }


        public IActionResult Index()
        {

            var alunos = _context.GetAll();

            return View(alunos);
        }



        [HttpGet]
        public IActionResult Create()
        {

        
            return View();
        }


        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {

            _context.Insert(aluno);
            _context.Save();
            return View();
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {

            var alunos = _context.GetById(id);
            return View(alunos);
        }


        [HttpPost]
        public IActionResult Delete(Aluno alunos)
        {
             _context.Delete(alunos);
            _context.Save();

            return View(alunos);
        }



        [HttpGet]
        public IActionResult Detalis(int id)
        {

            var alunos = _context.GetById(id);
            return View(alunos);
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {

            var alunos = _context.GetById(id);
            return View(alunos);
        }


        [HttpPost]
        public IActionResult Edit(Alunos aluno)
        {
            _context.Update(aluno);
            _context.Save();
            return View(aluno);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
