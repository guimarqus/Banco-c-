using System;
using static ConsoleApp32.Movimentacao;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp32
{
    class Movimentacao
    {

        public int Id { get; private set; }
        public TipoMovimentacao TipodeMovimentacao { get; set; }
        public decimal Valor { get; private set; }
        public static void AcessarMenuMovimentacao(Conta conta)
        {
            Console.Clear();
            bool opcaoValida = false;

            while (!opcaoValida)
            {
                Texto.TextoParaEscolhaDasOperacoes();
                Opcoes.MenuOpcoesParaMovimentar(conta);
            }
        }

        public static void RealizarMovimentacaoCredito(Conta conta)
        {
            bool repetir = true;
            while (repetir)
            {
                Texto.AdicionarCredito(conta);
                decimal creditoAdd = decimal.Parse(Console.ReadLine());
                Movimentacao mov = CriarMov(creditoAdd, TipoMovimentacao.Credito);
                conta.SomarContaCredito(mov.Valor);
                Texto.MostrarResultadoCredito(conta, mov);
                int continuarOperacao = int.Parse(Console.ReadLine());
                if ( continuarOperacao == 0 )
                {
                    repetir = true;
                }
                else
                {
                    repetir = false;
                   AcessarMenuMovimentacao(conta);

                }
            }
        }
        public static void RealizarMovimentacaoDebito(Conta conta)
        {
            bool repetir = true;
            while ((repetir))
            {
                Texto.DebitarSaldo(conta);
                decimal debitoRemov = decimal.Parse(Console.ReadLine());
                Movimentacao mov = CriarMov(debitoRemov, TipoMovimentacao.Debito);

                if (debitoRemov > conta.SaldoBancario)
                {
                    repetir = true;
                    Console.WriteLine("Saldo disponivel insuficiente");
                    RealizarMovimentacaoDebito(conta);
                    return;
                }
                else
                {
                    conta.SubtrairContaDebito(debitoRemov);
                    Texto.MostraResultadoDebito(conta, mov);
                    int continuarOperacao = int.Parse(Console.ReadLine());
                    if (continuarOperacao == 0)
                    {
                        repetir = true;
                    }
                    else
                    {
                        repetir = false;
                        AcessarMenuMovimentacao(conta);

                    }
                }
                Console.WriteLine();
            }
        }

        public enum TipoMovimentacao
        {
            Credito = 1,
            Debito,

        }


        private Movimentacao(decimal valor, TipoMovimentacao tipoMovimentacao)
        {
            Id = Random.Shared.Next();
            Valor = valor;
            TipodeMovimentacao = tipoMovimentacao;
        }
        public static Movimentacao CriarMov(decimal valor, TipoMovimentacao tipoMovimentacao)
        {

            return new Movimentacao(valor, tipoMovimentacao);


        }
    }
}
