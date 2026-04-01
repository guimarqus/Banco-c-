

using System.Linq.Expressions;

namespace ConsoleApp32
{
    class Opcoes
    {
        public static Conta MenuParaCriacaoConta(string nome)
        {
            Conta conta;
            int escolha = int.Parse(Console.ReadLine());
            Enums.OpcoesParaConta opcao = (Enums.OpcoesParaConta)escolha;
            switch (opcao)
            {
                case Enums.OpcoesParaConta.ContaPoupanca:
                     return new ContaPoupanca(nome);
                   
                case Enums.OpcoesParaConta.ContaCorrente:
                     return new ContaCorrente(nome);

                case Enums.OpcoesParaConta.Sair:
                    Console.WriteLine("Saindo");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
                   
                default:
                    Console.WriteLine("Opção Inválida");
                    MenuParaCriacaoConta(nome);
                    break;
            }
            return null;
        }
        public static void MenuOpcoesIniciais(Conta conta)
        {
            Instrucoes.MenuDasOpcoesIniciais(conta);
            int escolha = int.Parse(Console.ReadLine());
            Console.Clear();
            Enums.OpcoesDoMenuInicial opcao = (Enums.OpcoesDoMenuInicial)escolha;
            switch (opcao)
            {
                case Enums.OpcoesDoMenuInicial.Movimentar:
                    Movimentacao.AcessarMenuMovimentacao(conta);
                    break;

                case Enums.OpcoesDoMenuInicial.Historico:
                    Historico.MostrarHistorico(conta);
                    break;

                case Enums.OpcoesDoMenuInicial.Saldo:
                    conta.MostrarSaldo(conta);
                    break;

                case Enums.OpcoesDoMenuInicial.Voltar:
                    Instrucoes.TextoParaCriacaoDeConta();
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
            Enums.OpcoesParaMovimentar opcao = (Enums.OpcoesParaMovimentar)opcaoMovimentacao;
            switch (opcao)
            {
                case Enums.OpcoesParaMovimentar.Credito:
                    Movimentacao.RealizarMovimentacaoCredito(conta);
                    opcaoValida = true;
                    break;

                case Enums.OpcoesParaMovimentar.Debito:
                    Movimentacao.RealizarMovimentacaoDebito(conta);
                    opcaoValida = true;
                    break;
                case Enums.OpcoesParaMovimentar.Sair:
                    opcaoValida = true;
                    MenuOpcoesIniciais(conta);
                    break;

                default:
                    Console.WriteLine("Digite apenas as opções informadas");
                    Thread.Sleep(1500);
                    break;

            }


        }




    }
}
