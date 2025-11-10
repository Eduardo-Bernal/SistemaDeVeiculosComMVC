namespace SistemaDeVeiculosComMVC.Models
{
     public class Moto : Veiculo
    {
        public Moto(string Modelo, int Ano) : base(Modelo, Ano) { }

        public override double CalcularRevisao()
        {
            return 300.0; // custo fixo da revisão
        }
    }
}