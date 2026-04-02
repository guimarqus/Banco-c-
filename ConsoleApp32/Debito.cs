using static ConsoleApp32.Enums;

namespace ConsoleApp32
{
    class Debito : Movimentacao
    {
        public Debito(decimal valor) : base(valor, TipoMovimentacao.Debito)
        {
        }

        public override void Movimentar(Conta conta)
        {
            conta.SubtrairContaDebito(Valor);
        }
    }
}
