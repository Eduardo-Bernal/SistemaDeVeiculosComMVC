using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaDeVeiculosComMVC.Data;
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

        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaVeiculo.ToListAsync();
            return View(lista);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(string modelo, int ano, string tipo)
        {
            Veiculo veiculo;

            if (tipo == "Carro")
                veiculo = new Carro(modelo, ano);
            else
                veiculo = new Moto(modelo, ano);

            veiculo.Revisao = veiculo.CalcularRevisao(); // ✅ salva no banco

            _context.TabelaVeiculo.Add(veiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

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
