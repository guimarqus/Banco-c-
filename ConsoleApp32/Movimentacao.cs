using static ConsoleApp32.Enums;

namespace ConsoleApp32
{
    abstract class Movimentacao
    {

        public int Id { get; private set; }
        public TipoMovimentacao TipodeMovimentacao { get; set; }
        public decimal Valor { get; private set; }
        public DateTime Date { get; private set; }


        protected Movimentacao(decimal valor, TipoMovimentacao tipoMovimentacao)
        {
            Id = Random.Shared.Next();
            Valor = valor;
            TipodeMovimentacao = tipoMovimentacao;
            Date = DateTime.UtcNow;
        }
        

        public abstract void Movimentar(Conta conta);
         
            
        

       

    }
}
