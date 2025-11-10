using Microsoft.EntityFrameworkCore;
using SistemaDeVeiculosComMVC.Models;

namespace SistemaDeVeiculosComMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        // recebe as opções de configuração do banco

        // direciona a classe (Veiculo) para a tabela (TabelaVeiculo)
        public DbSet<Veiculo> TabelaVeiculo { get; set; }

        // sobrescrever o mapeamento do modelo (uma unica tabela para funcionários)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>() // começa a configurar a entidade base Veiculo
            .HasDiscriminator<string>("Tipo") // cria uma única tabela, diferenciando Gerente e Vendedor por cargo
            .HasValue<Carro>("Carro")
            .HasValue<Moto>("Moto");
        }
    }
}