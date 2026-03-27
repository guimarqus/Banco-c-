using static ConsoleApp32.Movimentacao;

namespace ConsoleApp32
{
    class Conta
    {
        public decimal SaldoBancario {  get; private set; }
        public int Id { get; set; }
        public string Nome { get; private set; }
        public List<Movimentacao> Movimentacoes { get; private set; }
        

        private Conta(string nome)
        {
            Id = Random.Shared.Next();
            Nome = nome;
            SaldoBancario = ObterSaldoBancario();
            Movimentacoes = new List<Movimentacao>();
            
        }

        public static Conta CriarConta(string nome)
        {
            
            return new Conta(nome);
        }
        public static void SolicitarDadosParaConta()
        {
            var nome = Console.ReadLine();
            var conta = CriarConta(nome);
            Opcoes.MenuOpcoesIniciais(conta);

        }

        public  decimal ObterSaldoBancario()
        {
            return SaldoBancario;
        }
        public void SomarContaCredito(decimal valor)
        {

            SaldoBancario += valor;
            Movimentacoes.Add(CriarMov(valor, TipoMovimentacao.Credito));

        }
        public void SubtrairContaDebito(decimal valor)
        {

            SaldoBancario -= valor;
            Movimentacoes.Add(CriarMov(valor, TipoMovimentacao.Debito));
            
        }

        public static void MostrarSaldo(Conta conta)
        {
            bool continua = true;
            while (continua)
            {
                Console.WriteLine();
                Console.Write($"Bem vindo {conta.Nome} o seu saldo atual é de ");
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

    }
}
