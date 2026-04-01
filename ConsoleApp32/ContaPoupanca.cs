using static ConsoleApp32.Movimentacao;

namespace ConsoleApp32
{
    class ContaPoupanca : Conta
    {
     
        public ContaPoupanca(string nome) : base(nome)
        {
        }

        public override decimal ObterSaldoBancario()
        {
            return SaldoBancario;
        }

        public override void SomarContaCredito(decimal valor)
        {
            SaldoBancario += valor;
            Movimentacoes.Add(CriarMov(valor, TipoMovimentacao.Credito));
        }

        public override void SubtrairContaDebito(decimal valor)
        {
            if (SaldoBancario < valor)
            {
                Console.WriteLine("Não foi possivel debitar na sua Poupança");
                Thread.Sleep(1000);
                return;
            }
            SaldoBancario -= valor;
            Movimentacoes.Add(CriarMov(valor, TipoMovimentacao.Debito));
        }
      
        public static void RendimentoPoupanca(Conta conta)
        {
            
            decimal rendimento = conta.SaldoBancario * 0.001m;
            rendimento += conta.SaldoBancario;
            Console.WriteLine($"Saldo atual da Poupança {conta.SaldoBancario:C} com a renda diária de 0.1% é R${rendimento}");
        }
        public override void MostrarSaldo(Conta conta)
        {
            bool continua = true;
            while (continua)
            {
                Console.WriteLine();
                Console.Write($"Bem vindo {conta.Nome}  \n");
                Console.ForegroundColor = ConsoleColor.Green;
                RendimentoPoupanca(conta);
               
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
    }
}

       
    

