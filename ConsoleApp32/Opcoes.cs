

namespace ConsoleApp32
{
    class Opcoes
    {
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
                    Conta.MostrarSaldo(conta);
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
