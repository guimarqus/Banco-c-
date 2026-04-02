

using System.Linq.Expressions;

namespace ConsoleApp32
{
    class Menu
    {
        public static void SolicitarDadosParaConta()
        {

            var nome = Console.ReadLine();
            Instrucoes.TextoParaEscolherTipoConta();
            Conta conta = MenuParaCriacaoConta(nome);
            MenuOpcoesIniciais(conta);

        }
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
            Console.Clear();
            Instrucoes.MenuDasOpcoesIniciais(conta);
            int escolha = int.Parse(Console.ReadLine());
            Console.Clear();
            Enums.OpcoesDoMenuInicial opcao = (Enums.OpcoesDoMenuInicial)escolha;
            switch (opcao)
            {
                case Enums.OpcoesDoMenuInicial.Movimentar:
                    MenuOpcoesParaMovimentar(conta);
                    break;

                case Enums.OpcoesDoMenuInicial.Historico:
                    Historico.MostrarHistorico(conta);
                    break;

                case Enums.OpcoesDoMenuInicial.Rendimento:
                    if (conta.PermiteRendimento())
                        conta.MostrarRendimento(conta);
                    else conta.MostrarRendimento(conta);
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
            
            bool repetir = true;
            while (repetir)
            {
                Console.Clear();
                Instrucoes.TextoParaEscolhaDasOperacoes();
                int opcaoMovimentacao = int.Parse(Console.ReadLine());
                Enums.OpcoesParaMovimentar opcao = (Enums.OpcoesParaMovimentar)opcaoMovimentacao;
                switch (opcao)
                {
                    case Enums.OpcoesParaMovimentar.Credito:
                        bool repetirCredito = true;
                        while (repetirCredito)
                        {

                            Instrucoes.AdicionarCredito(conta);
                            decimal valor = decimal.Parse(Console.ReadLine());
                            var movimentacao = new Credito(valor);
                            conta.AplicandoMovimentacao(movimentacao);
                            Instrucoes.MostrarResultadoCredito(conta, movimentacao);
                            int opcaoValida = int.Parse(Console.ReadLine());
                            repetirCredito = (opcaoValida == 0);

                        }
                                break;
                            
                        
                    case Enums.OpcoesParaMovimentar.Debito:
                        bool repetirDebito = true;
                        while (repetirDebito)
                        {
                            Instrucoes.DebitarSaldo(conta);
                            decimal valor = decimal.Parse(Console.ReadLine());
                            var movimentacao = new Debito(valor);
                            conta.AplicandoMovimentacao(movimentacao);
                            Instrucoes.MostraResultadoDebito(conta, movimentacao);
                            int opcaoValida = int.Parse(Console.ReadLine());
                            repetirDebito = (opcaoValida == 0);
                        }
                            break;   
                        
                    case Enums.OpcoesParaMovimentar.Sair:
                        repetir = false;
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




}

