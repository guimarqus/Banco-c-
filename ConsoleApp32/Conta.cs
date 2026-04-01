using static ConsoleApp32.Movimentacao;

namespace ConsoleApp32
{
    abstract class Conta
    {
        public decimal SaldoBancario {  get; protected set; }
        public int Id { get; private set; }
        public string Nome { get; protected set; }
        public List<Movimentacao> Movimentacoes { get; private set; }
        
        public Conta() { }

        protected Conta(string nome)
        {
            Id = Random.Shared.Next();
            Nome = nome;
            SaldoBancario = ObterSaldoBancario();
            Movimentacoes = new List<Movimentacao>();
            
        }
        public abstract void SomarContaCredito(decimal valor);

        public abstract void SubtrairContaDebito(decimal valor);


        public static void SolicitarDadosParaConta()
        {
            
            var nome = Console.ReadLine();
            Instrucoes.TextoParaEscolherTipoConta();
            Conta conta = Opcoes.MenuParaCriacaoConta(nome);
            Opcoes.MenuOpcoesIniciais(conta);

        }

        public abstract decimal ObterSaldoBancario();



        public abstract void MostrarSaldo(Conta conta);
        

    }
}
