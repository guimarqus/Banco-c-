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
                Console.Clear();
                Console.WriteLine("Bem vindo");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Credito");
                Console.WriteLine("2 - Debito");
                Console.WriteLine("3 - Sair");
                int opcaoMovimentacao = int.Parse(Console.ReadLine());
                switch (opcaoMovimentacao)
                {
                    case 1:
                        RealizarMovimentacaoCredito(conta);
                        opcaoValida = true;
                        break;

                    case 2:
                        RealizarMovimentacaoDebito(conta);
                        opcaoValida = true;
                        break;
                    case 3:
                        opcaoValida = true;
                        Opcoes.EscolherOpcoes(conta);
                        break;

                    default:
                        Console.WriteLine("Digite apenas as opções informadas");
                        Thread.Sleep(1500);
                        break;
                }


            }
        }

        public static void RealizarMovimentacaoCredito(Conta conta)
        {
            bool repetir = true;
            while (repetir)
            {
                Console.WriteLine("Digite o valor que voce deseja adicionar");
                decimal creditoAdd = decimal.Parse(Console.ReadLine());
                Movimentacao mov = Movimentacao.CriarMov(creditoAdd, TipoMovimentacao.Credito);
                conta.SomarContaCredito(mov.Valor);
                Console.WriteLine($"Foram adicionados {mov.Valor}$ a sua conta, seu saldo atual é de {conta.SaldoBancario}$");
                Console.WriteLine("Deseja realizar outra operação? (digite 0 para adicionar mais ao seu saldo ou digite " +
                    "qualquer número para seguir ao menu) ");
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
            while (repetir)
            {
                Console.WriteLine("Digite o valor que voce deseja debitar");
                Console.WriteLine($"O seu saldo atual é de { conta.SaldoBancario}$");
                decimal debitoRemov = decimal.Parse(Console.ReadLine());
                Movimentacao mov = Movimentacao.CriarMov(debitoRemov, TipoMovimentacao.Debito);

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
                    Console.WriteLine($"Foram debitados {mov.Valor}$ da sua conta, seu saldo atual é {conta.SaldoBancario}$");
                    Console.WriteLine("Deseja realizar outra operação? (digite 0 para continuar ou digite " +
                    "qualquer número para seguir ao menu) ");
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
