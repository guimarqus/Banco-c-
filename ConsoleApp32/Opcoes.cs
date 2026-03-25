using System;
using System.Globalization;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp32
{
    class Opcoes
    {
        public static void MenuOpcoesIniciais(Conta conta)
        {
            Texto.TextoMenuDasOpcoesIniciais();
            int escolha = int.Parse(Console.ReadLine());
            Console.Clear();
            OpcoesDoMenuInicial opcao = (OpcoesDoMenuInicial)escolha;
            switch (opcao)
            {
                case OpcoesDoMenuInicial.Movimentar:
                    Movimentacao.AcessarMenuMovimentacao(conta);
                    break;

                case OpcoesDoMenuInicial.Historico:
                    Historico.MostrarHistorico(conta);
                    break;

                case OpcoesDoMenuInicial.Saldo:
                    Conta.MostrarSaldo(conta);
                    break;

                case OpcoesDoMenuInicial.Voltar:
                    Texto.TextoParaCriacaoDeConta();
                    break;
                    

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            return;
        }

       public static void MenuOpcoesParaMovimentar(Conta conta)
        {
            bool opcaoValida = false;
            int opcaoMovimentacao = int.Parse(Console.ReadLine());
            OpcoesParaMovimentar opcao = (OpcoesParaMovimentar)opcaoMovimentacao;
            switch (opcao)
            {
                case OpcoesParaMovimentar.Credito:
                    Movimentacao.RealizarMovimentacaoCredito(conta);
                    opcaoValida = true;
                    break;

                case OpcoesParaMovimentar.Debito:
                   Movimentacao.RealizarMovimentacaoDebito(conta);
                    opcaoValida = true;
                    break;
                case OpcoesParaMovimentar.Sair:
                    opcaoValida = true;
                    Opcoes.MenuOpcoesIniciais(conta);
                    break;

                default:
                    Console.WriteLine("Digite apenas as opções informadas");
                    Thread.Sleep(1500);
                    break;

            }


        }

        enum OpcoesDoMenuInicial
        {
            Movimentar = 1,
            Historico,
            Saldo,
            Voltar,
        }

        enum OpcoesParaMovimentar
        {
            Credito = 1,
            Debito,
            Sair,

        }


    }
}
