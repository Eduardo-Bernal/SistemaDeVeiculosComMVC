using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeVeiculosComMVC.Data;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVeiculosComMVC.Models;

namespace SistemaDeVeiculosComMVC.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly AppDbContext _context;

        public VeiculoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Veiculo
        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaVeiculo.ToListAsync();
            return View(lista);
        }

        // GET: Veiculo/Criar
        public IActionResult Criar()
        {
            return View();
        }

        // POST: Veiculo/Criar
        [HttpPost]
        public async Task<IActionResult> Criar(Veiculo veiculo)
        {
            if (!ModelState.IsValid) return View(veiculo);

            _context.TabelaVeiculo.Add(veiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Veiculo/Deletar/5
        public async Task<IActionResult> Deletar(int id)
        {
            var veiculo = await _context.TabelaVeiculo.FindAsync(id);
            if (veiculo == null) return NotFound();

            _context.TabelaVeiculo.Remove(veiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
