namespace ConsoleApp32
{
    class Opcoes
    {
        public static void MenuOpcoesIniciais(Conta conta)
        {
            Instrucoes.MenuDasOpcoesIniciais(conta);
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
                    MenuOpcoesIniciais(conta);
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
