using System;
using static ConsoleApp32.Movimentacao;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp32
{
    class Movimentacao
    {

        public int Id { get; private set; }
        public TipoMovimentacao TipodeMovimentacao { get; set; }
        public double Valor { get; private set; }
        


        public static void AcessarMenuMovimentacao()
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
                        RealizarMovimentacaoCredito();
                        opcaoValida = true;
                        break;

                    case 2:
                        ;
                        opcaoValida = true;
                        break;
                    case 3:
                        int opcoes = 0;
                        Opcoes.EscolherOpcoes(opcoes);
                        break;

                    default:
                        Console.WriteLine("Digite apenas as opções informadas");
                        Thread.Sleep(1500);
                        break;
                }


            }
        }

        public static void RealizarMovimentacaoCredito()
        {
            Console.WriteLine("Digite o valor que voce deseja adicionar");
            double creditoAdd = double.Parse(Console.ReadLine());
            Movimentacao mov = Movimentacao.CriarMov(creditoAdd);
            Console.WriteLine($"Foram adicionados {mov.Valor} $ a sua conta");
            
        }
        public static void RealizarMovimentacaoDebito(Conta conta)
        {
            Console.WriteLine("Debito");
            Console.WriteLine("Digite o valor que voce deseja debitar");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Deseja ver o saldo disponivel para resgate ?");
            Console.ResetColor();
            Console.WriteLine();

            double debitoRemov = double.Parse(Console.ReadLine());
            Movimentacao mov = Movimentacao.CriarMov(debitoRemov);
            //decimal saldoAtual = Conta.GetSaldoBancario();

            //if (debitoRemov >0) 


        }

        public enum TipoMovimentacao
        {
            Credito = 1,
            Debito,

        }


        private Movimentacao(double valor, TipoMovimentacao tipoMovimentacao)
        {
            Id = Random.Shared.Next();
            Valor = valor;
            tipoMovimentacao = tipoMovimentacao;
        }
        public static Movimentacao CriarMov(double valor)
        {

            return new Movimentacao(valor);


        }
    }
}
