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
    }
}
