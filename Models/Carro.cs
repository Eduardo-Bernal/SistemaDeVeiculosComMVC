namespace SistemaDeVeiculosComMVC.Models
{
    public class Carro : Veiculo
    {
        public Carro() : base() {}

        public Carro(string modelo, int ano) : base(modelo, ano) {}

        public Carro(string modelo, int ano, double revisaoBase) : base(modelo, ano, revisaoBase) {}

        public override double CalcularRevisao() => 500;
    }
}
