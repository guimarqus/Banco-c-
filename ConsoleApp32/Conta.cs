using static ConsoleApp32.Movimentacao;
using System.Collections.Generic;
namespace ConsoleApp32
{
    abstract class Conta
    {
        public decimal saldoBancario {  get; protected set; }
        public int Id { get; private set; }
        public string Nome { get; protected set; }
        public List<Movimentacao> Movimentacoes { get; private set; }
        

        protected Conta(string nome)
        {
            Id = Random.Shared.Next();
            Nome = nome;
            saldoBancario = saldoBancario;
            Movimentacoes = new List<Movimentacao>();
            
        }
        public abstract void SomarContaCredito(decimal valor);

        public abstract void SubtrairContaDebito(decimal valor);

        public void AplicandoMovimentacao(Movimentacao movimentacao)
        {
            movimentacao.Movimentar(this);
            Movimentacoes.Add(movimentacao);
        }

        public abstract void MostrarSaldo(Conta conta);
        
        public virtual void MostrarRendimento(Conta conta)
        {
            bool continua = true;
            while (continua)
            {
                Console.WriteLine("Esta conta não realiza o rendimento");
                Instrucoes.SairDoSaldo();
                
                int optSaldo = int.Parse(Console.ReadLine());
                if (optSaldo > 0)
                {
                    continua = false;
                    Menu.MenuOpcoesIniciais(conta);
                }
                else
                {
                    continua = true;

                }
            }
        }
        public virtual bool PermiteRendimento() 
        => false;

    }
}
