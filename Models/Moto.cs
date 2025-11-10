namespace SistemaDeVeiculosComMVC.Models
{
    public class Moto : Veiculo
    {
        public Moto() : base() {}

        public Moto(string modelo, int ano) : base(modelo, ano) {}

        public Moto(string modelo, int ano, double revisaoBase) : base(modelo, ano, revisaoBase) {}

        public override double CalcularRevisao() => 300;
    }
}
