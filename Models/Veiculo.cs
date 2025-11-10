using System.ComponentModel.DataAnnotations;

namespace SistemaDeVeiculosComMVC.Models
{
    public abstract class Veiculo
    {
        [Key] 
        public int Id { get; set; }

        [Required] 
        public string Modelo { get; set; } = string.Empty;

        [Range(1880, 2100)] 
        public int Ano { get; set; }

        
        public Veiculo() { }

              public Veiculo(string modeloConstrutor, int anoConstrutor)
        {
            Modelo = modeloConstrutor;
            Ano = anoConstrutor;
        }

        
        public abstract double CalcularRevisao();

        
        public virtual void ExibirResumo()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }
    }
}