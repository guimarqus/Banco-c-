using static ConsoleApp32.Enums;
namespace ConsoleApp32
{
    class Credito : Movimentacao
    {
        public Credito(decimal valor) : base(valor, TipoMovimentacao.Credito)
        {
        }

        public override void Movimentar(Conta conta)
        {
            conta.SomarContaCredito(Valor);
        }
    }
}
