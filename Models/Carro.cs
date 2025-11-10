
namespace SistemaDeVeiculosComMVC.Models
{
  public class Carro : Veiculo
    {
        public Carro(string Modelo, int Ano) : base(Modelo, Ano) { }

        public override double CalcularRevisao()
        {
            return 500.0; 
        }
    }
}