using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp32
{
    class ContaCorrente : Conta
    {

        

        public ContaCorrente(string nome) : base(nome)
        {
        }

        public override void MostrarSaldo(Conta conta)
        {
            bool continua = true;
            while (continua)
            {
                Console.WriteLine();
                Console.Write($"Bem vindo {conta.Nome} o saldo atual da conta Corrente é  de ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{conta.SaldoBancario:C}");
                Console.ResetColor();
                Instrucoes.SairDoSaldo();
                int optSaldo = int.Parse(Console.ReadLine());
                if (optSaldo > 0)
                {
                    continua = false;
                    Opcoes.MenuOpcoesIniciais(conta);
                }
                else
                {
                    continua = true;

                }

            }
        }
        

        public override decimal ObterSaldoBancario()
        {
            return SaldoBancario;
        }

        public override void SomarContaCredito(decimal valor)
        {
            SaldoBancario += valor;
            Movimentacoes.Add(Movimentacao.CriarMov(valor, Movimentacao.TipoMovimentacao.Credito));
        }

        public override void SubtrairContaDebito(decimal valor)
        {
            if (SaldoBancario - valor < -1000)
            {
                Console.WriteLine("Não é possível debitar: limite negativo atingido.");
                return;
            }

            SaldoBancario -= valor;
            Movimentacoes.Add(Movimentacao.CriarMov(valor, Movimentacao.TipoMovimentacao.Debito));
        }
    }
}
