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

        [Range(0, 10000)]
        public double RevisaoBase { get; set; }

       
        public double Revisao { get; set; }

       
        public Veiculo() { }

        
        public Veiculo(string modeloConstrutor, int anoConstrutor)
        {
            Modelo = modeloConstrutor;
            Ano = anoConstrutor;

            
            RevisaoBase = 0;
        }

       
        public Veiculo(string modeloConstrutor, int anoConstrutor, double revisaoBaseConstrutor)
        {
            Modelo = modeloConstrutor;
            Ano = anoConstrutor;
            RevisaoBase = revisaoBaseConstrutor;
        }

        public abstract double CalcularRevisao();
    }
}
