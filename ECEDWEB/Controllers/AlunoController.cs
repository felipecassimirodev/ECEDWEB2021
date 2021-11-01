using ECEDWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECEDWEB.Controllers
{
    public class AlunoController : Controller
    {
        private readonly Contexto _contexto;
        public AlunoController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.aluno.ToListAsync());
        }
        [HttpGet]
        public IActionResult CriarAluno()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CriarAluno(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(aluno);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            else return View(aluno);

        }
        [HttpGet]
        public IActionResult AtualizarAluno(int? id)
        {
            if (id != null)
            {
                Aluno aluno = _contexto.aluno.Find(id);
                return View(aluno);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AtualizarAluno(int? id, Aluno aluno)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(aluno);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(aluno);
            }
            else return NotFound();
        }
        [HttpGet]
        public IActionResult ExcluirAluno(int? id)
        {
            if (id != null)
            {
                Aluno aluno = _contexto.aluno.Find(id);
                return View(aluno);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> ExcluirAluno(int? id, Aluno aluno)
        {
            if (id != null)
            {
                _contexto.Remove(aluno);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }
    }
}
