namespace ConsoleApp32
{
    class Movimentacao
    {

        public int Id { get; set; }
        public TipoMovimentacao TipodeMovimentacao { get; set; }
        public decimal Valor { get; set; }
        public List<Movimentacao> Movimentacoes { get; set; }


        public static void AcessarMovimentacao(Conta conta)
        {
            Console.Clear();
            bool opcaoValida = false;

            while (!opcaoValida)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Depósito");
                Console.WriteLine("2 - Pagamento");
                Console.WriteLine("3 - Sair");
                int opcaoMovimentacao = int.Parse(Console.ReadLine());
                switch (opcaoMovimentacao)
                {
                    case 1:
                        DepositoMenu(conta.SaldoBancario);
                        opcaoValida = true;
                        break;

                    case 2:
                        PagamentoMenu();
                        opcaoValida = true;
                        break;
                    case 3:
                        int opcoes = 0;
                        Opcoes.EscolherOpcoes(opcoes, saldo );
                        break;

                    default:
                        Console.WriteLine("Digite apenas as opções informadas");
                        Thread.Sleep(1500);
                        break;
                }


            }
        }


        public static void DepositoMenu(decimal saldo)
        {
            bool opcaoValida = false;
            while (!opcaoValida)
            {
                Console.Clear();
                Console.WriteLine("1- PIX");
                Console.WriteLine("2- Transferência");
                Console.WriteLine("3- Sair");
                Console.WriteLine("Escolha a operação que deseja realizar: ");
                int opcaoMovimentacao = int.Parse(Console.ReadLine());
                switch (opcaoMovimentacao)
                {
                    case 1:
                        Pix(saldo);
                        opcaoValida = true;
                        break;
                    case 2:
                        PagamentoMenu();
                        opcaoValida = true;
                        break;
                    default:
                        AcessarMovimentacao(saldo);
                        break;


                }
            }

        }

        private static void Pix(decimal saldo)
        {
            Console.WriteLine("Bem vindo ");
            Console.WriteLine("1- Pagar");
            Console.WriteLine("2- Receber");
            int opcaoMovimentacao = int.Parse(Console.ReadLine());
            switch (opcaoMovimentacao)
            {
                case 1:
                    Console.WriteLine();
                    Console.Write("Insira a chave pix que deseja pagar: ");
                    Console.WriteLine("O seu saldo é: " + saldo);
                    break;
            }
        }
        private static void PagamentoMenu()
        {



        }


        public enum TipoMovimentacao
        {
            Debito,
            Credito,
            Pix,
            Transferencia,
        }

        public Movimentacao(int id, decimal valor)
        {
            Id = id;
            Valor = valor;
        }
    }
}
