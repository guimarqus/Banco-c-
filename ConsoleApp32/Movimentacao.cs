namespace ConsoleApp32
{
    class Movimentacao
    {
        public int Id { get; set; }
        public TipoMovimentacao TipoMovimentacao { get; set; } 
        public decimal Valor { get; set; }

    }
    enum TipoMovimentacao
    {
        Debito,
        Credito,
    }
}
